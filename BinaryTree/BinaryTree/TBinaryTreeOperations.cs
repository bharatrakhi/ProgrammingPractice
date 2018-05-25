using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class TBinaryTreeOperations
    {
        //1. Insert a node in BST
        public TBinaryTree NodeInsert(TBinaryTree root, int data)
        {
            if (root ==null)
                root = new TBinaryTree(data);
            else if (data <= root.data)
                root.left = NodeInsert(root.left, data);
            else if (data>root.data)
                root.right = NodeInsert(root.right, data);

            return root;
        }

        //2. Count the number of Nodes
        public int CountBSTNodes(TBinaryTree root)
        {
            if (root == null)
                return 0;
            else
                return CountBSTNodes(root.left) + CountBSTNodes(root.right) + 1;
        }

        //3. Lookup 
        public bool LookupBST(TBinaryTree root, int target)
        {
            if (root == null)
                return false;
            else if (target == root.data)
                return true;
            else if (target < root.data)
                return LookupBST(root.left, target);
            else 
                return LookupBST(root.right, target);
        }

        //4. Remove a node
        public TBinaryTree RemoveFromBST(TBinaryTree root, int target)
        {
            if (root == null)
                return null;
            else if (root.data == target)

        }
    }
}
