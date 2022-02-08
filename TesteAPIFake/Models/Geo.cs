using Newtonsoft.Json;

namespace TesteAPIFake.Models
{
    public partial class Geo
    {
        [JsonProperty("lat")]
        public string Lat { get; set; }

        [JsonProperty("lng")]
        public string Lng { get; set; }
    }
}
