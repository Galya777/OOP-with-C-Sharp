using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IConvertible
{  
    public class ProblemHelper :ProgramConverter, Convertable, CodeChercker
    {
        public bool CodeCheckSyntax(string string2check, string language)
        {
            throw new NotImplementedException();
        }
         string Convertable.ConvertToCSharp(string code)
        {
            return $"IConvertible: VB2015 code:{code} converted to Csharp.";
        }

         string Convertable.ConvertToVB2015(string cSharpCode)
        {
            return $"IConvertible: CSharp code:{cSharpCode} converted to VB2015.";
        }
        public string ConvertToCSharp(string code)
        {
            return $"VB2015 code:{code} converted to Csharp.";
        }

        public string ConvertToVB2015(string cSharpCode)
        {
            return $"CSharp code:{cSharpCode} converted to VB2015.";
        }
        public bool CheckSyntax(string string2Check, string language)
        {
            Console.WriteLine($"CodeCheckSyntax:{language} code {string2Check} is OK");
            return true;
        }
    }


    
}
