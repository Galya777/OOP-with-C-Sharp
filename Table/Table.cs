using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1_45616
{public class TableDiagram
    {
        class Table
        {
            private double a;
            private double b;
            private int step;
            public double A { get => a; set => a = value; }

            public double B { get => b; set => b = value; }
            public int Step { get => step; set => step = value > 0 ? value : 1; }

            public Table(double a, double b, int step)
            {
                this.a = a;
                this.b = b;
                this.Step = step;

            }
            public void MakeTable()
            {
                int count = 0;
                double x = a;
                double size = (b - a) / step;
                Console.WriteLine("x\t\tF(x)");
                do
                {
                    Console.WriteLine("%.4f\t%.4f\n", x, (x - 2) * (x - 2) / (x * x + 1));
                    ++count;
                    if (count % 20 == 0)
                    {
                        Console.WriteLine("Press Return to continue...");
                        Console.ReadKey();
                    }
                    x += size;
                } while (x <= b);
            }


        }
    }
}
