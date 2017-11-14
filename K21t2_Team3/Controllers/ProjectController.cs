using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using K21t2_Team3.Models;

namespace K21t2_Team3.Controllers
{
    public class ProjectController : Controller
    {
        DemoPPCRentalEntities entities = new DemoPPCRentalEntities();
        // GET: Project
        public ActionResult Detail(int id)
        {
            var ProjDetail = entities.PROPERTies.FirstOrDefault(x => x.ID == id);
            return View(ProjDetail);
        }
    }
}