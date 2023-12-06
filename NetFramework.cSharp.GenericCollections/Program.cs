using NetFramework.cSharp.GenericClass.examples;
using NetFramework.cSharp.GenericCollections.examples;

namespace NetFramework.cSharp.Education.Collections.ArrayLists
{
    class Program
    {
        static void Main(string[] args)

        {

            GenericRepo<Customer> genericCustomer = new GenericRepo<Customer>();

            genericCustomer.getAll();                                                   //Generic class 

            GenericRepo<Product> genericProducts = new GenericRepo<Product>();

            genericProducts.getAll();

            //--------------------------------------------------
            List<Customer> list = new List<Customer>();
            List<int> list2 = new List<int>();

            int[] arr = { 1, 2, 4 }; 

            list2.Add(1);
            list2.Add(2);
            //--------------------------------------------------
            list.Add(new Customer() { age=15,name="samed",surname="kocyigit"});
            list.Add(new Customer() { age = 18, name = "ali", surname = "kocyigit" });

            list2.AddRange(arr);
            for (int i =0; i<list.Count;i++)
            {
                Console.WriteLine(list[i].name);
            }
            foreach(Customer item in list)
            {
                Console.WriteLine(item.name);
            }
        }
    }
}
