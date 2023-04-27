namespace Personal_Information_Form
{
    public class Person
    {
        // Declaring private instance variables for the class Person
        private string _fname;
        private string _mname;
        private string _lname;
        private string _street1;
        private string _street2;
        private string _city;
        private string _state;
        private string _zipcode;
        private string _phone;
        private string _email;
        private string _feedback;

        public Person()
        {
            _feedback = "";
        }

        // Defining public properties to access and modify the private instance variables of the class
        public string FName
        {
            get
            { return _fname; }
            set
            {
                if (Validations.GotProfanity(value))
                {
                    Feedback += "ERROR: Your name input contains profanity";
                }
                else if (Validations.TooManyLetters(value, 15) == false)
                {
                    Feedback += "\nERROR: Your First Name input is too long";
                }
                else
                {
                    _fname = value;
                }
            }
        }
        public string MName
        {
            get
            { return _mname; }
            set
            {
                if (Validations.ExactLength(value, 1) == false)
                {
                    Feedback += "\nERROR: Middle Initial can only contain one character";
                }
                else
                {
                    _mname = value;
                }
            }
        }
        public string LName
        {
            get
            { return _lname; }
            set
            {
                if (Validations.GotProfanity(value))
                {
                    Feedback += "\nERROR: Your Last Name input contains profanity";
                }
                else if (Validations.TooManyLetters(value, 15) == false)
                {
                    Feedback += "\nERROR: Your Last Name input is too long";
                }
                else
                {
                    _lname = value;
                }
            }
        }
        public string Street1
        {
            get
            { return _street1; }
            set
            {
                if (Validations.GotProfanity(value))
                {
                    Feedback += "ERROR: Your Street1 input contains profanity";
                }
                else if (Validations.TooManyLetters(value, 45) == false)
                {
                    Feedback += "\nERROR: Your Street1 input is too long";
                }
                else if (Validations.IsItFilledIn(value, 10) == false)
                {
                    Feedback += "\nERROR: Your Street1 input is too short";
                }
                else
                {
                    _street1 = value;
                }
            }
        }
        public string Street2
        {
            get
            { return _street2; }
            set
            {
                if (Validations.GotProfanity(value))
                {
                    Feedback += "ERROR: Your Street2 input contains profanity";
                }
                else if (Validations.TooManyLetters(value, 25) == false)
                {
                    Feedback += "\nERROR: Your Street2 input is too long";
                }
                else
                {
                    _street2 = value;
                }
            }
        }
        public string City
        {
            get
            { return _city; }
            set
            {
                if (Validations.GotProfanity(value))
                {
                    Feedback += "ERROR: Your City input contains profanity";
                }
                else if (Validations.TooManyLetters(value, 20) == false)
                {
                    Feedback += "\nERROR: Your City input is too long";
                }
                else if (Validations.IsItFilledIn(value, 3) == false)
                {
                    Feedback += "\nERROR: Your City input is too short";
                }
                else
                {
                    _city = value;
                }
            }
        }
        public string State
        {
            get
            { return _state; }
            set
            {
                if (Validations.ExactLength(value, 2) == false)
                {
                    Feedback += "\nERROR: State must contain only two letters";
                }
                else
                {
                    _state = value;
                }
            }
        }
        public string ZipCode
        {
            get
            { return _zipcode; }
            set
            {
                if (Validations.ExactLength(value, 5) == false)
                {
                    Feedback += "\nERROR: Zipcode must contain only five digits";
                }
                else if (Validations.IsItInteger(value) == false)
                {
                    Feedback += "\nERROR: Zipcode must only contain numbers";
                }
                else
                {
                    _zipcode = value;
                }
            }
        }
        public string Phone
        {
            get
            { return _phone; }
            set
            {
                if (Validations.ExactLength(value, 10) == false)
                {
                    Feedback += "\nERROR: Phone number must only contain 10 digits";
                }
                else if (Validations.IsItInteger(value) == false)
                {
                    Feedback += "\nERROR: Phone number must only contain numbers";
                }
                else
                {
                    _phone = value;
                }
            }
        }
        public string Email
        {
            get
            { return _email; }
            set
            {
                if (Validations.GotProfanity(value))
                {
                    Feedback += "\nERROR: Your Email contains profanity";
                }
                else if (Validations.IsItFilledIn(value, 10) == false)
                {
                    Feedback += "\nERROR: Your email needs to be longer";
                }
                else if (Validations.TooManyLetters(value, 45) == false)
                {
                    Feedback += "\nERROR: Your Email is too long";
                }
                else
                {
                    _fname = value;
                }
            }
        }
        public string Feedback
        {
            get { return _feedback; }
            set { _feedback = value; }
        }
    }
}