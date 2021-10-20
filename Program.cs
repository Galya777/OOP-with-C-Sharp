using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week1task5
{
    class Program
    {
        static void Main(string[] args)
        {
            int number= Console.Read();
            for(int i = 0; i < number; ++i)
            {
                int N = (int)(i * Math.Pow(4, i));
                switch (N)
                {
                    case 0: Console.Write("A");
                        break;
                    case 1:
                        Console.Write("C");
                        break;
                    case 2:
                        Console.Write("G");
                        break;
                    case 3:
                        Console.Write("T");
                        break;
                }
            }
            
        }
    }
}
