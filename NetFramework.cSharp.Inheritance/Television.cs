using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.cSharp.Inheritance
{
    internal class Trainer:BaseType
    {
        public string? branch { get; set; }
        public int branchLevel  { get; set; }

        public DateTime workEntry { get; set; }
        public DateTime workQuit { get; set; }
        public int offDays { get; set; }
    }
}
