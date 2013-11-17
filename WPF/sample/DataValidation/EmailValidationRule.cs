using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Controls;

namespace DataValidation
{
    public class EmailValidationRule : ValidationRule
    {
        private readonly string smtp = "@gmail.com";

        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            var str = value as string;
            if (String.IsNullOrEmpty(str))
                return new ValidationResult(false, "Please enter a valide email Address.");

            //Match match = Regex.Match(str, @"^([\w.]+)@gmail.com$", RegexOptions.IgnoreCase);
            Match match = Regex.Match(str, @"^([\w.]+)"+ smtp +"$", RegexOptions.IgnoreCase);
            if (!match.Success)
                return new ValidationResult(false, "the adress must be a gmail adress ("+smtp+")");

            return new ValidationResult(true, null);
        }
    }
}
