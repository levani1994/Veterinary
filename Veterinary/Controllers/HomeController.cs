using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Veterinary.Controllers
{
    public class HomeController : BaseController
    {
        
        public ActionResult Index()
        {
            ViewBag.name = Session["user"];
            return View();
        }

        //public ActionResult Care()
        //{
        //    return View();
        //}
        
        public ActionResult Food()
        {
            return View();
        }
  
    }
}