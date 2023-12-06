using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.cSharp.VirtualFunctions
{
    public class Customer:baseClass
    {
        public override void scanScreen(string data)
        {
            Console.WriteLine("Customer =>" + data);
        }

        //public int age { get; set; }
        //public string name { get; set; }
        //public string surname { get; set; }

        //public override string ToString()
        //{ 
        //    return name +" "+ surname;
        //}
    }
}
