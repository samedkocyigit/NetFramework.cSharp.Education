using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.cSharp.FormWindows
{
    public class User
    {
        public string? name { get; set; }
        public string? surname { get; set; }
        public string? phoneNumber { get; set; }
        public string? email { get; set; }

        public override string ToString()
        {
            return name + " " + surname;
        }
        /// <summary>
        /// /////////////////////////////////////
        /// </summary>
        public int id { get; set; }
        public string? password  { get; set; }
        public string? userName { get; set; }
        public string? commentBelow { get; set; }
    }
}
