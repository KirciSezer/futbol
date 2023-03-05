using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace formsql2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kadı = Convert.ToString(textBox1.Text);
            string sifre = Convert.ToString(textBox2.Text);
            MessageBox.Show("Kaydınız Başarıyla OLuşturuldu");
            listBox1.Items.Add("Kullanıcı adınız :" + textBox1.Text);
            listBox1.Items.Add("Şifre :" + textBox2.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void devamEtToolStripMenuItem_Click(object sender, EventArgs e)
        {
        
        }

        private void takımİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 git = new Form2();
            git.Show();
            this.Hide();
        }
    }
}
