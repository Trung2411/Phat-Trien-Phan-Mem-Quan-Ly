using Microsoft.AspNetCore.Mvc;
using New_ProJect_MVC.Models.Entities;
namespace  New_ProJect_MVC.Controllers.Service
{
    public class BMIController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(BMI bmi)
        {
            var ketqua = bmi.Cannang/(bmi.ChieuCao*2);
            if (ketqua < 18.5)
            {
                ViewBag.Message = $"Sức khỏe của bạn {bmi.FullName} là yếu";
            }
            else if (ketqua < 25 && ketqua >=18.5 )
            {
                ViewBag.Message = $"Sức khỏe của bạn {bmi.FullName} là trung bình";
            }
            else if (ketqua >= 25 && bmi.Cannang < 40)
            {
                ViewBag.Message = $"Sức khỏe của bạn {bmi.FullName} là tốt";
            }
            else
            {
                ViewBag.Message = $"Sức khỏe của bạn {bmi.FullName} là béo phi";
            }
            return View();
        }
    }
}