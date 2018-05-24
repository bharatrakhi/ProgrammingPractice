using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class TBinaryTreeOperations
    {
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
    }
}
