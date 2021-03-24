using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class ProvinceRepository : BaseRepository
    {
        public ProvinceRepository(IDbConnection connection) : base(connection)
        {
        }

        public IEnumerable<Province> GetProvinces()
        {
            string sql = "SELECT * FROM Province";
            return connection.Query<Province>(sql);
        }
    }
}
