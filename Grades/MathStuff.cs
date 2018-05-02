using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    public class MathStuff
    {f

        public void SumNumbers(out int sum, params int[] numbers)
        {


        }

        public void SumNumbers(out int sum, int a, int b)
        {

        }

        public int SumNumbers(int a, int b)
        {
            return a + b;
        }

        public void SumTheNumbers(out int x1)
        {
            
            int sum = 5;
            x1 = sum;
            sum = x1 + 3;
            x1 = sum;
        }

    }
}
