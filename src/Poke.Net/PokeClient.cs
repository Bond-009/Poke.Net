using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Extensions.Caching.Memory;

namespace Poke
{
    public class PokeClient : IDisposable
    {
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
                _httpClient.BaseAddress = new Uri(Endpoints.BaseUrl);
            }

            _useCache = useCache;
            if (_useCache)
            {
                _memoryCache = new MemoryCache(CacheOptions ?? new MemoryCacheOptions());
                _cacheExpiration = cacheExpiration ?? new TimeSpan(0, 5, 0);
            }
        }

        public Task<Berry> GetBerryAsync(string name)
        {
            if (string.IsNullOrEmpty(name)) throw new ArgumentNullException("name");

            return GetObject<Berry>(Endpoints.Berry, name);
        }

        public Task<Berry> GetBerryAsync(int id)
            => GetObject<Berry>(Endpoints.Berry, id.ToString());

        public Task<BerryFirmness> GetBerryFirmnessAsync(string name)
        {
            if (string.IsNullOrEmpty(name)) throw new ArgumentNullException("name");

            return GetObject<BerryFirmness>(Endpoints.BerryFirmness, name);
        }

        public Task<BerryFirmness> GetBerryFirmnessAsync(int id)
            => GetObject<BerryFirmness>(Endpoints.BerryFirmness, id.ToString());

        public Task<BerryFlavor> GetBerryFlavorAsync(string name)
        {
            if (string.IsNullOrEmpty(name)) throw new ArgumentNullException("name");

            return GetObject<BerryFlavor>(Endpoints.BerryFlavor, name);
        }

        public Task<BerryFlavor> GetBerryFlavorAsync(int id)
            => GetObject<BerryFlavor>(Endpoints.BerryFlavor, id.ToString());

        public Task<ContestType> GetContestTypeAsync(string name)
        {
            if (string.IsNullOrEmpty(name)) throw new ArgumentNullException("name");

            return GetObject<ContestType>(Endpoints.ContestType, name);
        }

        public Task<ContestType> GetContestTypeAsync(int id)
            => GetObject<ContestType>(Endpoints.ContestType, id.ToString());

        public Task<ContestEffect> GetContestEffectAsync(int id)
            => GetObject<ContestEffect>(Endpoints.ContestEffect, id.ToString());

        public Task<SuperContestEffect> GetSuperContestEffectAsync(int id)
            => GetObject<SuperContestEffect>(Endpoints.SuperContestEffect, id.ToString());

        /// <summary>
        /// Releases the unmanaged resources and disposes of the managed resources used.
        /// </summary>
        public void Dispose() => _memoryCache.Dispose();

        private async Task<T> GetObject<T>(string endpoint, string param)
        {
            if (!_useCache) return await DeserializeObject<T>(endpoint, param);

            T temp = _memoryCache.Get<T>(typeof(T).Name + param);

            if (temp != null) return temp;

            lock (_lockObject)
            {
                temp = _memoryCache.Get<T>(typeof(T).Name + param);

                if (temp != null) return temp;

                temp = DeserializeObject<T>(endpoint, param).GetAwaiter().GetResult();
                _memoryCache.Set<T>(typeof(T).Name + param, temp, _cacheExpiration);
                return temp;
            }
        }

        private async Task<T> DeserializeObject<T>(string endpoint, string param)
            => JsonConvert.DeserializeObject<T>(
                    await _httpClient.GetStringAsync(endpoint + "/" + param)
                );
    }
}
