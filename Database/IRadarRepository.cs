using DataAccessSql.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessSql
{
    public interface IRadarRepository
    {
        public IEnumerable<Administradora> GetAll();
        public void Insert(Administradora radar);
    }
}
