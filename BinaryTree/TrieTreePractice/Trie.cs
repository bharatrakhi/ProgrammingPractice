// Reference : https://github.com/mission-peace/interview/blob/master/src/com/interview/suffixprefix/Trie.java
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
            public bool endOfWord;
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
                TrieNode node ;//= current.children[ch];
                if (current.children.ContainsKey(ch))
                    node = current.children[ch];
                else
                {
                    node = new TrieNode();
                    current.children.Add(ch, node);
                }
                current = node;
             }
            current.endOfWord = true;
        }

        public List<string> search(string word)
        {
            StringBuilder builder = new StringBuilder();
            List<string> ResultList = new List<string>(); //will store results to return the values
            
            TrieNode current = root;
            for (int i=0;i<word.Length;i++)
            {
                char ch = word[i];

                if (current.children.ContainsKey(ch) )
                {
                    builder.Append(ch);
                    TrieNode node = current.children[ch];
                    while (!node.endOfWord)
                    {
                        foreach (var item in node.children)
                        {
                            builder.Append(item.Key);
                            node = node.children[item.Key];
                        }
                    }

                    ResultList.Add (builder.ToString());
                }
            }
            return ResultList;
        }


    } //*end of public class Trie
}
