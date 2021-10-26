using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devideby4
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalNumber;
            int numMod4;
            double probability;
            int number;

            totalNumber = 0;
            numMod4 = 0;
            for (int i = 1; i < 6; i++)
            {
                for (int j = 4; j < 10; j++)
                {
                    for (int k = 3; k < 9; k++)
                    {
                        for (int l = 6; l < 10; l++)
                        {
                            for (int m = 2; m < 9; m++)
                            {
                                number = m + 1 * 10 + k * 100 + j * 1000 + i * 10000;
                                totalNumber++;
                                if (number % 4 == 0) numMod4++;
                            }
                        }
                    }
                }
            }
            probability = (double)numMod4 / totalNumber;
            Console.WriteLine($"Total numbers: {totalNumber}");
            Console.WriteLine($"By MOD 4 numbers: {numMod4}");
            Console.WriteLine($"Probability: {probability:F4}");
        }
    }
}
