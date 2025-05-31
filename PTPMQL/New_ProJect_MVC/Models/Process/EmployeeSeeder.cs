using New_ProJect_MVC.Data;
using New_ProJect_MVC.Models.Entities;

namespace New_ProJect_MVC.Models.Process{
    public class EmployeeSeeder{
        private readonly ApplicationDbContext _context;
        public EmployeeSeeder(ApplicationDbContext context){
            _context = context;
        }
        public void SeedEmployees (int n)
        {
            var employees = GenerateEmployees (n);
            _context.Employee.AddRange (employees);
            _context.SaveChanges()
            
            
        }
        private List<Employee>  GenerateEmployees (int n){
            var Faker =  new Faker<Employee>  ()
                Rulefor(e =>  e.FirstName,
            
        }
    }
}