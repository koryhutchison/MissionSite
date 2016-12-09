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
<<<<<<< HEAD
using System.Web.Security;
=======
using MissionSite.Models;
using MissionSite.DAL;
>>>>>>> 092617aaa439788dcb618d880d43b488418c341a

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

        //verify their login, and send them to the screen if they are in our database. if not, show an error message
        [HttpPost]
<<<<<<< HEAD
        public ActionResult Login(FormCollection form, bool rememberMe = false)
=======
        public ActionResult Login(FormCollection form)
>>>>>>> 092617aaa439788dcb618d880d43b488418c341a
        {
            IEnumerable<Users> find_user = db.Database.SqlQuery<Users>("select * from Users where UserEmail = '" + form["Email"].ToString() + "';");

            try
            {
                Users current_user = db.User.Find(find_user.First().UserID);
<<<<<<< HEAD

=======
                
>>>>>>> 092617aaa439788dcb618d880d43b488418c341a
                if (current_user != null)
                {
                    if (current_user.UserPassword == form["Password"].ToString())
                    {
<<<<<<< HEAD
                        FormsAuthentication.SetAuthCookie(current_user.UserEmail, rememberMe);
=======

>>>>>>> 092617aaa439788dcb618d880d43b488418c341a
                        return RedirectToAction("Index", "Home");
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