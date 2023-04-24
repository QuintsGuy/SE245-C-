using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll_Calculator
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<string> names = new List<string>();
            List<double> hours = new List<double>();
            List<double> rates = new List<double>();
            List<double> grossPay = new List<double>();
            List<double> taxes = new List<double>();
            List<double> netPay = new List<double>();

            string runProgram;
            
            Console.WriteLine("Enter payroll information for the employee");

            do
            {
                Console.Write("\nPlease enter the employee's name: ");
                string employeeName = Console.ReadLine();
                names.Add(employeeName);
                
                double hoursWorked;
                while (true)
                {
                    Console.Write("Hour many hours did the employee work: ");
                    try
                    {
                        hoursWorked = double.Parse(Console.ReadLine());
                        break; 
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number.");
                    }
                }
                hours.Add(hoursWorked);

                double hourlyRate;
                while (true)
                {
                    Console.Write("What is the employee's hourly rate: ");
                    try
                    {
                        hourlyRate = double.Parse(Console.ReadLine());
                        break; // break out of the loop if successful parse
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number.");
                    }
                }
                rates.Add(hourlyRate);

                double weeklyGrossPay = hoursWorked * hourlyRate;
                grossPay.Add(weeklyGrossPay);
                
                double taxRate;
                if (weeklyGrossPay > 1000)
                {
                    taxRate = 0.3;
                }
                else if (weeklyGrossPay >= 750 && weeklyGrossPay < 1000)
                {
                    taxRate = 0.2;
                }
                else
                {
                    taxRate = 0.1;
                }

                double taxAmount = weeklyGrossPay * taxRate;
                taxes.Add(taxAmount);

                double totalPay = weeklyGrossPay - taxAmount;
                netPay.Add(totalPay);
                
                DisplayPaySummary(names, hours, rates, grossPay, taxes, netPay);

                runProgram = RunProgramAgain();

            } while (runProgram == "y");
        }
        
        static double AverageNetPay(List<string> names, List<double> netPay)
        {
            double totalPay = 0;
            for (int i = 0; i < names.Count; i++)
            {
                totalPay += netPay[i];
            }

            double averagePay = totalPay / names.Count;
            return averagePay;
        }
        static void DisplayPaySummary(List<string> names, List<double> hours, List<double> rates, List<double> grossPay, List<double> taxes, List<double> netPay)
        {
            Console.WriteLine("\nPay Summary:");

            Console.WriteLine("{0,-15}{1,-10}{2,-10}{3,-10}{4,-10}{5,-10}",
                "Name", "Hours", "Rate", "GrossPay", "Taxes", "NetPay");

            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine("{0,-15}{1,-10}{2,-10}{3,-10}{4,-10}{5,-10}",
                    names[i], hours[i], rates[i], grossPay[i], taxes[i], netPay[i]);
            }

            Console.WriteLine($"\nThe total average pay for all employee's is ${AverageNetPay(names, netPay)}");
        }
        static string RunProgramAgain()
        {
            while (true)
            {
                Console.Write("\nWould you like to calculate another employee's pay? (y/n): ");
                string inputResponse = Console.ReadLine().ToLower();
                if (inputResponse == "y" || inputResponse == "n")
                {
                    return inputResponse;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter either y/n.");
                }
            }
        }
    }
}