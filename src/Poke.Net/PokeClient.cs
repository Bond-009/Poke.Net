using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Poke
{
    public class PokeClient : IDisposable
    {
        HttpClient httpclient = new HttpClient();

        public PokeClient()
            => httpclient.BaseAddress = new Uri(Endpoints.BaseUrl);

        public Task<Berry> GetBerryAsync(string name)
        {
            if (string.IsNullOrEmpty(name)) throw new ArgumentNullException("name");

            return GetObject<Berry>(Endpoints.Berry, name);
        }

        public Task<Berry> GetBerryAsync(int id)
            => GetObject<Berry>(Endpoints.Berry, id.ToString());

        public Task<BerryFirmnesses> GetBerryFirmnessesAsync(string name)
        {
            if (string.IsNullOrEmpty(name)) throw new ArgumentNullException("name");

            return GetObject<BerryFirmnesses>(Endpoints.BerryFirmnesses, name);
        }

        public Task<BerryFirmnesses> GetBerryFirmnessesAsync(int id)
            => GetObject<BerryFirmnesses>(Endpoints.BerryFirmnesses, id.ToString());

        public Task<BerryFlavors> GetBerryFlavorsAsync(string name)
        {
            if (string.IsNullOrEmpty(name)) throw new ArgumentNullException("name");

            return GetObject<BerryFlavors>(Endpoints.BerryFlavors, name);
        }

        public Task<BerryFlavors> GetBerryFlavorsAsync(int id)
            => GetObject<BerryFlavors>(Endpoints.BerryFlavors, id.ToString());

        /// <summary>
        /// Releases the unmanaged resources and disposes of the managed resources used.
        /// </summary>
        public void Dispose() => httpclient.Dispose();

        private async Task<T> GetObject<T>(string endpoint, string param)
            => JsonConvert.DeserializeObject<T>(
                    await httpclient.GetStringAsync(endpoint + "/" + param)
                );
    }
}
