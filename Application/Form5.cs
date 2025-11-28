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

namespace WindowsFormsApplication1
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
			//StreamReader sr = new StreamReader(@"movies-list.txt", true);
			//if (comboBox1.SelectedIndex == 0)
			//{

			//    string line;
			//    while ((line = sr.ReadLine()) != null)
			//    {
			//        listBox1.Items.Add(line);
			//    }

			//}

			//else if (comboBox1.SelectedIndex == 1)
			//{
			//    textBox1.Text = "AVENGERS";
			//    textBox2.Text = "3D";
			//    textBox3.Text = "900";
			//}
			bollywood bw = new bollywood();
			bw.bollywoods_movieinfo(comboBox1, listBox1);



			{
          
           }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            movie movie = new bollywood();
            movie.bollywoods(comboBox1, listBox1);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Form3 f = new Form3(comboBox1.SelectedItem.ToString());
            //f.Show();
        //can put label also in form 1 to show the value got from form2

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form6 f = new Form6(comboBox1.SelectedItem.ToString());
            f.Show();
            this.Hide();
        }
    }
    }
