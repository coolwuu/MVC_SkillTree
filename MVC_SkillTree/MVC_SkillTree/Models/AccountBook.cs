using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MVC_SkillTree.ValidationAttribute;
using MVC_SkillTree.ViewModels;

namespace MVC_SkillTree.Models
{
    [Table("AccountBook")]
    public class AccountBook
    {
        public Guid Id { get; set; }

        [Required, Display(Name = "類別")]
        public BillingType Category { get; set; }

        [Required, Display(Name = "金額")]
        public decimal Amount { get; set; }

        [Required, Display(Name = "日期")]
        [IsExistDateTime(ErrorMessage = "輸入日期不能大於今天")]
        public DateTime Date { get; set; }

        [Required,Display(Name = "備注")]
        [StringLength(100)]
        public string Remark { get; set; }
    }
}
