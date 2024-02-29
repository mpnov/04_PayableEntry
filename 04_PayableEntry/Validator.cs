using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_PayableEntry
{
    internal static class Validator
    {
        public static string IsInt(string value, string name)
        {
            string msg = string.Empty;

            if(!int.TryParse(value, out _))
            {
                msg += $"{name} value must be an integer\n";
            }

            return msg;
        }

        public static string IsPresent(string value, string name)
        {
            string msg = string.Empty;

            if(value.Trim() == string.Empty)
            {
                msg = $"{name} value is required\n";
            }

            return msg;
        }

        public static string IsDecimal(string value, string name)
        {
            string msg = string.Empty;

            if(!decimal.TryParse(value, out _))
            {
                msg = $"{name} value must be a decimal";
            }

            return msg;
        }

        public static string IsInRange(string value, string name, decimal min, decimal max)
        {
            string msg = string.Empty;

            if(decimal.TryParse(value, out decimal val))
            {
                if(val < min || val > max)
                {
                    msg = $"{name} value must be between {min} and {max}";
                }
            }

            return msg;
        }
    }
}
