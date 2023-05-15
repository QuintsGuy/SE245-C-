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
    public class PersonV2: Person
    {
        private string _cellPhone;
        private string _instagramURL;

        public string CellPhone
        {
            get { return _cellPhone; }
            set
            {
                if (Validations.IsADouble(value)==false)
                {
                    Feedback += "\nERROR: Cellphone must only contain numbers";
                }
                else if (Validations.ExactLength(value, 10)==false)
                {
                    Feedback += "\nERROR: Cellphone must contain 10 numbers";
                }
                else
                {
                    _cellPhone = value;
                }
            }
        }
        public string InstagramURL
        {
            get { return _instagramURL; }
            set
            {
                if (Validations.GotProfanity(value))
                {
                    Feedback += "\nYour Instagram URL cannot contain profanity";
                }
                else if (Validations.ValidInstagramURL(value)==false)
                {
                    Feedback += "\nInvalid URL to instagram";
                }
                else
                {
                    _instagramURL = value;
                }
            }
        }
    }
}