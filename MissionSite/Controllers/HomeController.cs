using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MissionSite.Controllers
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
            List<SelectListItem> subject_options = new List<SelectListItem>();
            subject_options.Add(new SelectListItem { Text = "Choose One", Selected = true });
            subject_options.Add(new SelectListItem { Text = "Mission Question", Value = "0" });
            subject_options.Add(new SelectListItem { Text = "Website Problem", Value = "1" });
            subject_options.Add(new SelectListItem { Text = "Other", Value = "2"});
            ViewBag.SubjectOptions = subject_options;

            return View();
        }

        public ActionResult Login()
        {
            return View();
        }
    }
}