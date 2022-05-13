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

        }

        }
    }

       
