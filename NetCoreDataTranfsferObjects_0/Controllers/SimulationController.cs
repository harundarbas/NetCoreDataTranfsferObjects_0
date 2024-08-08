using Microsoft.AspNetCore.Mvc;
using NetCoreDataTranfsferObjects_0.Models;
using System.Security.Cryptography.X509Certificates;

namespace NetCoreDataTranfsferObjects_0.Controllers
{
    public class SimulationController : Controller
    {
        public IActionResult Index()
        {
            Egitmen egt = new Egitmen
            {
                Isim = "Harun",
                Soyisim = "Darbas"
            };    
            ViewData["mesaj"] = "Mesajınız oluşturulmuştur";
            ViewData["egitmen"] = egt;
            return View();
        }

        public IActionResult Contact()
        {

            ViewBag.Mesaj = "Mesajınız oluşturulmuştur";
            Egitmen egt = new Egitmen
            {
                Isim = "Harun",
                Soyisim = "Darbas"
            };
            ViewBag.Egitmen = egt;
            return View();
        }

        public IActionResult About()
        {
            TempData["mesaj"] = "Mesajınız oluşturuldu";
            TempData.Keep("mesaj");
            return View();
        }

        public IActionResult TestAction() 
        {
            string a = TempData["mesaj"].ToString();
            return View(); 
        }
    }
}
