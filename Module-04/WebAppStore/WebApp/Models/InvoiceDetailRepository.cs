using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class InvoiceDetailRepository : BaseRepository
    {
        public InvoiceDetailRepository(IDbConnection connection) : base(connection)
        {
        }

        public IEnumerable<InvoiceDetail> GetInvoiceDetailByInvoice(Guid id)
        {
            string sql = "SELECT InvoiceDetail.*, ProductName, ImageUrl FROM InvoiceDetail JOIN Product ON InvoiceDetail.ProductId = Product.ProductId WHERE InvoiceId = @Id";
            return connection.Query<InvoiceDetail>(sql, new { Id = id });
        }
    }
}
