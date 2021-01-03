using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace WinApp
{
    class MovieRepository : BaseRepository
    {
        public void Add(DataTable table)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlBulkCopy bulkCopy = new SqlBulkCopy(connection))
                {
                    bulkCopy.DestinationTableName = "Movie";
                    bulkCopy.WriteToServer(table);
                }
            }
        }
    }
}
