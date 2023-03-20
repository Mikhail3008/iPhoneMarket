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
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            iPhones = new List<iPhone>();

        }

        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        
        public List<iPhone> iPhones { get; set; }
        public void button1_Click(object sender, EventArgs e)
        {
            try
            {
                iPhones.Add(new iPhone(Convert.ToString(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToString(textBox3.Text), Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox5.Text), Convert.ToInt32(label6.Text)));
                dataGridView1.DataSource = iPhones.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            
        }

        private void label6_Click(object sender, EventArgs e)
        {
            try
            {
                label6.Text = Convert.ToString(Convert.ToDouble(textBox5.Text) - Convert.ToDouble(textBox4.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = iPhones.Where(любое_имя => любое_имя.imei == Convert.ToInt32(textBox6.Text)).ToList();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                dataGridView1.DataSource = iPhones.Where(любое_имя => любое_имя.summ_sk >= 15000).ToList();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormServis frm2= new FormServis();
            frm2.Show();
            this.Hide();
        }
    }
}
