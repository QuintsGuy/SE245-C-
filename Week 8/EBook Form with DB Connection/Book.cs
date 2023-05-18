using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Form_Demo
{
    public class Book
    {
        private string title;
        private string authorFirstName;
        private string authorLastName;
        private string authorEmail;
        private double price;
        private int pages;
        private DateTime pubDate;
        public string feedback;

        public Book()
        {
            feedback = "";
        }
        
        public string Title
        {
            get { return title;  }
            set
            {
                if (Validation.GotBadWords(value))
                {
                    //do not set title and display nasty message
                    Feedback += "\nERROR: You cannot have bad words in your title";
                }
                
                else if (Validation.IsItFilledIn(value, 2) == false)
                {
                    Feedback += "\nERROR: You need at least 2 characters in your title";
                }
                
                else
                {
                    title = value;
                }
            }
        }

        public string AuthorFirstName
        {
            get { return authorFirstName; }
            set 
            { 
                if (Validation.GotBadWords(value))
                {
                    //do not set title and display nasty message
                    Feedback += "\nERROR: You cannot have bad words in author's first name."; 
                }
            
                else if (Validation.IsItFilledIn(value, 2) == false)
                {
                    Feedback += "\nERROR: You need at least 2 characters as author's first name.";
                }
                
                else
                {
                    authorFirstName = value;
                } 
            }
        }

        public string AuthorLastName
        {
            get { return authorLastName; }
            set { 
                if (Validation.GotBadWords(value))
                {
                    //do not set title and display nasty message
                    Feedback += "\nERROR: You cannot have bad words in author's last name."; 
                }
            
                else if (Validation.IsItFilledIn(value, 2) == false)
                {
                    Feedback += "\nERROR: You need at least 2 characters as author's last name.";
                }
                
                else
                {
                    authorLastName = value;
                } 
            }
        }

        public string AuthorEmail
        {
            get { return authorEmail; }
            set
            {
                if (Validation.IsValidEmail(value) == false)
                {
                    //do not set title and display nasty message
                    Feedback += "\nERROR: The email entered is not valid";
                }
                
                else if (Validation.IsItFilledIn(value, 8) == false)
                {
                    Feedback += "\nERROR: You need at least 2 characters in the author's email";
                }
                else
                {
                    authorEmail = value;
                }
            }
        }

        public double Price
        {
            get { return price; }
            set
            {
                if (Validation.IsMinimumAmount(value, 5))
                {
                    Feedback += "\nERROR: The book must be at least $5";
                }
                else if (Validation.IsADouble(value.ToString())==false)
                {
                    Feedback += "\nERROR: Price input is not an integer";
                }
                else
                {
                    price = value;
                }
            }
        }

        public int Pages
        {
            get { return pages; }
            set 
            {
                if (Validation.IsMinimumAmount(value, 25))
                {
                    Feedback += "\nERROR: The book must be at least $5";
                }
                else if (Validation.IsAnInteger(value.ToString())==false)
                {
                    Feedback += "\nERROR: Page input is not an integer";
                }
                else
                {
                    pages = value;
                }
            }
        }

        public DateTime PubDate
        {
            get { return pubDate; }
            set
            {
                if (Validation.IsAFutureDate(value))
                {
                    Feedback += "\nERROR: The date entered is in the future";
                }
                else
                {
                    pubDate = value;
                }
            }
        }

        public string Feedback
        {
            get { return feedback; }
            set { feedback = value; }
        }
    }
}