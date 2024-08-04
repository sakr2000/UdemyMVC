using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using UdemyMVC.Models;
using UdemyMVC.ServiceLayer;
using UdemyMVC.ViewModels;

namespace UdemyMVC.Controllers
{
	public class RegisterController : Controller
	{
		UdemyDataBase context; 
		private readonly UserManager<ApplicationModel> userManager;
		private readonly SignInManager<ApplicationModel> signInManager;
		private readonly RoleManager<IdentityRole> roleManager;

		public RegisterController(UserManager<ApplicationModel> userManager ,SignInManager<ApplicationModel>signInManager,
			RoleManager<IdentityRole> roleManager , 
			UdemyDataBase _context)
        {
			this.userManager = userManager; 
			this.signInManager = signInManager;
			this.roleManager = roleManager;
			this.context = _context;
		}


		[HttpGet]
		public IActionResult Register()
		{ 
			return View("Register" , new RegisterViewModels());
		}
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Register(RegisterViewModels vm )
		{
			if (ModelState.IsValid)
			{
				
				User user;
				if (!await roleManager.RoleExistsAsync(vm.Role))
				{
					IdentityResult result1 = await roleManager.CreateAsync(new IdentityRole(vm.Role)) ; 
					if (!result1.Succeeded) {
						ModelState.AddModelError("", "failed to create role!"); 
						return View(vm);	
					}

					

                }

                var userModel = RegisterUser.SignToUser(vm);//var for any change in IdenetityUser(clean code)
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
				 user = RegisterUser.signApplicationModelToUser(userModel);
			user.RoleName = vm.Role;
                context.Users.Add(user);
				List<Claim> claims = new List<Claim>();
				claims.Add(new Claim(ClaimTypes.NameIdentifier, user.ID));
	 		await signInManager.SignInWithClaimsAsync(userModel, vm.RememberMe, claims); 
				context.SaveChanges();
				return RedirectToAction("Index" ,"Home");
				} 
			
				
			
		return View(vm);
		}
	}
}
