using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace TrieTreePractice
{
    public class Trie
    {
        private class TrieNode
        {
            public Dictionary <char, TrieNode> children;
            bool endOfWord;
            public TrieNode()
            {
                children = new Dictionary<char, TrieNode>();
                endOfWord = false;
            }
        }   //* end of private class TrieNode

        private TrieNode root;
        public Trie()
        {
            root = new TrieNode();
        }

        /*
            Iterative implementation of insert into Trie 
        */

        public void insert(string word)
        {
            TrieNode current = root;
            for (int i=0;i<word.Length;i++)
            {
                char ch = word[i];
                TrieNode node = current.children[ch];
                if (node==null)
                {
                    node = new TrieNode();
                    current.children.Add(ch, node);
                }
                current = node;
             }
        }


    } //*end of public class Trie
}
