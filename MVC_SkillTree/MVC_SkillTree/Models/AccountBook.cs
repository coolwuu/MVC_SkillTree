using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_SkillTree.Models
{
    [Table("AccountBook")]
    public class AccountBook
    {
        public Guid Id { get; set; }

        public int Category { get; set; }

        public int Amount { get; set; }

        public DateTime Date { get; set; }

        [Required]
        [StringLength(500)]
        public string Remark { get; set; }
    }
}
