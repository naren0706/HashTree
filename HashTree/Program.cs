using Hashtree.BinarySearchTree;
using System.Runtime.CompilerServices;

namespace Hashtree
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("1.HashTree\n2.binary Search tree");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice) 
                {
                    case 1:
                        string filePath = @"E:\BridgeGateProblems\HashTree\HashTree\BinarySearchTree\Hashtext.txt";
                        string[] words = File.ReadAllText(filePath).Split(" ");
                        int length = words.Length;
                        HashTable<int, string> hash = new HashTable<int, string>(length);
                        int i = 0;
                        foreach (var item in words)
                        {
                            Console.WriteLine(i + " " + item);
                            hash.Add(i++, item);
                        }
                        break;
                    case 2:
                        BinarySearchTree<int> binarySearchTree = new BinarySearchTree<int>(56);
                        binarySearchTree.Insert(30);
                        binarySearchTree.Insert(70);
                        binarySearchTree.Insert(22);
                        binarySearchTree.Insert(40);
                        binarySearchTree.Insert(60);
                        binarySearchTree.Insert(95);
                        binarySearchTree.Insert(11);
                        binarySearchTree.Insert(3);
                        binarySearchTree.Insert(16);
                        binarySearchTree.Insert(65);
                        binarySearchTree.Insert(63);
                        binarySearchTree.Insert(67);
                        binarySearchTree.Display();
                        binarySearchTree.GetSize();
                        binarySearchTree.IfExists(63, binarySearchTree);
                        break;
            }
            }
        }
    }
}