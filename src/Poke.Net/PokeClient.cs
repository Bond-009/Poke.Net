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
        public void Dispose() => httpclient.Dispose();

        private async Task<T> GetObject<T>(string endpoint, string param)
            => JsonConvert.DeserializeObject<T>(
                    await httpclient.GetStringAsync(endpoint + "/" + param)
                );
    }
}
