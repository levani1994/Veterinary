using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Veterinary.Controllers
{
    public class CareController : BaseController
    {
        // GET: Care
        public ActionResult Index()
        {
            return View();
        }
    }
}