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
		return user; 
		}
		public static User signApplicationModelToUser(ApplicationModel model) { 
		User user = new User();
			user.FullName = model.UserName;
			user.Email = model.Email; 
			user.Address= model.Address;
			user.Image = model.Image;
			user.ID = model.Id;
	return user;
		
		}
	}
}
