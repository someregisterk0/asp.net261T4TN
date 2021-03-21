using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Text;
using Dapper;

namespace WebApp.Models
{
    public class AccountRepository : BaseRepository
    {
        public AccountRepository(IDbConnection connection) : base(connection)
        {
        }

        static byte[] Hash(string plaintext)
        {
            HashAlgorithm hash = HashAlgorithm.Create("SHA512");
            return hash.ComputeHash(Encoding.ASCII.GetBytes(plaintext));
        }

        public Account SignIn(SignInModel obj)
        {
            string sql = "SELECT AccountId, Username, Email FROM Account WHERE Username = @Usr AND Password = @Pwd";
            return connection.QuerySingleOrDefault<Account>(sql, new { Usr = obj.Usr, Pwd = Hash(obj.Pwd) });
        }
    }
}
