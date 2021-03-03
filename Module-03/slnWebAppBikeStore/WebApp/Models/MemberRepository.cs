using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.Data;
using Microsoft.Data.SqlClient;

namespace WebApp.Models
{
    public class MemberRepository : BaseRepository
    {
        public MemberRepository(IConfiguration configuration) : base(configuration)
        {
        }

        public int Add(Member obj)
        {
            Parameter[] parameters = { 
                new Parameter{ Name = "@Username", Value = obj.Username },
                new Parameter{ Name = "@Password", Value = Helper.Hash(obj.Password), DbType = DbType.Binary },
                new Parameter{ Name = "@Email", Value = obj.Email },
                new Parameter{ Name = "@Gender", Value = obj.Gender },
                new Parameter{ Name = "@Ret", Direction = ParameterDirection.ReturnValue }
            };

            return Save("AddMember", parameters, CommandType.StoredProcedure);
            //return (int)parameters[4].Value;
        }

        public List<Member> GetMembers()
        {
            using (IDbConnection connection = new SqlConnection(configuration.GetConnectionString("BikeStore")))
            {
                using (IDbCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT * FROM Member";
                    command.CommandType = CommandType.Text;

                    connection.Open();

                    using (IDataReader reader = command.ExecuteReader())
                    {
                        List<Member> list = new List<Member>();
                        while (reader.Read())
                        {
                            list.Add(Fetch(reader));
                        }
                        return list;
                    }
                }
            }
        }

        public Member SignIn(SignInModel obj)
        {
            using (IDbConnection connection = new SqlConnection(configuration.GetConnectionString("BikeStore")))
            {
                using (IDbCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SignIn";
                    command.CommandType = CommandType.StoredProcedure;
                    Add(command, new Parameter { Name = "@Usr", Value = obj.Usr });
                    Add(command, new Parameter { Name = "@Pwd", Value = Helper.Hash(obj.Pwd), DbType = DbType.Binary });

                    connection.Open();

                    using (IDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return Fetch(reader);
                        }
                        return null;
                    }
                }
            }
        }

        public Member GetMemberById(Guid id)
        {
            using (IDbConnection connection = new SqlConnection(configuration.GetConnectionString("BikeStore")))
            {
                using (IDbCommand command = connection.CreateCommand())
                {
                    command.CommandText = "GetMemberById";
                    command.CommandType = CommandType.StoredProcedure;
                    Add(command, new Parameter { Name = "@Id", Value = id, DbType = DbType.Guid });

                    connection.Open();

                    using (IDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return Fetch(reader);
                        }
                        return null;
                    }
                }
            }
        }

        static Member Fetch(IDataReader reader)
        {
            return new Member
            {
                Id = (Guid)reader["MemberId"],
                Username = (string)reader["Username"],
                Email = (string)reader["Email"],
                Gender = (byte)reader["Gender"]
            };
        }
    }
}
