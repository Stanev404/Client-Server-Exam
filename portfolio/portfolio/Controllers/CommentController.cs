using portfolio.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services;

namespace portfolio.Controllers
{
    public class CommentController : Controller
    {
        // GET: Comment
        private portfolio.Models.CommentContext _db = new portfolio.Models.CommentContext();
        public ActionResult Index()
        {
            return View();
        }

       
        [HttpPost]
        public ActionResult Create(portfolio.Models.Comment entry)
        {
            _db.Entries.Add(entry);
            _db.SaveChanges();
            return RedirectToAction("Home");
        }
    }
}