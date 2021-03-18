using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Core
{
    public abstract class BaseRepository<T>
    {
        protected IDbConnection connection;

        public BaseRepository(IDbConnection connection)
        {
            this.connection = connection;
        }

        protected int Save(string sql, DynamicParameter parameter, CommandType commandType = CommandType.Text)
        {
            using (IDbCommand command = connection.CreateCommand())
            {
                command.CommandText = sql;
                command.CommandType = commandType;

                parameter.Handle(command);

                return command.ExecuteNonQuery();
            }
        }

        protected List<T> FetchAll(string sql, CommandType commandType = CommandType.Text)
        {
            /*using (IDbCommand command = connection.CreateCommand())
            {
                command.CommandText = sql;
                using (IDataReader reader = command.ExecuteReader())
                {
                    List<T> list = new List<T>();
                    while (reader.Read())
                    {
                        list.Add(Fetch(reader));
                    }
                    return list;
                }
            }*/
            return FetchAll(sql, null, commandType);
        }

        protected List<T> FetchAll(string sql, DynamicParameter parameter, CommandType commandType = CommandType.Text)
        {
            using (IDbCommand command = connection.CreateCommand())
            {
                command.CommandText = sql;
                command.CommandType = commandType;

                if (parameter != null)
                {
                    parameter.Handle(command);
                }

                using (IDataReader reader = command.ExecuteReader())
                {
                    List<T> list = new List<T>();
                    while (reader.Read())
                    {
                        list.Add(Fetch(reader));
                    }
                    return list;
                }
            }
        }

        // RowMapper voi Interface
        protected List<T> FetchAll(string sql, IRowMapper<T> mapper, CommandType commandType = CommandType.Text)
        {
            using (IDbCommand command = connection.CreateCommand())
            {
                command.CommandText = sql;
                command.CommandType = commandType;

                using (IDataReader reader = command.ExecuteReader())
                {
                    List<T> list = new List<T>();
                    while (reader.Read())
                    {
                        list.Add(mapper.MapRow(reader));
                    }
                    return list;
                }
            }
        }

        protected T FetchOne(string sql, DynamicParameter parameter, CommandType commandType = CommandType.Text)
        {
            using (IDbCommand command = connection.CreateCommand())
            {
                command.CommandText = sql;
                command.CommandType = CommandType.Text;

                parameter.Handle(command);

                using (IDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        Fetch(reader);
                    }
                    return default(T);
                }
            }
        }

        protected abstract T Fetch(IDataReader reader);
    }
}
