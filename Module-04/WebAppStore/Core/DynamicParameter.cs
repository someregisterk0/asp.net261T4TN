using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Core
{
    public class DynamicParameter
    {
        Dictionary<string, Parameter> parameters = new Dictionary<string, Parameter>();

        public void Add(string name, object value = null, DbType dbType = DbType.String, ParameterDirection direction = ParameterDirection.Input)
        {
            parameters[name] = new Parameter
            {
                Name = name,
                Value = value,
                DbType = dbType,
                Direction = direction 
            };
        }

        public void Handle(IDbCommand command)
        {
            foreach (Parameter item in parameters.Values)
            {
                IDbDataParameter parameter = command.CreateParameter();
                parameter.Value = item.Value;
                parameter.ParameterName = item.Name;
                parameter.DbType = item.DbType;
                parameter.Direction = item.Direction;
                command.Parameters.Add(parameter);
            }
        }
    }
}
