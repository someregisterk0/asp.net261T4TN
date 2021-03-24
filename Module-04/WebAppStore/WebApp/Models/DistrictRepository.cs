using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class DistrictRepository : BaseRepository
    {
        public DistrictRepository(IDbConnection connection) : base(connection)
        {
        }

        public IEnumerable<District> GetDistricts(string provinceId)
        {
            string sql = "SELECT * FROM District WHERE ProvinceId = @Id";
            return connection.Query<District>(sql, new { Id = provinceId });
        }
    }
}
