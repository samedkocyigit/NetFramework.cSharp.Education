using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.cSharp.Abstract
{
    public class Customer:BaseClass
    {
        public int CustomerId { get; set; }
        public Customer()
        {
            CustomerId = 0; 
        }

        public override void hideView()
        {
            Console.WriteLine("Customer => hideView");
        }
    }
}
