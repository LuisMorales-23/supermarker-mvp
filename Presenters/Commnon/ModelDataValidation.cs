using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;
namespace Supermarket_mvp.Presenters.Commnon
{
    internal class ModelDataValidation
    {
        public void Validate (object model)
        {
            string errorMassage = "";
            List<ValidationResult> validationResults = new List<ValidationResult>();
            ValidationContext validationContext = new ValidationContext(model);
            bool isValid = Validator.TryValidateObject (
                model,validationContext, validationResults, true );

            if (isValid == false)
            {
                foreach (var item in validationResults)
                {
                    errorMassage += item.ErrorMessage + "\n"; 
                }
                throw new Exception(errorMassage);
            }   
        }
    }
}
