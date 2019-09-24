using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Veterinary.Controllers
{
    public class HomeController : BaseController
    {

        public JsonResult Search(string searchTerm)
        {
            return Json(db.Foods.Where(x => x.Name.Contains(searchTerm)),JsonRequestBehavior.AllowGet);
        }


        public ActionResult Index()
        {
            ViewBag.name = Session["user"];
            return View();
        }
        
        
        public ActionResult Food()
        {
            return View();
        }
  
    }
}