using MissionSite.DAL;
using MissionSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MissionSite.Controllers
{
    [Authorize]
    public class MissionController : Controller
    {
        private MissionFAQsContext db = new MissionFAQsContext();
        // GET: Mission
        public ActionResult Index(string mission)
        {
            IEnumerable<Missions> MissionInfo;
            switch (mission)
            {
                case "Colombia Bogota North":
                    MissionInfo = db.Database.SqlQuery<Missions>("Select * From Missions Where MissionName = 'Colombia Bogota North'");
                    break;
                case "Brasil Belem":
                    MissionInfo = db.Database.SqlQuery<Missions>("Select * From Missions Where MissionName = 'Brasil Belem'");
                    break;
                default: // "Brasil Curitiba":
                    MissionInfo = db.Database.SqlQuery<Missions>("Select * From Missions Where MissionName = 'Brasil Curitiba'");
                    break;
            }

            return View(MissionInfo);
        }

    }
}