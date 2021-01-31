using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class MemberInRoleRepository : BaseRepository
    {
        public MemberInRoleRepository(IConfiguration configuration) : base(configuration)
        {
        }

        public int Add(MemberInRole obj)
        {
            Parameter[] parameters =
            {
                new Parameter {Name="@MemberId", Value=obj.MemberId,DbType=DbType.Guid},
                new Parameter {Name="@RoleId", Value=obj.RoleId,DbType=DbType.Guid}
            };
            return Save("AddMemberInRole", parameters, CommandType.StoredProcedure);
        }
    }
}
