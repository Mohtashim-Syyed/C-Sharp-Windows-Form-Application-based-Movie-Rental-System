using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form6 : Form
    {
        private string selected;
        public Form6(string result = "")
        {
            InitializeComponent();
            selected = result;
            textBox4.Text = "You Have Selected:" + " " + selected;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {


        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (email.Text == "" || cinema.SelectedIndex == -1 || showtime.SelectedIndex == -1 || seat.SelectedIndex == -1)
            {
                MessageBox.Show("Please Fill All Fields!");

            }
            else
            {

                MessageBox.Show("Ticket Booked Successfully!");
                mainpage m = new mainpage();
                m.Show();
                this.Hide();

            }

                   
            
        }

        private void Form6_Load(object sender, EventArgs e)
        {
           
        }
    }
}
