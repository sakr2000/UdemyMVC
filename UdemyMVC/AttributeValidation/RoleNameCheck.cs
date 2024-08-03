using System.ComponentModel.DataAnnotations;

namespace UdemyMVC.AttributeValidation
{
	public class RoleNameCheck:ValidationAttribute 
	{
		public override bool IsValid(object? value)
		{ 
			string? roleName = value as string; 
			if (roleName.Equals("Admin") || roleName.Equals("Instructor") || roleName.Equals("User"))
			{
				return true; 
			}
			else { 
			return false;
			}
		
		}
	}
}
