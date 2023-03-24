using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTablesAndFunctions
{
    public class BinarySearchTree<T> where T: IComparable<T> 
    {
        public T Nodedata { get; set; }
        public BinarySearchTree<T> LeftTree { get; set; }
        public BinarySearchTree<T> RightTree { get; set; }
        public BinarySearchTree(T nodeData)
        {
            this.Nodedata = nodeData;
            this.LeftTree = null;
            this.RightTree = null;
        }
        int leftCount = 0;
        int rightCount = 0;
        bool result = false;
        public void Insert(T item)
        {
            T currentNodeValue = this.Nodedata;
            if (currentNodeValue.CompareTo(item) > 0)
            {

                if (this.LeftTree == null)
                {
                    this.LeftTree = new BinarySearchTree<T>(item);
                }
                else
                {

                    this.LeftTree.Insert(item);
                }
            }
            else
            {
                if (this.RightTree == null)
                    this.RightTree = new BinarySearchTree<T>(item);
                else
                    this.RightTree.Insert(item);
            }
        }
        public void Display()
        {
            if (this.LeftTree != null)
            {
                this.leftCount++;
                this.LeftTree.Display();
            }
            Console.WriteLine(this.Nodedata.ToString());
            if (this.RightTree != null)
            {
                this.rightCount++;
                this.RightTree.Display();
            }
        }
        public void GetSize()
        {
            Console.WriteLine("Size" + " " + (1 + this.leftCount + this.rightCount));
        }
        public bool IfExits(T element, BinarySearchTree<T> node)
        {
            if (node == null)
            {
                return false;
            }
            if (node.Nodedata.Equals(element))
            {
                Console.WriteLine("Found the element in BST " + " " + node.Nodedata);
                return true;
            }
            else
            {
                Console.WriteLine("Current element is {0} ", node.Nodedata);
            }
            if (element.CompareTo(node.Nodedata) < 0)
            {
                IfExits(element, node.LeftTree);
            }
            if (element.CompareTo(node.Nodedata) > 0)
            {
                IfExits(element, node.RightTree);
            }
            return result;
        }
    }
} 