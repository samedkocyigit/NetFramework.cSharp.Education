using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.cSharp.Abstract
{
    public abstract class BaseClass
    {
        public int DateNow { get; set; }
        public string temp { get; set; }

        public BaseClass()
        {
            DateNow = 23;
            temp= string.Empty;
        }
        public void showView()
        {
            Console.WriteLine("aaa");
        }
       public abstract void hideView(); // abstract method use like this 
    }
}
