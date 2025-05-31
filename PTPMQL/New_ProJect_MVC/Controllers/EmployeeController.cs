using Microsoft.EntityFrameworkCore;
using New_ProJect_MVC.Data;
using New_ProJect_MVC.Models;
using Microsoft.AspNetCore.Authorization;

namespace DemoMVC.Controllers
{
    [Authorize]
    public class EmployeeController : Controller
    {
        private readonly ApplicationDbContext _context;
    }
}