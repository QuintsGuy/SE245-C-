using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Form_Demo
{
    public class Validation
    {
        public static bool GotPoop(string temp)
        {
            bool result = false;
            if (temp.ToLower().Contains("poop"))
            {
                result = true;
            }

            return result;
        }

        public static bool IsItFilledIn(string temp, int minlen)
        {
            bool result = false;
            if (temp.Length >= minlen)
            {
                result = true;
            }

            return result;
        }
        
        //public static bool IsAFutureDate(DateTime temp)
        // { bool blnResult; }
    }
}