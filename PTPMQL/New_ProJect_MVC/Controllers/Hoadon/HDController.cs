
using Microsoft.AspNetCore.Mvc;
using New_ProJect_MVC.Models.Hoadon;

namespace New_ProJect_MVC.Controllers.Hoadon
{
    public class HDController : Controller 
    {
        public IActionResult Index()
        {
            return View();  
        }
        [HttpPost]
        public IActionResult Index(HD hD)
        {
        
            ViewBag.message = $"Hoa don cua ban {hD.FullName} co tong la {hD.soluong*hD.dongia}";
            return View();
        }
    }
}