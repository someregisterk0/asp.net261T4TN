using System.Data;

namespace WebApp.Models
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
