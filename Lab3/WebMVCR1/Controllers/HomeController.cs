using Microsoft.AspNetCore.Mvc;
using WebMVCR1.Moddels;
using WebMVCR1.Models;


namespace WebMVCR1.Controllers
{
    public class HomeController : Controller
    {
        private static PersonRepository db = new();
        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "Доброе утро" : "Добрый день";
            ViewData["Mes"] = "хорошего настроения";
            return View();

        }

        [HttpGet]
        public ViewResult InputData()
        {
            return View();
        }
        [HttpPost]
        public ViewResult InputData(Person p)
        {
            db.AddResponse(p);
            return View("Hello", p);

        }
        public ViewResult OutputData()
        {
            ViewBag.Pers = db.GetAllResponses;
            ViewBag.Count = db.NumberOfPerson;
            return View("ListPerson");
        }
        //public string Index(string hel)
        //{
        //    string Greeting = ModelClass.ModelHello() + ", " + hel;
        //    return Greeting;
        //}
    }

}
