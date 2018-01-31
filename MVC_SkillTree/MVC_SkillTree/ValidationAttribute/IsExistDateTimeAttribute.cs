using System;
using System.Globalization;

namespace MVC_SkillTree.ValidationAttribute
{
    public class IsExistDateTimeAttribute : System.ComponentModel.DataAnnotations.ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            DateTime dateTime;
            var isValid = DateTime.TryParseExact(Convert.ToString(value),
                "yyyy-MM-dd",
                CultureInfo.CurrentCulture,
                DateTimeStyles.None,
                out dateTime);

            return (isValid && dateTime > DateTime.Today);
        }
    }
}