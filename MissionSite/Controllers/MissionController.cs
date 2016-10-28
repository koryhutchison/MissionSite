using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MissionSite.Controllers
{
    public class MissionController : Controller
    {
        // GET: Mission
        public ActionResult Index(string mission)
        {
            switch (mission)
            {
                case "Colombia Bogota North":
                    ViewBag.MissionName = "Colombia Bogota North";
                    ViewBag.MissionPresidentName = "President Mark F. Andelin";
                    ViewBag.MissionAddress = "Colombia Bogota North Mission <br> Calle 72 #10-07, Oficina 1001 <br> Edificio Liberty Seguros <br> Bogota, Cundinamarca <br> Colombia";
                    ViewBag.Language = "Spanish";
                    ViewBag.Climate = "Subtropical Highland";
                    ViewBag.DominateReligion = "Catholic / Evangelical";
                    ViewBag.Symbol = "colombia_bogota_north.png";
                    break;
                case "Brasil Belem":
                    ViewBag.MissionName = "Brasil Belem";
                    ViewBag.MissionPresidentName = "President José C. Scisci";
                    ViewBag.MissionAddress = "Brazil Belem Mission <br> Av. Narzare, 532 Sala 412 4˚ Andar <br> Nazaré Royal Trade Center <br> 66035-135 Belém-PA";
                    ViewBag.Language = "Portuguese";
                    ViewBag.Climate = "Tropical";
                    ViewBag.DominateReligion = "Catholic";
                    ViewBag.Symbol = "brasil_belem.png";
                    break;
                default: // "Brasil Curitiba":
                    ViewBag.MissionName = "Brasil Curitiba";
                    ViewBag.MissionPresidentName = "President Douglas K. Hart";
                    ViewBag.MissionAddress = "Escritório da Missão Brasil Curitiba <br> Av. Iguaçu 1460 <br> Bairro Água Verde<br>CEP: 80250-190 <br> Curitiba –PR";
                    ViewBag.Language = "Portuguese";
                    ViewBag.Climate = "Subtropical Highland";
                    ViewBag.DominateReligion = "Catholic / Evangelical";
                    ViewBag.Symbol = "brasil_curitiba.png";
                    break;
            }

            return View();
        }

    
        public ActionResult Contact()
        {
            return View();
        }
        

    }
}