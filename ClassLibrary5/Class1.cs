using ClassLibrary6;
using Newtonsoft.Json;

namespace ClassLibrary5
{
    internal class Radares
    {
        [JsonProperty("radar")]
        public List<Radar> Radar { get; set; }
    }
}
