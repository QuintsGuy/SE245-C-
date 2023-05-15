using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonV2_Lab
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
            double intResult;
            bool blnResult = double.TryParse(temp, out intResult);
            return blnResult;
        }

        public static bool ValidInstagramURL(string temp)
        {
            return temp.ToLower().StartsWith("https://www.instagram.com");
        }
    }
}