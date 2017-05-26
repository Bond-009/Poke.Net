namespace Poke
{
    internal static class Endpoints
    {
        public const string BaseUrl = "http://pokeapi.co";

        private const string APIV2 = "/api/v2";

        public const string Berry = APIV2 + "/berry";
        public const string BerryFirmness = APIV2 + "/berry-firmness";
        public const string BerryFlavor = APIV2 + "/berry-flavor";
        public const string ContestType = APIV2 + "/contest-type";
        public const string ContestEffect = APIV2 + "/contest-effect";
        public const string SuperContestEffect = APIV2 + "/super-contest-effect";
    }
}
