using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVC_SkillTree.Repositories;
using MVC_SkillTree.ViewModels;

namespace MVC_SkillTree.Models
{
    public class BillingService
    {
        private readonly SkillTreeHomeWorkDb _dbcontext;
        private readonly IRepository<AccountBook> _accountBookRep;
        private readonly IUnitOfWork _unitOfWork;

        public BillingService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _accountBookRep = new Repository<AccountBook>(_unitOfWork);
        }

        public IEnumerable<BillingRecordViewModel> GetBillingRecords(int row)
        {
            var source = _accountBookRep.LookupAll();
            var result = source.Take(row).Select(x => new BillingRecordViewModel
            {
                Amount = x.Amounttt,
                Date = x.Dateee,
                Type = x.Categoryyy == 1 ? BillingType.支出 : BillingType.收入
            }).ToList();
            return result;
        }

        public void Save()
        {
            _unitOfWork.Save();
        }
    }
}