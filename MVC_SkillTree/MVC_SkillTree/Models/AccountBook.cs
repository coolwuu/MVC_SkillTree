using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MVC_SkillTree.ValidationAttribute;

namespace MVC_SkillTree.Models
{
    [Table("AccountBook")]
    public class AccountBook
    {
        public Guid Id { get; set; }

        [Required]
        public int Category { get; set; }
        
        [Required]
        public decimal Amount { get; set; }

        [Required]
        [IsExistDateTime(ErrorMessage = "輸入日期不能大於今天")]
        public DateTime Date { get; set; }

        [Required]
        [StringLength(100)]
        public string Remark { get; set; }
    }
}
