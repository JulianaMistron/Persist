using DataAccessSql.Entidades;
using System.Data.SqlClient;

namespace DataAccessSql
{
    public class RadarRepository : IRadarRepository
    {
        public SqlConnection conexaoSql;

        public RadarRepository(string stringConexaoSql)
        {
            this.conexaoSql = new SqlConnection(stringConexaoSql);
            conexaoSql.Open();
        }

        public IEnumerable<Administradora> GetAll()
        {
            List<Administradora> radares = new();   
            SqlCommand cmd = new($"Select concessionaria, ano_do_pnv_snv, tipo_de_radar, rodovia, uf, km_m ,municipio, tipo_pista, sentido, data_da_inativacao, latitude, longitude, velocidade_leve from Persist", conexaoSql);
            cmd.CommandType = System.Data.CommandType.Text;
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    var radar = new Administradora
                    {
                        Concessionaria = reader["concessionaria"].ToString(),
                        AnoPnv = (int)reader["ano_do_pnv_snv"],
                        DataInativacao = (DateTime?)reader["data_da_inativacao"],
                        Km = reader["km_m"].ToString(),
                        Latitude = reader["latitude"].ToString(),
                        Longitude = reader["longitude"].ToString(),
                        Municipio = reader["municipio"].ToString(),
                        Rodovia = reader["rodovia"].ToString(),
                        Sentido = reader["sentido"].ToString(),
                        Situacao = reader["situacao"].ToString(),
                        TipoPista = reader["tipo_pista"].ToString(),
                        TipoRadar = reader["tipo_de_radar"].ToString(),
                        Uf = reader["uf"].ToString(),
                        Velocidade = (int)reader["velocidade_leve"]
                    };
                    radares.Add(radar);
                }
            }
            return radares;
        }

        public void Insert(Administradora radar)
        {
            SqlCommand cmd = new($"Insert into Persist (concessionaria, ano_do_pnv_snv, tipo_de_radar, rodovia, uf, km_m ,municipio, tipo_pista, sentido, situacao, data_da_inativacao, latitude, longitude, velocidade_leve) values ('{radar.Concessionaria}', '{radar.AnoPnv}', '{radar.TipoRadar}', '{radar.Rodovia}', '{radar.Uf}', '{radar.Km}', '{radar.Municipio}', '{radar.TipoPista}',  '{radar.Sentido}',  '{radar.Situacao}',  '{radar.DataInativacao}',  '{radar.Latitude}',  '{radar.Longitude}',  '{radar.Velocidade}')", conexaoSql);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.ExecuteNonQuery();
        }

    }
}
