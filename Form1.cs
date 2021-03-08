using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_2_repaso
{
    public partial class Form1 : Form
    {
        private Form2 fr2;
        private Form3 fr3;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void windowsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void showWindow1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fr2 == null)
            {
                fr2 = new Form2();
                fr2.MdiParent = this;
                fr2.Show();
            }
            else
            {
                fr2.Activate();
            }
        }

        private void showWindow2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(fr3 == null)
            {
                fr3 = new Form3();
                fr3.MdiParent = this;
                fr3.Show();
            }
            else
            {
                fr3.Activate();
            }
        }
    }
}
