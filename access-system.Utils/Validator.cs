using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace access_system.Utils
{
    public static class Validator
    {
        public static bool CheckWhetherDigitIsEnteredInField(string textFromField)
        {
            int number;
            return int.TryParse(textFromField,out number);
        }
    }
}
