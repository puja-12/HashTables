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
                        mymapNode<string, int> hash3 = new mymapNode<string, int>(5);

                        string Word = "Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";
                        string[] array2 = Word.Split(' ');
                        LinkedList<string> checkForDuplication2 = new LinkedList<string>();
                        foreach (string element in array2)
                        {
                            int count = 0;
                            foreach (string match in array2)
                            {
                                if (element == match)
                                {
                                    count++;
                                    if (checkForDuplication2.Contains(element))
                                    {
                                        break;
                                    }
                                }
                            }
                            if (!checkForDuplication2.Contains(element))
                            {
                                checkForDuplication2.AddLast(element);
                                hash3.Add(element, count);
                            }
                        }
                        break;
                }

            }
        }
    }
}

       
