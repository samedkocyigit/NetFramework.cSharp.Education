using System.Collections;

namespace netframework.csharp.education
{
    internal class ArrayLists
    {
        static void Main1(string[] args)
        {
            int capacity = 0;
            int count = 0;
            ArrayList a1 = new ArrayList();

            #region add a value
            a1.Add(1);

            #region examine the capacity&count 
            capacity = a1.Capacity;
            count = a1.Count;
            #endregion

            a1.Add("samed koc");
            #endregion

            #region add multiple value
            ArrayList a2 = new ArrayList();

            a2.Add(2);
            a2.Add(3);
            a2.Add(4);
            a2.Add(5);
            a2.Add(6);

            a1.AddRange(a2);
            #endregion

            #region access the value in the collection
            object o1 = a1[3];
            string s1 = a1[3].ToString();

            a1[3] = "ali suha";
            #endregion

            #region remove the value
            a1.RemoveAt(3);
            a1.Remove(3);
            a1.RemoveRange(2, 2);
            #endregion

            #region sort the arraylist
            // a to z 
            a1.Sort();

            // reverse the array
            a1.Reverse();
            #endregion

            #region helper funct
            bool control1 = a1.Contains("ali suha");
            bool control2 = a1.Contains(244);

            int indexvalue = a1.IndexOf("ali suha");
            a1.RemoveAt(indexvalue);

            a1.Clear(); // remove the all values    
            a1.TrimToSize();  // size the capacity 

            object[] o2 = a2.ToArray();
            #endregion
        }
    }
}