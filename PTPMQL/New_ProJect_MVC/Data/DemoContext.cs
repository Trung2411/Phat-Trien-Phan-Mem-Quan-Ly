using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using New_ProJect_MVC.Models;

namespace Demo.Data
{
    public class DemoContext : DbContext
    {
        public DemoContext (DbContextOptions<DemoContext> options)
            : base(options)
        {
        }

        public DbSet<New_ProJect_MVC.Models.Person> Person { get; set; } = default!;
        public DbSet<New_ProJect_MVC.Models.Employee> Employee { get; set; } = default!;
    }
}
