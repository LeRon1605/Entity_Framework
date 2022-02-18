using System.ComponentModel.DataAnnotations;
namespace EF_Practice
{
    class Validate
    {
        public static bool validate(object obj)
        {
            ValidationContext valiadateContext = new ValidationContext(obj, null, null);
            List<ValidationResult> results = new List<ValidationResult>();
            bool valid = Validator.TryValidateObject(obj, valiadateContext, results, true);
            return valid;
        }
    }
}