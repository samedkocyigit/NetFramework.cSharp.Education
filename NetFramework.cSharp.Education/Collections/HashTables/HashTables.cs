using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace NetFramework.cSharp.Education.Collections.HashTables
{
    internal class HashTables
    {
        static void Main(string[] args)
        {
            Hashtable h1 = new Hashtable();

            #region Add Value
            h1.Add("001", "samed");
            h1.Add("002", "onur");
            #endregion

            #region Helper Method
            bool control1 = h1.Contains("001");
            bool control2 = h1.Contains("ssss");

            bool control3 = h1.ContainsKey("002");
            bool control4 = h1.ContainsValue("samed");

            h1.Remove("001");

            int Counter = h1.Count;

            h1.Clear(); //Remove the all datas
            #endregion
        }
    }
}
