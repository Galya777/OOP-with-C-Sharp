using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PythagoreanTriples
{
    class Program
    {
        static void Main(string[] args)
        {
            int side1, side2, hypotenuse;
     
            for(side1=1; side1 < 30; ++side1)
            {
                for (side2 = 1; side2 < 30; ++side2)
                {
                    for (hypotenuse = 1; hypotenuse < 30; ++hypotenuse)
                    {
                        bool pythagorean = (side1 * side1 + side2 * side2 == hypotenuse * hypotenuse);
                        if (pythagorean == true)
                        {
                            Console.WriteLine("|" + side1 + '|' + side2 + '|' + hypotenuse +'|');
                        }
                    }
                }
            }
        }
    }
}
