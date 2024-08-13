using Microsoft.AspNetCore.Identity;
using UdemyMVC.Models;
using UdemyMVC.ViewModels;

namespace UdemyMVC.ServiceLayer
{
	public class RegisterUser
	{
		public static ApplicationModel SignToUser(RegisterViewModels vm) {
			ApplicationModel user = new ApplicationModel(); 
		user.UserName = vm.FullName;
	    user.Email = vm.Email; 
		user.Address = vm.Address;
		user.Image = vm.Image; 
			user.Field = vm.Field;
		return user; 
		}
		
	}
}
