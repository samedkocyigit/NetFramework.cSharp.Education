using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.cSharp.Education.Collections.ArrayLists
{
    internal class ArrayListsExample
    {
        private static void Main(string[] args)
        {
            string? userSelect = string.Empty;
            ArrayList listOfValue = new ArrayList();
            do
            {
                Console.Clear();
                Console.WriteLine("Menu");
                Console.WriteLine("1 - Add Value");
                Console.WriteLine("2 - List Value");
                Console.WriteLine("3 - Find Value");
                Console.WriteLine("4 - Alter Value");
                Console.WriteLine("5 - Remove Value");
                Console.WriteLine("6 - Quit");
                Console.Write("Select the Choose: ");

                userSelect = Console.ReadLine();


                switch (userSelect)
                {
                    case "1":
                        Console.Write("Please Enter the Value You Want to Add: ");
                        string? s1 = Console.ReadLine();
                        listOfValue.Add(s1);

                        Console.WriteLine("Process Completed Successfully ");
                        System.Threading.Thread.Sleep(1000);
                        break;
                    case "2":
                        Console.WriteLine("Here is the Values of the List:");
                        for (int i = 0; i < listOfValue.Count; i++)
                        {
                            Console.WriteLine(i + ": " + listOfValue[i]);
                        }
                        Console.WriteLine("If You Want To Continue Please Press the Any Button");
                        Console.ReadLine();
                        System.Threading.Thread.Sleep(1000);
                        break;
                    case "3":
                        Console.Write("Please Enter the Value of the List Want to See: ");
                        string? indexList = Console.ReadLine();

                        if (listOfValue.Contains(indexList))
                        {
                            int index = listOfValue.IndexOf(indexList);
                            Console.WriteLine(index + ": " + listOfValue[index]);
                        }
                        else
                            Console.WriteLine("There is No Value Want to See");

                        Console.WriteLine("Process Completed Successfully ");
                        System.Threading.Thread.Sleep(1000);
                        break;
                    case "4":
                        Console.WriteLine("Please Enter the Index Wants to Change and Value");
                        Console.Write("Index: ");
                        int changeIndex = Convert.ToInt32(Console.ReadLine());

                        Console.Write("The Value You Want to Change: ");
                        string? s2 = Console.ReadLine();

                        listOfValue[changeIndex] = s2;

                        Console.WriteLine("Process Completed Successfully ");
                        System.Threading.Thread.Sleep(1000);
                        break;
                    case "5":
                        Console.Write("Please Enter the Value Wants to Remove:");
                        string? removeValue = Console.ReadLine();

                        if (listOfValue.Contains(removeValue))
                        {
                            int indexValue = listOfValue.IndexOf(removeValue);
                            listOfValue.RemoveAt(indexValue);
                        }
                        else
                            Console.WriteLine("There is No Value in the List");
                        Console.WriteLine("Process Completed Successfully ");
                        System.Threading.Thread.Sleep(1000);
                        break;
                    case "6":
                        break;
                    default:
                        break;
                }
            } while (userSelect != "6");
        }
    }
}
