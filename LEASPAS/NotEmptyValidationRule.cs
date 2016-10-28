using System.Collections.ObjectModel;
using System.Globalization;
using System.Windows.Controls;

namespace LEASPAS
{
    public class NotEmptyValidationRule : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            return string.IsNullOrWhiteSpace((value ?? "").ToString())
                ? new ValidationResult(false, "Champ requis")
                : ValidationResult.ValidResult;
        }
    }
}