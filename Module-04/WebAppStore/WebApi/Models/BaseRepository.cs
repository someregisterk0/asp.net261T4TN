using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public abstract class BaseRepository
    {
        protected IDbConnection connection;

        protected BaseRepository(IDbConnection connection)
        {
            this.connection = connection;
        }
    }
}
