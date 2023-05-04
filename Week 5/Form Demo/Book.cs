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
                    Feedback += "\nERROR: You have poop in your title";
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
            set { authorFirstName = value; }
        }

        public string AuthorLastName
        {
            get { return authorLastName; }
            set { authorLastName = value; }
        }

        public string AuthorEmail
        {
            get { return authorEmail; }
            set
            {
                if (Validation.GotBadWords(value))
                {
                    //do not set title and display nasty message
                    Feedback += "\nERROR: You have poop in your title";
                }
                
                else if (Validation.IsItFilledIn(value, 8) == false)
                {
                    Feedback += "\nERROR: You need at least 2 characters in your title";
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
            set { price = value; }
        }

        public int Pages
        {
            get { return pages; }
            set { pages = value; }
        }

        public DateTime PubDate
        {
            get { return pubDate; }
            set { pubDate = value; }
        }

        public string Feedback
        {
            get { return feedback; }
            set { feedback = value; }
        }
    }
}