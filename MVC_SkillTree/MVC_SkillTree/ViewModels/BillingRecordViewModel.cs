using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_SkillTree.ViewModels
{
    public class BillingRecordViewModel
    {
        public int Amount { get; set; }

        public DateTime Date { get; set; }

        public BillingType Type { get; set; }
    }

    public enum BillingType
    {
        收入,
        支出
    }
}