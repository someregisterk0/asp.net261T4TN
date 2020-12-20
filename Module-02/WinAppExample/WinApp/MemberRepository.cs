using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace WinApp
{
    class MemberRepository : BaseRepository
    {
        public int Add(Member obj)
        {
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                using (IDbCommand command = connection.CreateCommand())
                {
                    command.CommandText = "AddMember";
                    command.CommandType = CommandType.StoredProcedure;

                    IDataParameter usernameParameter = command.CreateParameter();
                    usernameParameter.ParameterName = "@Username";
                    usernameParameter.Value = obj.Username;
                    command.Parameters.Add(usernameParameter);

                    IDataParameter passwordParameter = command.CreateParameter();
                    passwordParameter.ParameterName = "@Password";
                    passwordParameter.Value = obj.Password;
                    command.Parameters.Add(passwordParameter);

                    IDataParameter emailParameter = command.CreateParameter();
                    emailParameter.ParameterName = "@Email";
                    emailParameter.Value = obj.Email;
                    command.Parameters.Add(emailParameter);

                    IDataParameter retParameter = command.CreateParameter();
                    retParameter.Direction = ParameterDirection.ReturnValue;
                    retParameter.ParameterName = "@Ret";
                    command.Parameters.Add(retParameter);

                    connection.Open();
                    command.ExecuteNonQuery();

                    IDataParameter ret = (IDataParameter)command.Parameters["@Ret"];
                    return (int)ret.Value;
                }
            }
        }

        public Member SignIn(string usr, string pwd, out int ret)
        {
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                using (IDbCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SignIn";
                    command.CommandType = CommandType.StoredProcedure;

                    IDataParameter usernameParameter = command.CreateParameter();
                    usernameParameter.ParameterName = "@Username";
                    usernameParameter.Value = usr;
                    command.Parameters.Add(usernameParameter);

                    IDataParameter passwordParameter = command.CreateParameter();
                    passwordParameter.ParameterName = "@Password";
                    passwordParameter.Value = pwd;
                    command.Parameters.Add(passwordParameter);

                    IDataParameter retParameter = command.CreateParameter();
                    retParameter.Direction = ParameterDirection.ReturnValue;
                    retParameter.ParameterName = "@Ret";
                    command.Parameters.Add(retParameter);

                    connection.Open();
                    Member obj = null;
                    using (IDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            obj = new Member
                            {
                                Id = (Guid)reader["MemberId"],
                                Username = (string)reader["Username"],
                                Email = (string)reader["Email"]
                            };
                        }
                    }

                    IDataParameter retp = (IDataParameter)command.Parameters["@Ret"];
                    ret = (int)retp.Value;
                    return obj;
                }
            }
        }
    }
}
