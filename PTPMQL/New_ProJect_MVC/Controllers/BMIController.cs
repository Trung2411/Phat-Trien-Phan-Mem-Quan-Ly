using Microsoft.AspNetCore.Mvc;
using New_ProJect_MVC.Models;

namespace New_ProJect_MVC.Controllers;
public class BMIController : Controller
{
    public IActionResult index()
    {
        return View();
    }

    [HttpPost]  
    public IActionResult Index(string ChieuCao,string CanNang)
    {
        string strOutput = "Cao" + ChieuCao + " Nặng " + CanNang;
        ViewBag.Message = strOutput;
        return View();
    }
    private string GetBMIResult(string bmi)
    {
        if (bmi < 18.5) return "Gầy";
        if (bmi < 24.9) return "Bình Thường";
        if (bmi < 29.9) return "Béo Phì";
        return "Obesity";
    }
 } 
