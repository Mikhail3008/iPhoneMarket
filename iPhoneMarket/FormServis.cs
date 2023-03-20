using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iPhoneMarket
{
    public partial class FormServis: Form
    {
        public FormServis()
        {
            InitializeComponent();
            zakaz = new List<Zakaz>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm=new Form1();
            frm.Show();
            this.Close();
        }

        public List<Zakaz> zakaz { get; set; }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                zakaz.Add(new Zakaz(Convert.ToString(textBox1.Text),
                           Convert.ToInt32(textBox2.Text),
                           Convert.ToString(textBox3.Text),
                           new Klient(textBox4.Text.ToString()),
                           Convert.ToString(textBox5.Text),
                           new Master(comboBox1.Text.ToString()),
                           Convert.ToString(textBox6.Text)));
                dataGridView1.DataSource = zakaz.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
