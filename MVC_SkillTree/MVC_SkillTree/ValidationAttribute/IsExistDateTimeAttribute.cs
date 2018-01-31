using System;
using System.Collections.Generic;
using System.Globalization;
using System.Web.Mvc;

namespace MVC_SkillTree.ValidationAttribute
{
    public sealed class IsExistDateTimeAttribute : System.ComponentModel.DataAnnotations.ValidationAttribute, IClientValidatable
    {
        private DateTime InputDateTime { get; set; }
        public override bool IsValid(object value)
        {
            InputDateTime = Convert.ToDateTime(value);
            DateTime d = Convert.ToDateTime(value);
            return d.Date <= DateTime.Now;
        }

        public IEnumerable<ModelClientValidationRule> GetClientValidationRules(ModelMetadata metadata, ControllerContext context)
        {
            ModelClientValidationRule rule = new ModelClientValidationRule
            {
                ValidationType = "isexistdatetime",
                ErrorMessage = FormatErrorMessage(metadata.GetDisplayName())
            };
            rule.ValidationParameters["input"] = InputDateTime;

            yield return rule;
        }
    }
}