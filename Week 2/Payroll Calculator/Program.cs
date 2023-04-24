using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();
            List<double> hours = new List<double>();
            List<double> rates = new List<double>();
            List<double> taxes = new List<double>();

            Console.WriteLine("Enter payroll information for each employee");
            Console.WriteLine();

            while (true)
            {
                Console.Write("Please enter your name: ");
                string name = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(name))
                {
                    break;
                }

                names.Add(name);

                Console.WriteLine("How many hours did you work: ");
                double hoursWorked = double.Parse(Console.ReadLine());
                hours.Add(hoursWorked);

                Console.WriteLine("What is your hourly rate: ");
                double hourlyRate = double.Parse(Console.ReadLine());
                rates.Add(hourlyRate);

                double taxRate = 0;
                if (hourlyRate < 10.0)
                {
                    taxRate = 0.1;
                }
                else if (hourlyRate >= 10.0 && hourlyRate < 20.0)
                {
                    taxRate = 0.2;
                }
                else
                {
                    taxRate = 0.3;
                }

                double taxAmount = hoursWorked * hourlyRate * taxRate;
                taxes.Add(taxAmount);

                Console.WriteLine("\n\nPayroll Summary: \n\n");

                double totalPay = 0.0;

                for (int i =0; i < names.Count; i++)
                {
                    double pay = hours[i] * rates[i] - taxes[i];
                    totalPay += pay;

                    Console.WriteLine($"{names[i]}: {pay:C}");
                }

                double averageIncome = totalPay / names.Count;
                Console.WriteLine($"\n\nAverage Income: {averageIncome:C}");

                Console.ReadLine();

            }
        }
    }
}
