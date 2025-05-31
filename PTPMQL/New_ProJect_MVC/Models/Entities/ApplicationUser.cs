using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using New_ProJect_MVC.Data;

namespace New_ProJect_MVC.Data
{
    public class ApplicationUser : IdentityUser
    {
        [PersonalData]
        public string? Fullname { get; set; }
        public string FullName { get; internal set; }
    }
}
