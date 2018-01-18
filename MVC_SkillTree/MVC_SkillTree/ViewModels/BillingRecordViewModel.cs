using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_SkillTree.ViewModels
{
    public class BillingRecordViewModel
    {
        [DisplayFormat(DataFormatString = "{0:N0}")]
        public int Amount { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime Date { get; set; }

        public BillingType Type { get; set; }
    }

    public enum BillingType
    {
        收入,
        支出
    }
}