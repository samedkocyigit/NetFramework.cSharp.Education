using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.cSharp.Interface
{
    internal interface ICustomer
    { 

        string Name { get; set; }
        string Surname { get; set; }

        string Id { get; set; }

        public int ShowScreen();
        public void RemoveRegister(string Id);
    }
}
