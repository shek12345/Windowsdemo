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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
        //single operation//
        private void btncreatefolder_Click(object sender, EventArgs e)
        {
            string path = "C:\\batch";
            if (Directory.Exists(path))
            {
                MessageBox.Show("folder is already exixts");
            }
            else
            {
                Directory.CreateDirectory(path);
                MessageBox.Show("folder is created");

            }

        }

        private void btncreatefile_Click(object sender, EventArgs e)
        {
            string path = "C:\\batch\\batch1";
            if(File.Exists(path))
            {
                MessageBox.Show("file already exixts");
            }
            else
            {
                File.Create(path);
                MessageBox.Show("file is created");
            }
        }
      //  multiple operation//
        private void button4_Click(object sender, EventArgs e)
        {
            string path = "C:\\batch2";
            DirectoryInfo di = new DirectoryInfo(path);
            if (di.Exists)
            {
                MessageBox.Show("folder is already exixts");
            }
            else
            {
                di.Create();
                MessageBox.Show("folder is created");
            }

        }

        private void btncreatefolder1_Click(object sender, EventArgs e)
        {
            string path = "C:\\batch2\\batch23";
            FileInfo fi = new FileInfo(path);
            if(fi.Exists)
            {
                MessageBox.Show("file is alredy exixts");
            }
            else
            {
                fi.Create();
                MessageBox.Show("file is created");

            }

        }

        private void btnwrite_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("C:\\batch2\\batch23", FileMode.Open, FileAccess.Read);
            BinaryWriter bw = new BinaryWriter(fs);
            
             

        }
    }
}
