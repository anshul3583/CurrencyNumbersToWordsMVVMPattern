using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Controls;
using ValidationResult = System.Windows.Controls.ValidationResult;

namespace CurrencyNumbersToWordsMVVMPattern.ViewModels
{
    public class CurrencyConverterValidationRules : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            string valueToValidate = value as string;

            if (valueToValidate.Replace(" ","").Length > 12)
            {
                return new ValidationResult(false, "Maximum allowed Value - 999999999,99");
            }

            if (!Regex.Match(valueToValidate, @"(^([0-9\s\,]*)$)").Success)
            {
                return new ValidationResult(false, "Invalid Input!");
            }

            if (valueToValidate.Count(x => x == ',') > 1)
            {
                return new ValidationResult(false, "Invalid Input!");
            }

            // if last charater is a comma 
            if (valueToValidate.Length > 0 && valueToValidate.Substring(valueToValidate.Length - 1, 1) == ",")
            {
                return new ValidationResult(false, "Invalid Input!");
            }

            // comma exists and check position should either be 2nd last or last position
            if (valueToValidate.Length > 0 && valueToValidate.Contains(',') && (!Regex.Match(valueToValidate, @"(,[0-9]{0,2}$)").Success))
            {
                return new ValidationResult(false, "Invalid Input!");
            }
            if (string.IsNullOrEmpty(valueToValidate))
            {
                return new ValidationResult(false, "Please enter a value");
            }
            return new ValidationResult(true, null);
        }
        
    }
}
