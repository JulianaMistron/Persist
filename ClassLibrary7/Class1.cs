using ClassLibrary6;
using Newtonsoft.Json;

namespace ClassLibrary7
{

    internal class Radares
    {
        [JsonProperty("dados_dos_radares")]
        public List<Radar> Radar { get; set; }
    }
}
