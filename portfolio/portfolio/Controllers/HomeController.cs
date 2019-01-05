using portfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

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

       

        [HttpPost]
        public ActionResult comment(portfolio.Models.Comment entry)
        {
            
            _db.Entries.Add(entry);
            _db.SaveChanges();

            System.Diagnostics.Debug.WriteLine(entry);
            return Json(new { success = true, responseText = "Your message successfuly sent!" }, JsonRequestBehavior.AllowGet);

        }

        [HttpGet]
        public ActionResult comments()
        {
            List<Comment> commentList = new List<Comment>();

            foreach(var dbItem in _db.Entries)
            {
                //System.Diagnostics.Debug.WriteLine(dbItem);
                commentList.Add(dbItem);
                //commentList.Add(new SelectListItem { Text = string(dbItem.Id), publisherName = dbItem.publisherName, contentOfComment = dbItem.contentOfComment });
            }
            //foreach(var currComment in commentList)
            //{
            //    System.Diagnostics.Debug.WriteLine(currComment);
            //}
            // var mostRecentEntries = (from entry in _db.Entries select entry).Take(1);
            //System.Diagnostics.Debug.WriteLine(mostRecentEntries);
                        var jsonSerialiser = new JavaScriptSerializer();
                        var json = jsonSerialiser.Serialize(commentList);

            return Json(commentList,JsonRequestBehavior.AllowGet);
        }

    }
}