using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisionProblem_Day3
{
    public static class LengthOfLine
    {



        public static void CalculateLengthOfLine()
        {
            double x1 = 5, x2 = 4, y1 = 5, y2 = 3;
            double Length;
            Console.WriteLine("enter x1,y1,x2,y2:");

            Length = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            Console.WriteLine("LengthOfLine" + Length);

        }
    }
}