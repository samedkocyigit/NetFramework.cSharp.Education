using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.cSharp.VirtualFunctions
{
    public class baseClass
    {
        public virtual void scanScreen(string data)
        {
            Console.WriteLine(data);
        }
    }
}
