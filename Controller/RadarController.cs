using DataAccessSql;
using DataAccessSql.Entidades;
using static Service.Radar;

namespace Controller
{
    public class RadarController
    {

        public const string ConexaoSql = "Data Source=127.0.0.1;Initial Catalog=Persist;User id=sa;Password=SqlServer2019!; TrustServerCertificate=true;";

        private static IRadarRepository radarRepository = new RadarRepository(ConexaoSql);

        public static List<Administradoras> ImportarRadares()
        {
            var lst = Service.RadarService.ObterRadares();
            return lst;
        }

        public static void InserirRadaresSql(List<Administradoras> administradoras)
        {
            foreach (var radar in administradoras)
            {
                Administradora adm = new Administradora()
                {
                    Concessionaria = radar.Concessionaria,
                    AnoPnv = radar.AnoPnv,
                    TipoRadar = radar.TipoRadar,
                    Rodovia = radar.Rodovia,
                    Uf = radar.Uf,
                    Km = radar.Km,
                    Municipio = radar.Municipio,
                    TipoPista = radar.TipoPista,
                    Sentido = radar.Sentido,
                    Situacao = radar.Situacao,
                    DataInativacao = radar.DataInativacao,
                    Latitude = radar.Latitude,
                    Longitude = radar.Longitude,
                    Velocidade = radar.Velocidade
                };
                radarRepository.Insert(adm);
            }
        }

        public static void GerarRadaresEmXML(List<Administradoras> administradoras)
        {
            Service.RadarService.GenerateXML(administradoras);
        }
    }
}
