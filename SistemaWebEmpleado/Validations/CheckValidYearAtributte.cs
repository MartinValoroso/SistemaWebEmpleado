using System.ComponentModel.DataAnnotations;

namespace SistemaWebEmpleado.Validations
{
    public class CheckValidYearAttribute : ValidationAttribute
    {

        public CheckValidYearAttribute()
        {
            ErrorMessage = "La fecha de nacimiento debe ser mayor o igual a 2000";
        }

        public override bool IsValid(object value)
        {
            int year = (int)value;

            return (year < 1999) ? false : true;
        }
    }
}

