using Microsoft.AspNetCore.Identity;
using UdemyMVC.Models;
using UdemyMVC.ViewModels;

namespace UdemyMVC.ServiceLayer
{
	public class RegisterUser
	{
		public static IdentityUser SignToUser(RegisterViewModels vm) {
		IdentityUser user = new IdentityUser();	
		user.UserName = vm.FullName;
	    user.Email = vm.Email;
		return user; 
		}
	}
}
