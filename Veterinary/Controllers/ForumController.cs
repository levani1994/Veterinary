using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Veterinary.Models;

namespace Veterinary.Controllers
{
    public class ForumController : BaseController
    {
        
       
        public ActionResult Index()
        {
            return View(db.Categories);
        }


        public ActionResult Topic(string id)
        {
            ViewBag.topic = id;
            return View();
        }

        public ActionResult Category(string id)
        {
            ViewBag.name = id;
            var x = db.Topics.Where(z => z.Category == id).ToList();
            return View(x);

        }


        [HttpPost]
        public JsonResult Category(TopicViewModel topicViewModel)
        {
            var DbTopic = new Topic()
            {
                TopicName = topicViewModel.TopicViewName,
                Category = topicViewModel.TopicViewCategory

            };
            db.Topics.InsertOnSubmit(DbTopic);
            db.SubmitChanges();
            return Json(DbTopic);
        }
    }
}