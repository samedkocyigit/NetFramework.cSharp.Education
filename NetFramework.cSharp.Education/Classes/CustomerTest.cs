using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.cSharp.Education.Classes
{
    class CustomerTest
    {
        static void Main(string[] args)
        {
            Customers c1 = new Customers();
            c1.id = 1;
            c1.cusName = "samed";
            c1.cusSurname = "kocyigit";
            c1.cusEmail = "kcygt.sam@gmail.com";
            c1.userName = "kcygt.sam";
            c1.password = "1";

            Customers.CustomerAdd(c1);

            Customers c2 = new Customers()
            {
                id = 2,
                password = "2",
                userName = "asd",
                cusEmail = "slsls@gmail.com",
                cusName = "aaas",
                cusSurname = "sssa"
            };

            Customers.CustomerAdd(c2);
        }

    }
}
