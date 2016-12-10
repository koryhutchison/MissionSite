
/*
 * This is Project 2
 * A Mission Site to have some information and questions
 * 
 * created by group 12 of section 2
 * 
 * Brett Adamson
 * Kory Hutchison
 * Nathan Marrs
 * Alex Pratt
 *
 * 
 * */


using MissionSite.DAL;
using MissionSite.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MissionSite.Controllers
{
    public class HomeController : Controller
    {
        private MissionFAQsContext db = new MissionFAQsContext();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        //This is the Contact method that has the list of options for the dropdown list.
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

        //verify their login, and send them to the screen if they are in our database. if not, show an error message
        [HttpPost]
        public ActionResult Login(FormCollection form, bool rememberMe = false)
        {
            IEnumerable<Users> find_user = db.Database.SqlQuery<Users>("select * from Users where UserEmail = '" + form["Email"].ToString() + "';");

            try
            {
                Users current_user = db.User.Find(find_user.First().UserID);

                if (current_user != null)
                {
                    if (current_user.UserPassword.Equals(form["Password"].ToString()))
                    {
                        FormsAuthentication.SetAuthCookie(current_user.UserEmail, rememberMe);
                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        ViewBag.ErrorMessage = "Invalid Email / Password.";
                    }
                }
            }
            catch
            {
                ViewBag.ErrorMessage = "Invalid Email / Password.";
            }

            return View();
        }
    }
}