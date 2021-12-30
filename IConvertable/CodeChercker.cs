using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IConvertible
{
    public interface CodeChercker:Convertable
    {
        //Checkes the syntax
        bool CodeCheckSyntax(string string2check, string language);
    }
}
