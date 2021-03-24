using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class WardRepository : BaseRepository
    {
        public WardRepository(IDbConnection connection) : base(connection)
        {
        }

        public IEnumerable<Ward> GetWards(string districtId)
        {
            string sql = "SELECT * FROM Ward WHERE DistrictId = @Id";
            return connection.Query<Ward>(sql, new { Id = districtId });
        }
    }
}
