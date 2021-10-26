using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinusRow
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //data declaration
            double x; //independent var for Cosine
            double eps; //accuracy

            int counter;
            double term;
            double sum; //the cosine
            //sample initialization
            x = 1.5;
            eps = 0.0001;

            //processing
            term = 1;
            sum = 1;
            counter = 0;

            do
            {
                counter += 2;
                term = -term * x * x / (counter * (counter - 1));
                sum += term;

            } while (Math.Abs(term)>eps);

            Console.WriteLine($"Cos({x}) = {Math.Cos(x)}");
            Console.WriteLine($"Approximate Cos({x}) = {sum}");

        }
    }
}
