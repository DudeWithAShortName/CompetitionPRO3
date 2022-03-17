using Competition_PRO.Data.Models;
using Competition_PRO.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Competition_PRO.Controllers
{
    public class AdministrationController : Controller
    {
        private readonly RoleManager<ApplicationRole> roleManager;

        public AdministrationController(RoleManager<ApplicationRole> roleManager)
        {
            this.roleManager = roleManager;
        }
        //action CreateRole
        public IActionResult CreateRole()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateRole(CreateRoleViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            ApplicationRole identityRole = new ApplicationRole
            {
                Name = model.RoleName
            };
            //добавяне на роля в базата данни
            var result = await roleManager.CreateAsync(identityRole);
            if (result.Succeeded)
            {
                return Redirect("/");
            }
            else
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            return View(model);
        }
    }

}
