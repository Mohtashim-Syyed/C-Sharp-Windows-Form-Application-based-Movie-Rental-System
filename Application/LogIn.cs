using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
      
    class LogIn
    {
        Form4 f4 = new Form4();
        string[] arr;
        int count = 0;
        StreamReader sr = new StreamReader("register.txt");
        string line = string.Empty;
       
       

        public void log(TextBox U_Name , TextBox U_Pass)
        {
            
           
            while (count<1)
            {
               line = sr.ReadLine();
                if (line!=null)
                {
                     arr=line.Split(',');
                     if (arr[0]==U_Name.Text && arr[2]==U_Pass.Text)
                     {
                         MessageBox.Show("LOGIN SUCCESSFUL");

                         break;
                      
                     }
                   
                }
                else
                {
                    MessageBox.Show("IN VALID USER ");
                    count++;
                    sr.Close();
                }
            }
        }

    }
}
