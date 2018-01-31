using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_SkillTree.Models;
using MVC_SkillTree.ViewModels;

namespace MVC_SkillTree.Helper
{
    public static class FontColorHelper
    {
        public static MvcHtmlString AddColorByCategory(this HtmlHelper htmlHelper, BillingRecordViewModel record)
        {
            return record.Type == BillingType.支出 ? new MvcHtmlString($"<span style=\"color:red;\">{record.Type}</span>")
                : new MvcHtmlString($"<span style=\"color:blue;\">{record.Type}</span>");
        }
    }
}