using Microsoft.AspNetCore.Mvc;

namespace New_ProJect_MVC.Controllers.giaithua
{
    public class GiaithuaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(int soA)
        {
            int ketqua=1;   
            for (int i=2;i <=soA; i++)
            {
                ketqua*=i;
            }
            ViewBag.message=ketqua.ToString();
            return View(); 
        }
    }
}