using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using UdemyMVC.Models;
using UdemyMVC.ServiceLayer;
using UdemyMVC.ViewModels;

namespace UdemyMVC.Controllers
{
	public class RegisterController : Controller
	{
		private readonly UserManager<IdentityUser> userManager;
		private readonly SignInManager<IdentityUser> signInManager;
		private readonly RoleManager<IdentityRole> roleManager;

		public RegisterController(UserManager<IdentityUser> userManager ,SignInManager<IdentityUser>signInManager,
			RoleManager<IdentityRole> roleManager)
        {
			this.userManager = userManager; 
			this.signInManager = signInManager;
			this.roleManager = roleManager;
		}


		[HttpGet]
		public IActionResult Register()
		{ 
			return View("Register" , new RegisterViewModels());
		}
		[HttpPost]
		public async Task<IActionResult> Register(RegisterViewModels vm )
		{
			if (ModelState.IsValid)
			{
				if (!await roleManager.RoleExistsAsync(vm.Role))
				{
					IdentityResult result1 = await roleManager.CreateAsync(new IdentityRole(vm.Role)) ; 
					if (!result1.Succeeded) {
						ModelState.AddModelError("", "failed to create role!"); 
						return View(vm);	
					}
				}
				
					IdentityUser userModel = RegisterUser.SignToUser(vm);
					IdentityResult result=await userManager.CreateAsync(userModel , vm.Password);
				if (!result.Succeeded)
				{
					foreach (var err in result.Errors) {
						ModelState.AddModelError("", err.Description); 
					} 
					return View(vm);
				} 
				IdentityResult role = await userManager.AddToRoleAsync(userModel, vm.Role);
				if (!role.Succeeded) {
					ModelState.AddModelError("", "Failed to assign Role");
					return View(vm); 
				}
				
				return RedirectToAction("Index" ,"Home");
				} 
			
				
			
		return View(vm);
		}
	}
}
