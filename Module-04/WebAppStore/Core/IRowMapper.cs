using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Core
{
    public interface IRowMapper<T>
    {
        T MapRow(IDataReader reader);
    }
}
