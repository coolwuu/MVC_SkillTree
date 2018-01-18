using System;
using System.Collections.Generic;
using System.Web.Mvc;
using MVC_SkillTree.ViewModels;

namespace MVC_SkillTree.Controllers
{
    public class BillingController : Controller
    {
        public ActionResult ListBillingRecords()
        {
            var records = GenerateBillingRecords();
            return View(records);
        }

        private IEnumerable<BillingRecordViewModel> GenerateBillingRecords()
        {
            var billingRecords = new List<BillingRecordViewModel>();
            var random = new Random();
            for (int index = 0; index < 100; index++)
            {
                var type = index % 2 == 0 ? BillingType.支出 : BillingType.收入;
                var record = new BillingRecordViewModel
                {
                    Type = type,
                    Amount = random.Next(9999),
                    Date = new DateTime(2017, 1, 1).AddDays(random.Next(366)),
                };

                billingRecords.Add(record);
            }
            return billingRecords;
        }
    }
}