using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using WebApp.Models;

namespace WebApp.Controllers
{
    public class MemberController : Controller
    {
        MemberRepository repository;
        // khuyet
        RoleRepository roleRepository;

        MemberInRoleRepository memberInRoleRepository;

        public MemberController(IConfiguration configuration)
        {
            repository = new MemberRepository(configuration);
            roleRepository = new RoleRepository(configuration);
            memberInRoleRepository = new MemberInRoleRepository(configuration);
        }

        public IActionResult Index()
        {
            return View(repository.GetMembers());
        }

        public IActionResult Roles(Guid id)
        {
            Member obj = repository.GetMemberById(id);
            // chua dung
            //obj.Roles = roleRepository.GetRoles();
            obj.Roles = roleRepository.GetRolesByMember(id);

            return View(obj);
        }

        public IActionResult Add(MemberInRole obj)
        {
            return Json(memberInRoleRepository.Add(obj));
        }
    }
}
