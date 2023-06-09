using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Form_Demo
{
    public class Validation
    {
        public static bool GotBadWords(string temp)
        {
            bool blnResult = false;

            string[] strBadWords = { "fuck", "shit", "crap", "bitch" };

            foreach (string strBW in strBadWords)
                if (temp.ToLower().Contains(strBW))
                {
                    blnResult = true;
                }

            return blnResult;
        }

        public static bool IsItFilledIn(string temp, int minlen)
        {
            bool blnResult = temp.Length >= minlen;

            return blnResult;
        }

        public static bool IsAFutureDate(DateTime temp)
        {
            bool blnResult = temp > DateTime.Now;

            return blnResult;
        }

        public static bool IsValidEmail(string temp)
        {
            bool blnResult = true;

            int atLocation = temp.IndexOf("@");
            int nextAtLocation = temp.IndexOf("@", atLocation + 1);

            int periodLocation = temp.LastIndexOf(".");

            if (temp.Length < 8)
            {
                blnResult = false;
            }
            else if (atLocation < 2)
            {
                blnResult = false;
            }
            else if (periodLocation + 2 > (temp.Length))
            {
                blnResult = false;
            }
            else if (nextAtLocation > atLocation)
            {
                blnResult = false;
            }
            
            return blnResult;
        }

        public static bool IsMinimumAmount(double temp, double min)
        {
            bool blnResult = temp < min;

            return blnResult;
        }

        public static bool IsADouble(string temp)
        {
            double intResult;
            bool blnResult = double.TryParse(temp, out intResult);
            return blnResult;
        }

        public static bool IsAnInteger(string temp)
        {
            Int32 intResult;
            bool blnResult = Int32.TryParse(temp, out intResult);
            return blnResult;
        }

    }
}