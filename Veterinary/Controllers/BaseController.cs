using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Veterinary.Models;

namespace Veterinary.Controllers
{
    public class BaseController : Controller
    {
        public static DataBaseDataContext db;
        public BaseController()
        {
            if (db == null)
            {
                db = new DataBaseDataContext();
            }
        }

    }
}