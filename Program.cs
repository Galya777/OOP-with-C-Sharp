using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HammingDistance
{
    public class Program
    {
        public class BinaryConverter
        {
            public static void ConvertToBit()
            {
                const int size = 64;
                ulong value;
                char bit;
                System.Console.Write("Enter an integer: ");
                // Use long.Parse() so as to support negative numbers
                // Assumes unchecked assignment to ulong.
                value = (ulong)long.Parse(System.Console.ReadLine());
                // Set initial mask to 100....
                ulong mask = 1UL << size - 1;
                for (int count = 0; count < size; count++)
                {
                    bit = ((mask & value) != 0) ? '1' : '0';
                    System.Console.Write(bit);
                    // Shift mask one location over to the right
                    mask >>= 1;
                }
                System.Console.WriteLine();
            }
        }
        public static byte reverseBits(byte v)
        {
            byte r = v; // r will be reversed bits of v; first get LSB of v
            int s = 7; // extra shift needed at end
            for (v >>= 1; v != 0; v >>= 1)
            {
                r <<= 1;
                r |= (byte)(v & 1);
                s--;
            }
            r <<= s; // shift when v's highest bits are zero
            return r;
        }
static int HammingDistance(long a, long b)
{
    long n = a ^ b;

    int x = 0;
    while (n != 0)
    {
        n &= (n - 1);
        x++;
    }
    return x;
}

public static void Main(string[] args)
        {
            int[][] lookup = new int[256][];

            for (int i = 0; i < 256; i++)
            {
                lookup[i] = new int[256];
                for (int j = 0; j < 256; j++)
                {
                    lookup[i][j] = HammingDistance(i, j);
                }
            }
        }
    }
}
