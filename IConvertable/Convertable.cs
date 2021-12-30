using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IConvertible
{
    public interface Convertable
    {
        //convert a string from  VB2015 to C# 
        string ConvertToCSharp(string code);

        //convert a string from  C# to  VB2015
        string ConvertToVB2015(string cSharpCode);
    }
}
