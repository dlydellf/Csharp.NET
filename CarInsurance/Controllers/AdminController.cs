using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CarInsurance.Models;
using CarInsurance.ViewModels;

namespace CarInsurance.Controllers
{
    public class AdminController : Controller
    {
        private InsuranceEntities db = new InsuranceEntities();  // instantiates the InsuranceEntities object, granting access to the db...

        // GET: Admin
        public ActionResult Index()
        {
            var insurees = db.Insurees.ToList();  // ALL of the db's records
            var insuredVms = new List<ViewModels.InsuredVm>();  // creates a new <List> of ViewModels
            foreach (var insuree in insurees)
            {
                var insuredVm = new InsuredVm();
                // mapping the db object's properties to the View model:
                insuredVm.Id = insuree.Id;
                insuredVm.FirstName = insuree.FirstName;
                insuredVm.LastName = insuree.LastName;
                insuredVm.EmailAddress = insuree.EmailAddress;
                insuredVms.Add(insuredVm);
            }
            return View(insuredVms);
        }
    }
}
