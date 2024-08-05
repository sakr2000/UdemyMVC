using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using UdemyMVC.ViewModels;

namespace UdemyMVC.Controllers
{
        
    public class RoleController : Controller
    {
        private readonly RoleManager<IdentityRole> roleManager;

        public RoleController(RoleManager<IdentityRole> roleManager)
        {
            this.roleManager = roleManager;
        }
        public IActionResult AddRole()
        {
            return View("AddRole",new RoleViewModelcs());
        }
        [HttpPost]
        public async Task<IActionResult> AddRole(RoleViewModelcs vm) {
            if (ModelState.IsValid) { 
            IdentityRole role = new IdentityRole();
                role.Name = vm.Name;
            IdentityResult result=await roleManager.CreateAsync(role);
                if (!result.Succeeded) {
                    ModelState.AddModelError("", "Failed to assign Role!");  
                    return View("AddRole" , vm);
                }


                return RedirectToAction("Index", "Home");
            }

            return View("AddRole",vm);
        }
    }
}
