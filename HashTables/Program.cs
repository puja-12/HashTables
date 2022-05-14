// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Collections;

namespace HashTables
{

    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("select no\n1)index value of words\n2)index value of paragraph\n");

                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("welcome to hashtable");
                        mymapNode<string, string> hash = new mymapNode<string, string>(5);
                        hash.Add("0", "To");
                        hash.Add("1", "be");
                        hash.Add("2", "or");
                        hash.Add("3", "not");
                        hash.Add("4", "to");
                        hash.Add("5", "be");
                        string hash5 = hash.Get("5");
                        Console.WriteLine("5th index value: " + hash5);

                        string hash2 = hash.Get("2");
                        Console.WriteLine("2nd  index value: " + hash2);
                        break;
                    case 2:
                        mymapNode<string, string> hash3 = new mymapNode<string, string>(5);
                        String testing = "Paranoids are not paranoid  because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable  situations";

                        Console.Write(testing.IndexOf("because") + Environment.NewLine);

                        Console.WriteLine(testing.Substring(testing.IndexOf("because")));
                                          
                        Console.WriteLine("Occurrence:" + hash3.CheckOccurrences(testing, "because"));
                        
                        break;

                }

            }
        }
    }
}

       
