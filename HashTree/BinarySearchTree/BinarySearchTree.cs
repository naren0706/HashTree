using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Hashtree.BinarySearchTree
{
    public class BinarySearchTree<T> where T : IComparable<T>
    {
        public T NodeData { get; set; }
        public BinarySearchTree<T> left { get; set; }
        public BinarySearchTree<T> right { get; set; }
        public BinarySearchTree(T nodeData)
        {
            this.NodeData = nodeData;
            this.left = null;
            this.right = null;
        }
        int leftCount = 0, rightCount = 0;
        bool result = false;
        public void Insert(T item)
        {
            T currentNodeValue = this.NodeData;
            if ((currentNodeValue.CompareTo(item)) > 0)
            {
                if (this.left == null)
                    this.left = new BinarySearchTree<T>(item);
                else
                    this.left.Insert(item);
            }
            else
            {
                if (this.right == null)
                    this.right = new BinarySearchTree<T>(item);
                else
                    this.right.Insert(item);
            }
        }
        public void Display()
        {
            if (this.left != null)
            {
                this.leftCount++;
                this.left.Display();
            }
            Console.WriteLine(this.NodeData.ToString());
            if (this.right != null)
            {
                this.rightCount++;
                this.right.Display();
            }
        }
        public void GetSize()
        {
            Console.WriteLine("Size" + " " + (1 + this.leftCount + this.rightCount));
        }
        public bool IfExists(T element, BinarySearchTree<T> node)
        {
            if (node == null)
            {
                return false;
            }
            if (node.NodeData.Equals(element))
            {
                Console.WriteLine("Found the element in BST" + " " + node.NodeData);
                result = true;
            }
            else
            {
                Console.WriteLine("Current element is {0} in BST", node.NodeData);
            }
            if (element.CompareTo(node.NodeData) < 0)
            {
                IfExists(element, node.left);
            }
            if (element.CompareTo(node.NodeData) > 0)
            {
                IfExists(element, node.right);
            }
            return result;
        }
    }
}

