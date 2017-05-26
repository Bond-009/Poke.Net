namespace Poke
{
    internal static class Endpoints
    {
        public const string BaseUrl = "http://pokeapi.co";

        private const string APIV2 = "/api/v2";

        public const string Berry = APIV2 + "/berry";
        public const string BerryFirmnesses = APIV2 + "/berry-firmness";
        public const string BerryFlavors = APIV2 + "/berry-flavor";
    }
}
