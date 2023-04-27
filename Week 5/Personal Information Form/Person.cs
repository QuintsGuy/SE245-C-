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

        // Defining public properties to access and modify the private instance variables of the class
        public string FName
        {
            get
            { return _fname; }
            set
            { _fname = value; }
        }
        public string MName
        {
            get
            { return _mname; }
            set
            { _mname = value; }
        }
        public string LName
        {
            get
            { return _lname; }
            set
            { _lname = value; }
        }
        public string Street1
        {
            get
            { return _street1; }
            set
            { _street1 = value; }
        }
        public string Street2
        {
            get
            { return _street2; }
            set
            { _street2 = value; }
        }
        public string City
        {
            get
            { return _city; }
            set
            { _city = value; }
        }
        public string State
        {
            get
            { return _state; }
            set
            { _state = value; }
        }
        public string ZipCode
        {
            get
            { return _zipcode; }
            set
            { _zipcode = value; }
        }
        public string Phone
        {
            get
            { return _phone; }
            set
            { _phone = value; }
        }
        public string Email
        {
            get
            { return _email; }
            set
            { _email = value; }
        }
    }
}