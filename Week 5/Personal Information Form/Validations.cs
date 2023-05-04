namespace Personal_Information_Form
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
        public static bool IsItInteger(double temp)
        {
            int intResult;
            bool blnresult = int.TryParse(temp, out intResult);
            return blnresult;
        }
    }
}