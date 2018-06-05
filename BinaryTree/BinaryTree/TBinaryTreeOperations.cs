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
        public TBinaryTree DeleteFromBST(TBinaryTree root, int target)
        {
            if (root == null)
                return null;
            else if (target < root.data) root.left = DeleteFromBST(root.left, target);
            else if (target > root.data) root.right = DeleteFromBST(root.right, target);
            else //Found the node
            {
                //Case 1. No left and right
                if (root.left == null && root.right == null)
                    root = null;
                //case 2. Either left is null (one child)
                else if (root.left == null)
                {
                    TBinaryTree temp = root;
                    temp.data = root.right.data;
                    temp = root.right;
                    temp= null;
                }
                else if (root.right == null)
                {
                    TBinaryTree temp = root;
                    temp.data = root.left.data;
                    temp = root.left;
                    temp = null;
                }
                //Case 3 : Both L & R not null
                else 
                {
                    TBinaryTree temp = FindMin(root);
                    root.data = temp.data;
                    root.right = DeleteFromBST(root.right, temp.data);
                }

            }

            return root;
        }

        public bool IsBST(TBinaryTree root)
        {
            if (root == null) return true;

            if (root.left != null && FindMinVal(root.left) > root.data)
                return false;

            if (root.right!= null && FindMaxVal(root.right) < root.data)
                return false;


            return true;
        }

        private int FindMinVal(TBinaryTree root)
        {
            if (root == null)
                return 0;

            while (root.left != null)
            {
                root = root.left;
            }
            return root.data;

        }

        private int FindMaxVal(TBinaryTree root)
        {
            if (root == null)
                return 0;

            while (root.right != null)
            {
                root = root.right;
            }
            return root.data;

        }


        public TBinaryTree FindMin(TBinaryTree root)
        {
            if (root == null)
                return root;
           
            while(root.left !=null)
            {
                root = root.left;
            }
            return root;

        }
    }
}
