using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{

    //Binary Tree Schema declaration 
    class TBinaryTree 
    {

        public int data { get; set; }

        public TBinaryTree left, right;

        public TBinaryTree(int data)
        {
            this.data = data;
        }
    }


}
