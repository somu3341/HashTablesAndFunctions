using System;
namespace HashTablesAndFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            //HashMapNode<string, string> hashMapNode = new HashMapNode<string, string>(4);
            //hashMapNode.Add("0", "a");
            // hashMapNode.Add("1", "b");
            //  hashMapNode.Add("2", "c");
            // hashMapNode.Add("3", "d");
            // hashMapNode.Display();
            BinarySearchTree<int> binarySearchTree = new BinarySearchTree<int>(56);
            binarySearchTree.Insert(30);
            binarySearchTree.Insert(70);
            binarySearchTree.Insert(22);
            binarySearchTree.Insert(40);
            binarySearchTree.Insert(60);
            binarySearchTree.Insert(95);
            binarySearchTree.Insert(11);
            binarySearchTree.Insert(65);
            binarySearchTree.Insert(3);
            binarySearchTree.Insert(63);
            binarySearchTree.Insert(67);
            binarySearchTree.Display();
            binarySearchTree.GetSize();
            bool result = binarySearchTree.IfExits(67, binarySearchTree);
            Console.WriteLine(result);


        }
    }
}