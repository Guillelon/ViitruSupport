using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViitruMobileSupport.Models;
using ViitruMobileSupport.Service;

namespace ViitruMobileSupport.Controllers
{
    public class ActivityController : Controller
    {
        //
        // GET: /Activity/

        public ActionResult Index()
        {
            var planId = 5;
            var api = new Api();
            var activities = api.GetActivitiesByPlanId(planId);
            return View(activities);
        }

        public ActionResult Details(int id)
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
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
