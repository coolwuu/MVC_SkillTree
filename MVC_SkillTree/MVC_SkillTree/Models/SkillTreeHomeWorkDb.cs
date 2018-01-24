using System.Data.Entity;

namespace MVC_SkillTree.Models
{
    public class SkillTreeHomeWorkDb : DbContext
    {
        public SkillTreeHomeWorkDb()
            : base("name=SkillTreeHomeWorkDb")
        {
        }

        public virtual DbSet<AccountBook> AccountBooks { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
