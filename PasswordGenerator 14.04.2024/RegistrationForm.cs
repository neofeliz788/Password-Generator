using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PasswordGenerator_14._04._2024
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

    
        private void RegistrationButton_Click(object sender, EventArgs e)
        {   
            string login = LoginBox.Text;
            if (login == "" || login.Contains(" "))
            {
                MessageBox.Show("Неверный формат логина!");
            }
           
            else
            {   
                this.Hide();
                File.AppendAllText("users.txt", login);
                
                Form1 form1 = new Form1();
                form1.Show();
                
            }
           
          
        }



    }
}
