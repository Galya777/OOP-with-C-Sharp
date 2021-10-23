using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1_45616
{
    class TableTest
    {
        public static void main()
        {
            double a, b;
            int step;
            Console.WriteLine("Enter the left endpoint of interval:");
            string aText = Console.ReadLine();
            a = Double.Parse(aText);
            Console.WriteLine("Enter the right endpoint of interval:");
            string bText = Console.ReadLine();
            b = Double.Parse(bText);
            Console.WriteLine("Enter the left endpoint of interval:");
            string stepText = Console.ReadLine();
            step = Int32.Parse(stepText);
            if (a > b)
            {
                double temp = a;
                a = b;
                b = temp;
            }
                Table table = new Table(a, b, step);
                table.MakeTable();
            
        }
    }
}
