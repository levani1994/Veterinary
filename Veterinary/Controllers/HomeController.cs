using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Veterinary.Helpers;

namespace Veterinary.Controllers
{
    public class HomeController : BaseController
    {
        [HttpPost]
        public JsonResult Search(string searchTerm)
        {
            string engSearchTerm = LanguageConverter.ConvertToEnglish(searchTerm).ToLower();
            return Json(db.Foods.Where(x => x.Name.Contains(searchTerm) || x.Name.ToLower().Contains(engSearchTerm)));
        }

        public ActionResult Index()
        {
            ViewBag.name = Session["user"];
            return View();
        }
        
        public ActionResult Food()

        {
            ViewBag.name = Session["user"];
            return View();
        }

        public ActionResult Interesting()
        {
            ViewBag.name = Session["user"];
            return View();
        }  
    }
}