using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.cSharp.Inheritance
{
    internal class Personal:BaseType
    {

        public DateTime workEntry { get; set; }
        public DateTime workQuit { get; set; }
        public int offDays { get; set; }
    }
}
