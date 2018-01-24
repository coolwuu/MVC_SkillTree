using System.Data.Entity;

namespace MVC_SkillTree.Repositories
{
    public interface IUnitOfWork
    {
        DbContext Context { get; set; }
        void Save();
    }
}