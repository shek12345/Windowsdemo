using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Windowsdemo
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
              DialogResult result  =  fd. ShowDialog();
            if(DialogResult.OK==result)
            {
                richTextBox1.SelectionFont = fd.Font;
            }
        }

        private void colourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            DialogResult result = cd.ShowDialog();
            if (DialogResult.OK == result)
            {
                richTextBox1.SelectionColor = cd.Color;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
          DialogResult result=
                MessageBox.Show("Do you want to Exit?", "Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if(DialogResult.Yes==result)
            {
                Application.Exit();
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog od = new OpenFileDialog();
            od.Filter="Text doc(.txt)|*.txt|Word Doc(.docx)|*|All Files|*.*";
            DialogResult result = od.ShowDialog();
            if(result==DialogResult.OK)
            {
                StreamReader sr = new StreamReader(od.FileName);
                richTextBox1.Text = sr.ReadToEnd();
                sr.Close();

               
            }

        }
    }
}
