using FitApp.DataAccessLayer;
using FitApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FitApp.Controllers
{
    public class ActivityController : Controller
    {
        // GET: Activity
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Activity activity)
        {
            if (!ModelState.IsValid)
            {
                return View("Create", activity);
            }
            else
            {
                GymContext db = new GymContext();
                db.Activities.Add(activity);
                db.SaveChanges();

                return View("Index");
            }
        }
    }
}