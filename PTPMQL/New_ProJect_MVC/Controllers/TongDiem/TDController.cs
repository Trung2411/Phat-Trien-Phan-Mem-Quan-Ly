using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using New_ProJect_MVC.Models.TONGDIEM;

namespace New_ProJect_MVC.Controllers.TongDiem
{
    public class TDController :Controller
    {

    
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(TD tD)
        {
        var tongdiem = tD.DiemA*0.6 + tD.DiemB*0.3 + tD.DiemC*0.1;
        ViewBag.Message = $"diem cua {tD.FullName}  bang {tongdiem}";
            return View();
        }
    }
}