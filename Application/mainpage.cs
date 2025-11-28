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
    public partial class mainpage : Form
    {
        public mainpage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel9_Paint_(object sender, PaintEventArgs e)
        {
            
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void panel8_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

            INFORMATION inf = new INFORMATION();
            inf.Show();
            this.Hide();

            //Form5 form5 = new Form5();
            //form5.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            var raazit = new raazi_trailer();
            raazit.Show(this); // if you need non-modal window
            mainpage mp = new mainpage();
            mp.Close();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            var toht = new toh();
            toht.Show(this); // if you need non-modal window
            mainpage mp = new mainpage();
            mp.Close();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            var zerot = new zero_trailer();
            zerot.Show(this); // if you need non-modal window
            mainpage mp = new mainpage();
            mp.Close();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            mainpage mp = new mainpage();
            mp.Close();
            var racet = new race_trailer();
            racet.Show(this); // if you need non-modal window
            this.Hide();
        }
    }
}
