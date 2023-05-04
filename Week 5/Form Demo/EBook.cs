using System;
using Form_Demo;

namespace Form_Demo
{
    public class EBook: Book
    {
        private DateTime dateRentalExpires;
        private int bookmarkPage;

        public DateTime DateRentalExpires
        {
            get { return dateRentalExpires; }
            set 
            {
                if (Validation.IsAFutureDate(value))
                {
                    dateRentalExpires = value;
                }
                else
                {
                    feedback += "\nERROR: You must enter future dates";
                }
            }
        }

        public int BookmarkPage
        {
            get { return bookmarkPage; }
            set
            {
                if (value >= 0 && value <= Pages)
                {
                    bookmarkPage = value;
                }
                else
                {
                    Feedback += "\nERROR: Sorry you entered an invalid bookmark page #.";
                }
            }
        }

        public EBook() : base()
        {
            BookmarkPage = 0;
            dateRentalExpires = DateTime.Now.AddDays(14);
        }
    }
}