using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace portfolio.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        private portfolio.Models.CommentContext _db = new portfolio.Models.CommentContext();

        private List<portfolio.Models.Comment> dbList = new List<Models.Comment>();

        [HttpPost]
        public ActionResult comment(portfolio.Models.Comment entry)
        {
            dbList.Add(entry);
        //    _db.Entries.Add(entry);
        //    _db.Entries
        //    _db.SaveChanges();
            System.Diagnostics.Debug.WriteLine(entry);
            return Json(new { success = true, responseText = "Your message successfuly sent!" }, JsonRequestBehavior.AllowGet);

        }

        [HttpGet]
        public ActionResult comments()
        {
            
            return List;
        }

    }
}