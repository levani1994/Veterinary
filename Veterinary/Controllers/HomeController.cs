using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Veterinary.Controllers
{
    public class HomeController : BaseController
    {
        
        //public JsonResult Search(string search)
        //{
        //    return Json(db.);
        //}


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