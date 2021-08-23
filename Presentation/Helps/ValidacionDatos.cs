using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Presentation.Helps
{
    class ValidacionDatos
    {
        public ValidationContext context;
        private List<ValidationResult> results;
        private bool valid;
        private string mensaje;
        private IDictionary<object, object> v ;
        IServiceProvider d = null;
        public ValidacionDatos(object instance)
        {
            context = new ValidationContext(instance, d, v);
            results = new List<ValidationResult>();
            valid = Validator.TryValidateObject(instance, context, results, true);
        }
        public bool Validar()
        {
            if (valid == false)
            {
                foreach (ValidationResult item in results)
                {
                    mensaje += item.ErrorMessage + "\n";
                }
                System.Windows.Forms.MessageBox.Show(mensaje);
            }
            return valid;
        }
    }
}
