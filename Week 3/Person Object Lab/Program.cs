using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person_Object_Lab
{
    internal class Program
    {
        public class Person
        {
            public string FName;
            public string MName;
            public string LName;
            public string Street1;
            public string Street2;
            public string City;
            public string State;
            public string ZipCode;
            public string Phone;
            public string Email;
        }
        public static void Main(string[] args)
        {
            bool blnResult = false;
            Person user = new Person();

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