using Microsoft.AspNetCore.Mvc;
using New_ProJect_MVC.Models;

namespace New_ProJect_MVC.Controllers
{
    public class PersonController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Person ps)
        {
            string strOutput = "Xin chao" + ps.PersonId + "la cua " + ps.FullName + "dia chi la " + ps.Address;
            ViewBag.infoPerson = strOutput;
            return View();
        }
    }
}