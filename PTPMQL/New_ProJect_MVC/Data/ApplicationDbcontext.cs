using Microsoft.EntityFrameworkCore;
using New_ProJect_MVC.Models;

namespace New_ProJect_MVC.Data{
    public class ApplicationDbContext : DbContext{
            public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
            {}
            public DbSet<Person> Person { get; set; }
    }
}   