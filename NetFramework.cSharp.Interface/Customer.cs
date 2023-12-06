using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.cSharp.Interface
{
    internal class Customer : ICustomer
    {
        string? _Name;
        string? _Surname;
        string? _Id;
        public string Name { get { return _Name; } set { _Name = value; } }
        public string Surname { get { return _Surname; } set { _Surname = value; } }
        public string Id { get { return _Id; } set { _Id = value; } }

        public void RemoveRegister(string Id)
        {
            throw new NotImplementedException();
        }

        public int ShowScreen()
        {
            throw new NotImplementedException();
        }
    }
}
