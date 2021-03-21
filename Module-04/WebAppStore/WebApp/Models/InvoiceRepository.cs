using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class InvoiceRepository : BaseRepository
    {
        public InvoiceRepository(IDbConnection connection) : base(connection)
        {
        }

        public int Add(Invoice obj)
        {
            return connection.Execute("AddInvoice", new { CartId = obj.CartId, Fullname = obj.Fullname, Email = obj.Email, Phone = obj.Phone, Address = obj.Address }, commandType: CommandType.StoredProcedure);
        }

        public Invoice GetInvoiceById(Guid id)
        {
            string sql = "SELECT * FROM Invoice WHERE InvoiceId = @Id";
            return connection.QuerySingle<Invoice>(sql, new { Id = id });
        }
    }
}
