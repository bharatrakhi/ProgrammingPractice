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
            //int cnt = objOps.CountBSTNodes(root);


            //3. Search in BST
            //bool isFound = objOps.LookupBST(root, 0);


            //4. Remove/Delete a node
            //TBinaryTree newroot = objOps.DeleteFromBST(root, 5);

            //5. isBST : Return true if a binary tree is a Binary Search Tree
            bool IsBST = 


            //6. FindDepth

            //7. MaxDepth

            //8. MinValue
            TBinaryTree Min = objOps.FindMin(root);

            //9. PrintTree

            //10. Print PostOrder

            //11. hasPathSum

            //12. PrintPath

            //13. Mirror

            //14. DoubleTree

            //15. SameTree

            //16. CountTrees

            //17. 

        }
    }
}
