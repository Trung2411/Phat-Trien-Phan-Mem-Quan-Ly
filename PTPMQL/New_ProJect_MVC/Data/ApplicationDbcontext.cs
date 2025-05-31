using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using New_ProJect_MVC.Models;
using New_ProJect_MVC.Models.Entities;
namespace New_ProJect_MVC.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Person> Person { get; set; }
        public DbSet<HeThongPhanPhoi> HeThongPhanPhoi { get; set; }
        public DbSet<DaiLy> Daily { get; set; }
        public DbSet<Employee> Employee { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
{
    base.OnModelCreating(builder);
    builder.Entity<ApplicationUser>().ToTable("Users");
    builder.Entity<IdentityRole>().ToTable("Roles");
    builder.Entity<IdentityUserRole<string>>().ToTable("UserRoles");
    builder.Entity<IdentityUserClaim<string>>().ToTable("UserClaims");
    builder.Entity<IdentityUserLogin<string>>().ToTable("UserLogins");
    builder.Entity<IdentityRoleClaim<string>>().ToTable("RoleClaims");
    builder.Entity<IdentityUserToken<string>>().ToTable("UserTokens");
}
    }
   

}
