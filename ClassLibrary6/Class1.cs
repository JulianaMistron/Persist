using Newtonsoft.Json;

namespace ClassLibrary6
{
    public class Radar
    {
        public readonly List<Radar> radar;

        [JsonProperty("concessionaria")]
        public string Concessionaria { get; set; }

        [JsonProperty("ano_do_pnv_snv")]
        public int AnoPnv { get; set; }

        [JsonProperty("tipo_de_radar")]
        public string TipoRadar { get; set; }

        [JsonProperty("rodovia")]
        public string Rodovia { get; set; }

        [JsonProperty("uf")]
        public char Uf { get; set; }

        [JsonProperty("km_m")]
        public decimal Km { get; set; }

        [JsonProperty("municipio")]
        public string Municipio { get; set; }

        [JsonProperty("tipo_pista")]
        public string TipoPista { get; set; }

        [JsonProperty("sentido")]
        public string Sentido { get; set; }

        [JsonProperty("situacao")]
        public string Situacao { get; set; }

        [JsonProperty("data_da_inativacao")]
        public DateTime DataInativacao { get; set; }

        [JsonProperty("latitude")]
        public decimal Latitude { get; set; }

        [JsonProperty("longitude")]
        public decimal Longitude { get; set; }

        [JsonProperty("velocidade_leve")]
        public int Velocidade { get; set; }

        public override string ToString() => $"Concessionaria: {Concessionaria}, AnoPnv: {AnoPnv}, TipoRadar:{TipoRadar},Rodovia: {Rodovia}, Uf: {Uf}, Km: {Km},Municipio: {Municipio}, TipoPista: {TipoPista}, Sentido: {Sentido}, Situacao: {Situacao}, DataInativação: {DataInativacao}, Latitude; {Latitude}, Longitude: {Longitude}, Longitude: {Longitude}";
    }
}