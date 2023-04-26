using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person_Object_Lab
{
    internal class Program
    {
        // Defining a class named Person which is private
        private class Person
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
                {
                    return _fname;
                }
                set
                {
                    _fname = value;
                }
            }
            public string MName
            {
                get
                {
                    return _mname;
                }
                set
                {
                    _mname = value;
                }
            }
            public string LName
            {
                get
                {
                    return _lname;
                }
                set
                {
                    _lname = value;
                }
            }
            public string Street1
            {
                get
                {
                    return _street1;
                }
                set
                {
                    _street1 = value;
                }
            }
            public string Street2
            {
                get
                {
                    return _street2;
                }
                set
                {
                    _street2 = value;
                }
            }
            public string City
            {
                get
                {
                    return _city;
                }
                set
                {
                    _city = value;
                }
            }
            public string State
            {
                get
                {
                    return _state;
                }
                set
                {
                    _state = value;
                }
            }
            public string ZipCode
            {
                get
                {
                    return _zipcode;
                }
                set
                {
                    _zipcode = value;
                }
            }
            public string Phone
            {
                get
                {
                    return _phone;
                }
                set
                {
                    _phone = value;
                }
            }
            public string Email
            {
                get
                {
                    return _email;
                }
                set
                {
                    _email = value;
                }
            }
        }
        public static void Main(string[] args)
        {
            bool blnResult = false;
            
            // Creating an object of class Person named user
            Person user = new Person();

            // Reading the user's inputs and storing them in the corresponding property of the object user
            Console.Write("\nPlease enter your first name: ");
            user.FName = Console.ReadLine();
            
            Console.Write("\nPlease enter your middle name: ");
            user.MName = Console.ReadLine();
            
            Console.Write("\nPlease enter your last name: ");
            user.LName = Console.ReadLine();
            
            Console.Write("\nPlease enter street address: ");
            user.Street1 = Console.ReadLine();
            
            Console.Write("\nPlease enter street2 if applicable: ");
            user.Street2 = Console.ReadLine();
            
            Console.Write("\nPlease enter your city: ");
            user.City = Console.ReadLine();
            
            Console.Write("\nPlease enter your state: ");
            user.State = Console.ReadLine();
            
            Console.Write("\nPlease enter your zipcode: ");
            user.ZipCode = Console.ReadLine();
            
            Console.Write("\nPlease enter your phone number: ");
            user.Phone = Console.ReadLine();
            
            Console.Write("\nPlease enter your email address: ");
            user.Email = Console.ReadLine();
            
            Console.WriteLine($"\nName: {user.FName} {user.MName} {user.LName}");
            Console.WriteLine($"Address: {user.Street1}, {user.Street2} {user.City}, {user.State} {user.ZipCode}");
            Console.WriteLine($"Phone Number: {user.Phone}");
            Console.WriteLine($"Email Address: {user.Email}");

            Console.ReadLine();
        }
    }
}