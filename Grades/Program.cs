using System;
using System.Collections.Generic;
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
            book.Name = null;
            book.AddGrade(91);
            book.AddGrade(89.5f);
            book.AddGrade(75);
            book.WriteGrade(Console.Out);

            /*
            MathStuff something = new MathStuff();
            int x2 = 8;
            something.SumTheNumbers(out x2);
            Console.WriteLine("Value of x2 is " + x2);
            */

            GradeStatistics stats = book.ComputeStatistics();
            WriteResults("Average", stats.AverageGrade);
            WriteResults("Highest Grade", stats.HighestGrade);
            WriteResults("Lowest Grade", stats.LowestGrade);
            WriteResults(stats.Description, stats.LetterGrade);

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
