using Microsoft.Extensions.Configuration;
using System.Data;

namespace WebApp.Models
{
    public class MemberInRoleRepository : BaseRepository
    {
        public MemberInRoleRepository(IConfiguration configuration) : base(configuration) { }
        public int Add(MemberInRole obj)
        {

            Parameter[] parameters =
            {
                new Parameter{ Name  = "@MemberId", Value = obj.MemberId, DbType = DbType.Guid },
                new Parameter{ Name = "@RoleId", Value = obj.RoleId, DbType = DbType.Guid}
            };
            return Save("AddMemberInRole", parameters, CommandType.StoredProcedure);
        }
    }
}