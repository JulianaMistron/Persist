using ClassLibrary3;
using ClassLibrary6;
using System.Data.SqlClient;

namespace ClassLibrary4
{
    public class SqlBD
    {
        public static void Salvar(List<Radar> radar)
        {
            Banco conn = new Banco();
            SqlConnection conexaoSql = new SqlConnection(conn.Caminho());
            conexaoSql.Open();

            var dados = TestFilters.GroupByConcessionariaUseLinq(radar).DistinctBy(p => p.Concessionaria);


            foreach (var item in dados)
            {
                SqlCommand cmd = new($"Insert into Persist (concessionaria, ano_do_pnv_snv, tipo_de_radar, rodovia, uf, km_m ,municipio, tipo_pista, sentido, data_da_inativacao, latitude, longitude, velocidade_leve) values ('{item.Concessionaria}', '{item.AnoPnv}', '{item.TipoRadar}', '{item.Rodovia}', '{item.Uf}', '{item.Km}', '{item.Municipio}', '{item.TipoPista}',  '{item.Sentido}',  '{item.Situacao}',  '{item.DataInativacao}',  '{item.Latitude}',  '{item.Longitude}',  '{item.Velocidade}')", conexaoSql);
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.ExecuteNonQuery();
            }
        }
    }
}
