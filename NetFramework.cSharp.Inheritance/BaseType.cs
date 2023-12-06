 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.cSharp.Inheritance
{
    internal class BaseType
    {
        public int id { get; set; }
        public int gender { get; set; }
        public string? name { get; set; }
        public string? surname { get; set; }
        public string? referanceCode { get; set; }
        public string? identityNumber { get; set; }
        public DateTime registryDate { get; set; }
        public DateTime updateTime { get; set; }
        public int updateUser { get; set; }
        public int registryUser { get; set; }
        public bool deleted { get; set; }

        public BaseType()
        {
            Random random= new Random();
            id = random.Next(0, 100);
        }

    }
}
