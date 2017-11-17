using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using K21t2_Team3.Models;
using K21t2_Team3.ViewModels;

namespace K21t2_Team3.Controllers
{
    public class PostController : Controller
    {
        // GET: Post
        DemoPPCRentalEntities entities = new DemoPPCRentalEntities();
        public ActionResult Post()
        {
            var vm = new ViewModel();
            vm.zDistricts = entities.DISTRICTs.ToList();
            vm.zStreets = entities.STREETs.ToList();
            vm.zWards = entities.WARDs.ToList();
            return View(vm);
        }
        public string ProcessUpload(HttpPostedFileBase file)
        {

            file.SaveAs(Server.MapPath("/Images/" + file.FileName));
            return " " +file.FileName;
        }
    }

}