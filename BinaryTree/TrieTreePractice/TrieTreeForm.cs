using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrieTreePractice
{
    public partial class TrieTreeForm : Form
    {
        public Trie objTrie;
        public TrieTreeForm()
        {
            InitializeComponent();
            objTrie = new Trie();
        }

      
        private void btnInsert_Click(object sender, EventArgs e)
        {
            
             if (txtInput.Text.Trim().Length == 0)
            {
                MessageBox.Show("Enter some value");
                return;
            }
            objTrie.insert(txtInput.Text);
            
            

        }

        private void TrieTreeForm_Load(object sender, EventArgs e)
        {
            objTrie.insert("Bharat");
            objTrie.insert("Baba");
            objTrie.insert("Patil");
            objTrie.insert("India");
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            if (txtInput.Text.Trim().Length == 0)
                return;

            lstResult.DataSource = objTrie.search(txtInput.Text);
            lstResult.Visible = true;
        }
    }
}
