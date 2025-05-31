using New_ProJect_MVC.Data;

namespace New_ProJect_MVC.Models.ViewModels
{
    public class UserWithRoleVM
    {
        public ApplicationUser User { get; set; }
        public IList<string> Roles { get; set; }
    }
}