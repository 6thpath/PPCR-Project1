using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using K21t2_Team3.Models;
using K21t2_Team3.ViewModels;

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
        public ActionResult ViewListOfAgencyProject()
        {
            var vm = new ViewModel();
            vm.zDistricts = entities.DISTRICTs.ToList();
            vm.zProperties = entities.PROPERTies.ToList();
            vm.zStreets = entities.STREETs.ToList();
            vm.zWards = entities.WARDs.ToList();
            return View(vm);
        }
    }
}