using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessSql.Entidades
{
    public class Administradora
    {

        public string Concessionaria { get; set; }

        public int AnoPnv { get; set; }

        public string TipoRadar { get; set; }

        public string Rodovia { get; set; }

        public string Uf { get; set; }

        public string Km { get; set; }

        public string Municipio { get; set; }

        public string TipoPista { get; set; }

        public string Sentido { get; set; }

        public string Situacao { get; set; }

        public DateTime? DataInativacao { get; set; }

        public string Latitude { get; set; }

        public string Longitude { get; set; }

        public int Velocidade { get; set; }

    }
}
