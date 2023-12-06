using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Security.Cryptography;
using System.Runtime.InteropServices;

namespace NetFramework.cSharp.Education.Collections.HashTables
{
    internal class HashTablesExample
    {
        static void Main(string[] args)
        {
            Hashtable dictiniory = new Hashtable();
            string? userSelect = string.Empty;
            //string? english = string.Empty;
            //string? turkish = string.Empty;
            do
            {
                //string? userSelect = string.Empty;
                string? english = string.Empty;
                string? turkish = string.Empty;
                Console.Clear();
                Console.WriteLine("        Welcome The Your Personal Dictinoary ");
                Console.WriteLine("1: Add New Word");
                Console.WriteLine("2: List the Dictinoary");
                Console.WriteLine("3: Remove The Word");
                Console.WriteLine("4: Quit");
                Console.Write("Please Select the Choose:");
                userSelect = Console.ReadLine();

                switch (userSelect)
                {
                    case "1":
                        Console.WriteLine("Please Enter The New Words: ");
                        Console.Write("English: ");
                        english = Console.ReadLine();
                        Console.Write("Turkish: ");
                        turkish = Console.ReadLine();
                        if (dictiniory.ContainsKey(english))
                        {
                            Console.WriteLine("Dictionary Already Have the Word ");
                            Console.WriteLine("Here is the Dictionary");
                            foreach (DictionaryEntry item in dictiniory)
                                Console.WriteLine(item.Key + "-->  " + item.Value);
                        }
                        else
                            dictiniory.Add(english, turkish);
                        break;
                    case "2":
                        Console.WriteLine("Here is the Dictionary ");
                        foreach (DictionaryEntry item in dictiniory)
                            Console.WriteLine(item.Key + "-->  " + item.Value);
                        Console.WriteLine("Press any Button If You Want To Continue");
                        Console.ReadLine();
                        break;
                    case "3":
                        Console.WriteLine("Please Enter the Word You Want to Remove");
                        string? removen = Console.ReadLine();
                        if (dictiniory.ContainsKey(removen))
                        {
                            dictiniory.Remove(removen);
                            Console.WriteLine("The Word Removed Successfully");
                        }
                        else
                            Console.WriteLine("Dictionary Has Not the Word You Want to Remove");
                        break;
                    case "4":
                        break;
                    default:
                        Console.WriteLine("Please Enter the Correct Number");
                        break;
                }
            } while (userSelect != "4");
        }
    }
}
