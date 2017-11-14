using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using K21t2_Team3.Models;
using K21t2_Team3.ViewModels;

namespace K21t2_Team3.Controllers
{
    public class HomeController : Controller
    {
        DemoPPCRentalEntities entities = new DemoPPCRentalEntities();
        public ActionResult Index()
        {
            //var properties = entities.PROPERTies.ToList();
            //return View(properties);
            var vm = new ViewModel();
            vm.zDistricts = entities.DISTRICTs.ToList();
            vm.zProperties = entities.PROPERTies.ToList();
            vm.zStreets = entities.STREETs.ToList();
            vm.zWards = entities.WARDs.ToList();
            return View(vm);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpGet]
        public ActionResult Search(string text)
        {
            var props = entities.PROPERTies.ToList().Where(x => x.PropertyName.Contains(text) || x.Content.Contains(text));
            return View(props);
        }
    }
}