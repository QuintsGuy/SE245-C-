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
            bool result = false;

            string[] strBadWords = { "POOP", "HOMEWORK", "CACA" };
            
            foreach (string strBW in strBadWords)
                if (temp.Contains(strBW))
                {
                    result = true;
                }
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
        public static bool ValidEmail(string temp)
        {
            if (string.IsNullOrEmpty(temp))
                return false;

            // Check if the email contains exactly one '@' symbol
            int atIndex = temp.IndexOf('@');
            if (atIndex == -1 || atIndex != temp.LastIndexOf('@'))
                return false;

            // Check if the email contains a dot (.) after the '@' symbol
            int dotIndex = temp.IndexOf('.', atIndex);
            if (dotIndex == -1)
                return false;

            // Check if the dot (.) appears at least two characters after the '@' symbol
            if (dotIndex - atIndex < 2)
                return false;

            // Check if the email ends with a dot (.)
            if (dotIndex == temp.Length - 1)
                return false;

            // Check if the email does not start with a dot (.)
            if (temp[0] == '.')
                return false;

            // Check if the email does not contain consecutive dots (.)
            for (int i = 1; i < temp.Length - 1; i++)
            {
                if (temp[i] == '.' && temp[i - 1] == '.')
                    return false;
            }

            return true;
        }
        public static bool ValidInstagramURL(string temp)
        {
            // Check if the URL starts with the expected prefix
            bool blnResult = (temp.StartsWith("https://www.instagram.com/", StringComparison.OrdinalIgnoreCase));
            return blnResult;
        }

        public static bool NullorEmpty(string temp)
        {
            bool blnResult = string.IsNullOrEmpty(temp);
            return blnResult;
        }
    }
}