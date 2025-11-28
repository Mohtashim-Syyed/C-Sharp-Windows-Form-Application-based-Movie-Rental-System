//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;
//using System.IO;

//namespace WindowsFormsApplication1
//{
//    class holly:movies
//    {

//        public override void bollywoods(System.Windows.Forms.ComboBox movie)
//        {
//            throw new NotImplementedException();
//        }

//        public override void hollywood(System.Windows.Forms.ComboBox movie1)
//        {
//            StreamReader sr = new StreamReader(@"holly.txt", true);
//            string x = sr.ReadToEnd();
//            string[] y = x.Split('\n');

//            foreach (string s in y)
//            {
//                movie1.Items.Add(s);
//            }
//            //StreamReader sa = new StreamReader(@"movies-list.txt", true);
//            //if (movie1.SelectedIndex == 0)
//            //{

//            //    string line;
//            //    while ((line = sa.ReadLine()) != null)
//            //    {
//            //        list.Items.Add(line);
//            //    }

//            //}

//            //else if (moviess.SelectedIndex == 1)
//            //{
//                //textBox1.Text = "AVENGERS";
//                //textBox2.Text = "3D";
//                //textBox3.Text = "900";
//            }
//        }

//        //public override void lollywood()
//        //{
//        //    throw new NotImplementedException();
//        //}
//    }

