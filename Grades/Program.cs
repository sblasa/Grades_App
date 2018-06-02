using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {



            GradeBook book = new GradeBook();

            GetBookName(book);

            AddGrades(book);

            NewMethod(book);


            /*
            MathStuff something = new MathStuff();
            int x2 = 8;
            something.SumTheNumbers(out x2);
            Console.WriteLine("Value of x2 is " + x2);
            */

            WriteResults(book);

        }

        private static void WriteResults(GradeBook book)
        {
            GradeStatistics stats = book.ComputeStatistics();
            WriteResults("Average", stats.AverageGrade);
            WriteResults("Highest Grade", stats.HighestGrade);
            WriteResults("Lowest Grade", stats.LowestGrade);
            WriteResults(stats.Description, stats.LetterGrade);
        }

        private static void NewMethod(GradeBook book)
        {
            using (StreamWriter outputFile = File.CreateText("grades.txt"))
            {
                book.WriteGrade(outputFile);
            }
        }

        private static void AddGrades(GradeBook book)
        {
            book.AddGrade(91);
            book.AddGrade(89.5f);
            book.AddGrade(75);
        }

        private static void GetBookName(GradeBook book)
        {
            try
            {
                Console.WriteLine("Enter a name");
                book.Name = Console.ReadLine();
            }

            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void WriteResults(string description, string result)
        {
            Console.WriteLine($"{description}: {result}");
        }

        static void WriteResults(string description, float result)
        {
            Console.WriteLine($"{description} : {result:F2}");
        }
    }
}
