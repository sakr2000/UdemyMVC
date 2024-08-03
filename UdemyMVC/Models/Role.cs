using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using UdemyMVC.AttributeValidation;

namespace UdemyMVC.Models
{
	public class Role
	{
		[Key]
        public int ID { get; set; } 
		[Required]
		[RoleNameCheck]
		public string RoleName { get; set; } = "User";//Default Value for RoleName 
		[InverseProperty("Role")] 
		/*-----------------------------------------------------------------------------------*/
		public virtual ICollection<User>? User { get; set; }
		/*-----------------------------------------------------------------------------------*/

	}
}
