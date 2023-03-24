using System;
namespace HashTablesAndFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            HashMapNode<string, string> hashMapNode = new HashMapNode<string, string>(4);
            hashMapNode.Add("0", "a");
            hashMapNode.Add("1", "b");
            hashMapNode.Add("2", "c");
            hashMapNode.Add("3", "d");
            hashMapNode.Display();
        }
    }
}