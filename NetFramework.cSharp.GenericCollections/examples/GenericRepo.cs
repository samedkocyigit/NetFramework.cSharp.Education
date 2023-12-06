using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.cSharp.GenericClass.examples
{
    public class GenericRepo<T>
    {
        public GenericRepo()
        {

        }
        public virtual List<T> getAll()
        {
            return null;
        }
    }
}
