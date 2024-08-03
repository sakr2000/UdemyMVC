using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using UdemyMVC.ViewModels;

namespace UdemyMVC.Controllers
{
    public class LoginController : Controller
    {
        private readonly UserManager<IdentityUser> userManager;
        private readonly SignInManager<IdentityUser> signInManager;

        public LoginController(UserManager<IdentityUser> userManager , 
            SignInManager<IdentityUser> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }
        public IActionResult Login()
        {
            return View("Login",new LoginViewModelcs());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Login(LoginViewModelcs vm ) {
            if (ModelState.IsValid) {
          IdentityUser? userModel= await userManager.FindByEmailAsync(vm.Email);
                if (userModel != null)
                {
                    bool found = await userManager.CheckPasswordAsync(userModel, vm.Password);
                    if (found)
                    {
                        await signInManager.SignInAsync(userModel, vm.RememberMe);
                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        ModelState.AddModelError("", "Invalid User Name or Password!");
                        return View("Login", vm);
                    }

                }
                else {
                    ModelState.AddModelError("", "Invlid Login");
                    return View("Login", vm);
                
                } 
            }


            return View("Login",vm);
        }
    }
}
