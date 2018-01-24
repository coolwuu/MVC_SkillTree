using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVC_SkillTree.ViewModels;

namespace MVC_SkillTree.Models
{
    public class BillingService
    {
        private readonly SkillTreeHomeWorkDb _dbcontext;

        public BillingService()
        {
            _dbcontext = new SkillTreeHomeWorkDb();
        }

        public IEnumerable<BillingRecordViewModel> GetTop100BillingRecords()
        {
            var result = _dbcontext.AccountBooks.Take(100).Select(x => new BillingRecordViewModel
            {
                Amount = x.Amounttt,
                Date = x.Dateee,
                Type = x.Categoryyy == 1 ? BillingType.支出 : BillingType.收入
            }).ToList();
            return result;
        }
    }
}