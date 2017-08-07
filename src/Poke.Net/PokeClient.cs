using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.Extensions.Caching.Memory;

namespace Poke
{
    public class PokeClient : IDisposable
    {
        private const string BaseUrl = "http://pokeapi.co";
        private const string APIV2 = "/api/v2";

        private static HttpClient _httpClient;
        private readonly bool _useCache;
        private readonly object _lockObject = new object();
        private readonly MemoryCache _memoryCache;
        private readonly TimeSpan _cacheExpiration;

        public PokeClient(bool useCache = true, MemoryCacheOptions CacheOptions = null, TimeSpan? cacheExpiration = null)
        {
            if (_httpClient == null)
            {
                _httpClient = new HttpClient();
                _httpClient.BaseAddress = new Uri(BaseUrl);
            }

            _useCache = useCache;
            if (_useCache)
            {
                _memoryCache = new MemoryCache(CacheOptions ?? new MemoryCacheOptions());
                _cacheExpiration = cacheExpiration ?? new TimeSpan(0, 5, 0);
            }
        }

        public Task<T> GetResourceAsync<T>(string name) where T : NamedResource
            => getObject<T>(name);

        public Task<T> GetResourceAsync<T>(int id) where T : Resource
            => getObject<T>(id.ToString());

        /// <summary>
        /// Releases the unmanaged resources and disposes of the managed resources used.
        /// </summary>
        public void Dispose() => _memoryCache.Dispose();

        private async Task<T> getObject<T>(string param)
        {
            Type type = typeof(T);
            TypeInfo typeInfo = type.GetTypeInfo();
            if (typeInfo.IsAbstract ||
                typeInfo.Namespace != this.GetType().GetTypeInfo().Namespace)
            {
                throw new Exception("You can't do that!!!");
            }

            string relativeURL = APIV2 + "/" + Regex.Replace(type.Name, @"(?<=[a-z])([A-Z])", @"-$1").ToLower() + "/" + param;

            if (!_useCache) return await deserializeObject<T>(relativeURL);

            T temp = _memoryCache.Get<T>(relativeURL);

            if (temp != null) return temp;

            lock (_lockObject)
            {
                temp = _memoryCache.Get<T>(relativeURL);

                if (temp != null) return temp;

                temp = deserializeObject<T>(relativeURL).GetAwaiter().GetResult();
                _memoryCache.Set<T>(relativeURL, temp, _cacheExpiration);
                return temp;
            }
        }

        private async Task<T> deserializeObject<T>(string relativeURL)
            => JsonConvert.DeserializeObject<T>(
                    await _httpClient.GetStringAsync(relativeURL).ConfigureAwait(false)
                );
    }
}
