using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Xml.Linq;
using static Service.Radar;

namespace Service
{
    public class RadarService
    {

        public static List<Administradoras> ObterRadares()
        {
            var lst = GetData("C:\\Users\\jumis\\dados_dos_radares.json");
            return lst;
        }

        private static List<Administradoras> GetData(string path)
        {
            StreamReader r = new StreamReader(path);
            string jsonString = r.ReadToEnd();

            var lst = JsonConvert.DeserializeObject<Radar>(jsonString, new IsoDateTimeConverter { DateTimeFormat = "dd/MM/yyyy" });

            if (lst != null) return lst.ConcessionariasAdministradoras;
            return null;
        }

        public static string GenerateXML(List<Administradoras> lista)
        {
            if (lista.Count > 0)
            {
                var radar = new XElement("Root", from data in lista
                                                     // em laranja escreve igual esta no json
                                                 select new XElement("concessionaria",
                                                 new XElement("ano_do_pnv_snv", data.AnoPnv),
                                                 new XElement("tipo_de_radar", data.TipoRadar),
                                                 new XElement("rodovia", data.Rodovia),
                                                 new XElement("uf", data.Uf),
                                                 new XElement("km_m", data.Km),
                                                 new XElement("municipio", data.Municipio),
                                                 new XElement("tipo_pista", data.TipoPista),
                                                 new XElement("sentido", data.Sentido),
                                                 new XElement("situacao", data.Situacao),
                                                 new XElement("data_da_inativacao", data.DataInativacao),
                                                 new XElement("latitude", data.Latitude),
                                                 new XElement("longitude", data.Longitude),
                                                 new XElement("velocidade_leve", data.Velocidade)

                                                 )
                                                               );

                // Write the string array to a new file named "WriteLines.txt".
                using (StreamWriter outputFile = new StreamWriter(Path.Combine("C:\\Users\\jumis\\", "Radares_XML.xml")))
                {
                        outputFile.Write(radar.ToString());
                }

                return radar.ToString();
            }
            else
            {
                return "Não existem registros.";
            }
        }
    }
}
