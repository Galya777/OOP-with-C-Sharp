using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IConvertible
{
    public class ProgramConverter : Convertable
    {
  string Convertable.ConvertToCSharp(string code)
        {
            return $"ProgramConverter:IConvertible: VB2015 code:{code} converted to Csharp.";
        }

        string Convertable.ConvertToVB2015(string cSharpCode)
        {
            return $"ProgramConverter:IConvertible: CSharp code:{cSharpCode} converted to VB2015";
        }
    }
}
