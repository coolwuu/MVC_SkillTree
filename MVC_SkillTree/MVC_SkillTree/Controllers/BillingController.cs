using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using MVC_SkillTree.Models;
using MVC_SkillTree.ViewModels;

namespace MVC_SkillTree.Controllers
{
    public class BillingController : Controller
    {
        private readonly BillingService _billingService;
        public BillingController()
        {
            _billingService = new BillingService();
        }

        [ChildActionOnly]
        public ActionResult ListBillingRecords()
        {
            var records = _billingService.GetTop100BillingRecords();   
            return View(records);
        }
    }
}