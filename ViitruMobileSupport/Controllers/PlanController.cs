using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using RestSharp;
using ViitruMobileSupport.Service;

namespace ViitruMobileSupport.Controllers
{
    public class PlanController : Controller
    {
        //
        // GET: /Plan/

        public ActionResult Index()
        {
            var api = new Api();
            var plans = api.GetPlans();
            return View(plans);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Plan plan)
        {
            var api = new Api();
            api.AddPlan(plan);
            return RedirectToAction("Index", "Home");
        }
    }
}
