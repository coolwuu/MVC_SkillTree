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
        private readonly SkillTreeHomeWorkDb _dbcontext;
        public BillingController()
        {
            _dbcontext = new SkillTreeHomeWorkDb();
        }

        [ChildActionOnly]
        public ActionResult ListBillingRecords()
        {
            var records = _dbcontext.AccountBooks.Take(100).Select(x => new BillingRecordViewModel
            {
                Amount = x.Amounttt,
                Date = x.Dateee,
                Type = x.Categoryyy == 1 ? BillingType.支出 : BillingType.收入
            }).ToList();
            return View(records);
        }
    }
}