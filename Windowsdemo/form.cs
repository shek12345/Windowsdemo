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
    public partial class form : Form
    {
        public form()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnread_Click(object sender, EventArgs e)
        {
            try
            {


                FileStream fs = new FileStream("D:", FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                int id = Convert.ToInt32(textBox1.Text);
                string name = textBox2.Text;
                int fees = Convert.ToInt32(textBox3.Text);
                br.ReadInt32();
                br.ReadString();
                br.ReadInt32();
                br.Close();
                fs.Close();
                MessageBox.Show("Done");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lable1_Click(object sender, EventArgs e)
        {

        }

        private void form_Load(object sender, EventArgs e)
        {

        }

        private void btnwrite_Click(object sender, EventArgs e)
           
        {
            try
            {


                FileStream fs = new FileStream("D:", FileMode.Create, FileAccess.Write);
                BinaryWriter bw = new BinaryWriter(fs);
                int id = Convert.ToInt32(textBox1.Text);
                string name = textBox2.Text;
                int fees = Convert.ToInt32(textBox3.Text);
                bw.Write(id);
                bw.Write(name);
                bw.Write(fees);
                bw.Close();
                fs.Close();
                MessageBox.Show("Done");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
