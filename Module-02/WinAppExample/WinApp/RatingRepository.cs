using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace WinApp
{
    class RatingRepository : BaseRepository
    {
        // Method 1 - CHẬM
        public int Add(List<Rating> list)
        {
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                using (IDbCommand command = connection.CreateCommand())
                {
                    command.CommandText = "AddRating";
                    command.CommandType = CommandType.StoredProcedure;

                    IDataParameter userIdParameter = command.CreateParameter();
                    userIdParameter.ParameterName = "@UserId";
                    command.Parameters.Add(userIdParameter);

                    IDataParameter movieIdParameter = command.CreateParameter();
                    movieIdParameter.ParameterName = "@MovieId";
                    command.Parameters.Add(movieIdParameter);

                    IDataParameter ratingParameter = command.CreateParameter();
                    ratingParameter.ParameterName = "@Rating";
                    command.Parameters.Add(ratingParameter);

                    IDataParameter timestampParameter = command.CreateParameter();
                    timestampParameter.ParameterName = "@Timestamp";
                    command.Parameters.Add(timestampParameter);

                    connection.Open();

                    int s = 0;
                    foreach (Rating item in list)
                    {
                        ((IDataParameter)command.Parameters["@UserId"]).Value = item.UserId;
                        ((IDataParameter)command.Parameters["@MovieId"]).Value = item.MovieId;
                        ((IDataParameter)command.Parameters["@Rating"]).Value = item.Ratings;
                        ((IDataParameter)command.Parameters["@Timestamp"]).Value = item.Timestamp;
                        s += command.ExecuteNonQuery();
                    }
                    return s;
                }
            }
        }

        // Method 2 - NHANH
        public void Add(DataTable table)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlBulkCopy bulkCopy = new SqlBulkCopy(connection))
                {
                    bulkCopy.DestinationTableName = "Rating";
                    bulkCopy.WriteToServer(table);
                }
            }
        }
    }
}
