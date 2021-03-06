﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using MVC_SkillTree.Models;
using MVC_SkillTree.Repositories;
using MVC_SkillTree.ViewModels;

namespace MVC_SkillTree.Controllers
{
    public class BillingController : Controller
    {
        private readonly BillingService _billingService;
        public BillingController()
        {
            var unitOfWork = new EFUnitOfWork();
            _billingService = new BillingService(unitOfWork);
        }

        [ChildActionOnly]
        public ActionResult ListBillingRecords()
        {
            var records = _billingService.GetBillingRecords(100);
            return View(records);
        }

        [HttpPost]
        public ActionResult AddRecord(AccountBook record)
        {
            if (ModelState.IsValid)
            {
                record.Id = Guid.NewGuid();
                _billingService.AddNewRecord(record);
                _billingService.Save();
            }
            var records = _billingService.GetBillingRecords(10);
            return View("ListBillingRecords",records);
        }
    }
}