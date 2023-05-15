using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer_Lab
{
    public class Validations
    {
        public static bool GotProfanity(string temp)
        {
            bool result = temp.ToLower().Contains("fuck");
            return result;
        }
        public static bool IsItFilledIn(string temp, int minlen)
        {
            bool result = temp.Length >= minlen;
            return result;
        }
        public static bool TooManyLetters(string temp, int maxlen)
        {
            bool result = temp.Length <= maxlen;
            return result;
        }
        public static bool ExactLength(string temp, int value)
        {
            bool result = temp.Length == value;
            return result;
        }
        public static bool IsADouble(string temp)
        {
            double dblResult;
            bool blnResult = double.TryParse(temp, out dblResult);
            return blnResult;
        }

        public static bool ValidInstagramURL(string temp)
        {
            return temp.ToLower().StartsWith("https://www.instagram.com");
        }

        public static bool IsNotAFutureDate(DateTime temp)
        {
            bool blnResult = temp < DateTime.Now;

            return blnResult;
        }

        public static bool IsAnInteger(string temp)
        {
            Int16 intResult;
            bool blnResult = Int16.TryParse(temp, out intResult);
            return blnResult;
        }
    }
}