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
                Console.WriteLine("select no\n1)index value of words\n2)index value of paragraph\n3)remove");

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
                        hash3.Display();
                        break; 
                    case 3:
                        mymapNode<string, int> hash4 = new mymapNode<string, int>(5);
                        string Para = "Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";
                        string[] arr = Para.Split(' ');
                        LinkedList<string> checkForduplication = new LinkedList<string>();
                        foreach (string element in arr)
                        {
                            int count = 0;
                            foreach (string match in arr)
                            {
                                if (element == match)
                                {
                                    count++;
                                    if (checkForduplication.Contains(element))
                                    {
                                        break;
                                    }
                                }
                            }
                            if (!checkForduplication.Contains(element))
                            {
                                checkForduplication.AddLast(element);
                                hash4.Add(element, count);
                            }
                        }
                        hash4.Display();
                        Console.WriteLine("Please enter the word u want to remove :");
                        string WordToRemove = Console.ReadLine();
                        hash4.Remove(WordToRemove);
                        hash4.Display();
                        break;
                }
            }

        }

    }
}

       
