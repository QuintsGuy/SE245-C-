using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Average_Grade_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            String studentName;
            Double grade1, grade2, grade3, grade4, averageGrade;
            Char letterGrade, loopAnswer;

            do
            {
                Console.WriteLine("Enter Student's Name: ");
                studentName = Console.ReadLine();

                Console.WriteLine("Enter Grade 1 (20%): ");
                grade1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter Grade 2 (20%): ");
                grade2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter Grade 3 (25%): ");
                grade3 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter Grade 4 (35%): ");
                grade4 = Convert.ToDouble(Console.ReadLine());

                averageGrade = (grade1 * 0.2) + (grade2 * 0.2) + (grade3 * 0.5) + (grade4 * 0.35);

                letterGrade = 'F';

                if (averageGrade >= 90)
                {
                    letterGrade = 'A';
                }
                else if (averageGrade >= 80)
                {
                    letterGrade = 'B';
                }
                else if (averageGrade >= 70)
                {
                    letterGrade = 'C';
                }
                else if (averageGrade >= 60)
                {
                    letterGrade = 'D';
                }

                Console.WriteLine($"Student: {studentName}");
                Console.WriteLine($"Average Grade: {averageGrade.ToString("0.##")}");
                Console.WriteLine($"Letter Grade: {letterGrade}");

                Console.WriteLine("Would you like to check another student's grade? (y/n): ");
                loopAnswer = Convert.ToChar(Console.ReadLine());
            } while (loopAnswer == 'y');
        }
    }
}
