using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            TBinaryTreeOperations objOps = new TBinaryTreeOperations();

            //1. Create a Binary Search Tree
            TBinaryTree root = null;

            root= objOps.NodeInsert(root, 8); //Root node

            root = objOps.NodeInsert(root, 10);
            root = objOps.NodeInsert(root, 6);
            root = objOps.NodeInsert(root, 5);
            root = objOps.NodeInsert(root, 4);
            root = objOps.NodeInsert(root, 7);
            root = objOps.NodeInsert(root, 12);
            root = objOps.NodeInsert(root, 14);
            root = objOps.NodeInsert(root, 9);


            //2. Count the nodes

            //3. Search in BST

            //4. Remove

            //5. IsBalance 

            //6. FindDepth

        }
    }
}
