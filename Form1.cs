using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recursiva
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void myTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //System.Console.WriteLine(e.Node.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TreeNodeCollection nodes = this.myTreeView.Nodes;
            foreach (TreeNode n in nodes) {
                ManageNodeRecursive(n, "");
                if (n.Checked) { MessageBox.Show("Path: " +  @"\" + n.Text); }
            }

        }



        private void ManageNodeRecursive(TreeNode mNode,  string mPath)  {
            mPath += @"\" + mNode.Text;
            string mFolder = null;
            
            foreach (TreeNode tn in  mNode.Nodes)  {
                ManageNodeRecursive(tn, mPath);
                if (tn.Checked) { MessageBox.Show("Path: " + mPath + @"\" + tn.Text); }
            }

                System.Console.WriteLine("Path: " + mPath + @"\" + mFolder);

        }

        private void myTreeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            //ManageNodeRecursive(e.Node, "SELECT", e.Node.Checked,"");
        }
    }
}
