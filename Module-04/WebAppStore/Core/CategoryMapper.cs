using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Core
{
    class CategoryMapper : IRowMapper<Category>
    {
        public Category MapRow(IDataReader reader)
        {
            return new Category
            {
                Id = (short)reader["CategoryId"],
                Name = (string)reader["CategoryName"]
            };
        }
    }
}
