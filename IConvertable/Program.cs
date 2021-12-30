using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IConvertible
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ProblemHelper problemHelper = new ProblemHelper();
           Console.WriteLine(((Convertable)problemHelper).ConvertToCSharp("Vb code..."));
            Console.WriteLine(((Convertable)problemHelper).ConvertToVB2015("C# code..."));
            Convertable ic = problemHelper;
            if(ic is ProblemHelper phelper)
            {
                Console.WriteLine("Test \"is\" operator");
                Console.WriteLine(phelper.CodeCheckSyntax("CS code to check", "CS"));
                Console.WriteLine(phelper.ConvertToCSharp("CS code to check"));

            }
            var isphelper = ic as ProblemHelper;
            if (isphelper != null)
            {
                Console.WriteLine("Test \"as\" operator");
                Console.WriteLine(isphelper.CodeCheckSyntax("CS code to check", "CS"));
                Console.WriteLine(isphelper.ConvertToCSharp("CS code to check"));
            }
            Console.WriteLine(((CodeChercker)problemHelper).ConvertToCSharp("Vb code..."));
            Console.WriteLine(((CodeChercker)problemHelper).ConvertToVB2015("C# code..."));
        }
    }
}
