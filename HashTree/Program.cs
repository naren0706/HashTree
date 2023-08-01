using System;
using System.Collections;

namespace Hashtree
{
    class Program
    {
        static void Main(string[] args)
        {
            HashTable<string, string> hash = new HashTable<string, string>(5);
            hash.Add("0", "zero");
            hash.Add("1", "one");
            hash.Add("2", "two");
            hash.Add("3", "three");
            hash.Add("4", "four");
            hash.Add("5", "five");
            string hash5 = hash.Get("5");
            Console.WriteLine("5th index value : " + hash5);
            hash.Remove("3");
            string hash2 = hash.Get("3");
            Console.WriteLine("2th index value : " + hash2);
        }
    }
}