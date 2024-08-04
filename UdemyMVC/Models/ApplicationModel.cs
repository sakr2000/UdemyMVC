using Microsoft.AspNetCore.Identity;
using System.Reflection.Metadata.Ecma335;

namespace UdemyMVC.Models
{
    public class ApplicationModel:IdentityUser
    {
        public string Address { get; set; }
        public string Image { get; set; }
    }
}
