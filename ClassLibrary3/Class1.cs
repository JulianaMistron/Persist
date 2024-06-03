using ClassLibrary6;
using System.Xml.Linq;

namespace ClassLibrary3
{
    public class TestFilters
    {
        public static int getCountRecords(List<Radar> lista) => lista.Count;

        public static void PrintData(List<Radar> lista2)
        {
            foreach (var item in lista2)
            {
                Console.WriteLine(item);
            }
        }
        public static string GenerateXML(List<Radar> lista)
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
                return radar.ToString();
            }
            else
            {
                return "Não existem registros.";
            }
        }

        public static object GroupByConcessionariaUseLinq(List<Radar> radar)
        {
            throw new NotImplementedException();
        }
    }
}