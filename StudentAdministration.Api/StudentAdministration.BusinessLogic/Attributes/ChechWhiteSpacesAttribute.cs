using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace StudentAdministration.BusinessLogic.Attributes
{
    public class ChechWhiteSpacesAttribute : ValidationAttribute
    {
        protected override ValidationResult? IsValid(
           object? value, ValidationContext validationContext)
        {
            var inValid = new Regex("[\\s]");
            if (value is string input)
            {
                if (inValid.IsMatch(input))
                {
                    return new ValidationResult(GetErrorMessage());
                }
            }
            return ValidationResult.Success;
        }
        private string GetErrorMessage()
        {
            return $"Input can't have white space";

        }
    }
}
