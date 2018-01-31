using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;
using MVC_SkillTree.ValidationAttribute;
using MVC_SkillTree.ViewModels;

namespace MVC_SkillTree.Models
{
    [Table("AccountBook")]
    public class AccountBook
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "此欄位為必填欄位"), Display(Name = "類別")]
        public BillingType Category { get; set; }

        [Required(ErrorMessage = "此欄位為必填欄位"), Display(Name = "金額")]
        [Range(0,Double.MaxValue,ErrorMessage = "不得输入负值")]
        public decimal Amount { get; set; }

        [Required(ErrorMessage = "此欄位為必填欄位"), Display(Name = "日期")]
        [IsExistDateTime(ErrorMessage = "输入的日期不得大于今天")]
        public DateTime Date { get; set; }

        [Required(ErrorMessage = "此欄位為必填欄位"), Display(Name = "備注")]
        [StringLength(100,ErrorMessage = "備注最大字數為100")]
        public string Remark { get; set; }
    }
}
