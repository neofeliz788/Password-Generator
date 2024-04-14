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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PasswordGenerator_14._04._2024
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        Point point;
        
        public static string GeneratePassword(int length, bool includeSimilarChars, bool includeNonAlphaNumericChars)
        {
            Random random = new Random();
            const string chars = "ABCDEFGHJKLMNPRSTUVWXYZabcdefghijkmnpqrstuvwxyz0123456789!@#$%^&*_-+=?";
            const string similarChars = "il1Lo0O";
            const string nonAlphaNumericChars = "{}[]()/\\'\"`~,;:.<>!@#$%&";
            string usableChars = chars;

            if (!includeSimilarChars)
            {
                foreach (char similarChar in similarChars)
                {
                    usableChars = usableChars.Replace(similarChar.ToString(), string.Empty);
                }
            }

            if (!includeNonAlphaNumericChars)
            {
                usableChars += nonAlphaNumericChars;
            }

            StringBuilder password = new StringBuilder();

            for (int i = 0; i < length; i++)
            {
                password.Append(usableChars[random.Next(usableChars.Length)]);
            }


            string filePath = "rockyou.txt";
            if (File.Exists(filePath))
            {
                foreach (string line in File.ReadLines(filePath))
                {
                    if (string.Equals(line, password))
                    {
                        return "";
                    }
                }
            }
            return password.ToString();
        }
        public static string GeneratePassword(int length, string login)
        {
            Random random = new Random();
            const string chars = "ABCDEFGHJKLMNPRSTUVWXYZabcdefghijkmnpqrstuvwxyz0123456789!@#$%^&*_-+=?";
            const string similarChars = "il1Lo0O";
            const string nonAlphaNumericChars = "{}[]()/\\'\"`~,;:.<>!@#$%&";
            string usableChars = chars;

      

            StringBuilder password = new StringBuilder();

            for (int i = 0; i < length; i++)
            {
                password.Append(usableChars[random.Next(usableChars.Length)]);
            }


            string filePath = "rockyou.txt";
            if (File.Exists(filePath))
            {
                foreach (string line in File.ReadLines(filePath))
                {
                    if (string.Equals(line, password))
                    {
                        return "";
                    }
                }
            }
            return password.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int lenght = 0;
            string password = "";
            if (comboLength.SelectedItem != null)
            {
                lenght = int.Parse(comboLength.SelectedItem.ToString());
                buttonChoose.Visible = true;
            }
            else
            {   
                password = "";
                MessageBox.Show("Введите длину пароля!");
            }

            password = GeneratePassword(lenght, checkSimilarity.Checked, checkNonLetter.Checked);
            textPassword.Text = password;
            textPassword.ForeColor = Color.Black;
            
           

        }
        private void button2_CLick(object sender, EventArgs e)
        {
            MessageBox.Show("Ваш пароль сохранен");
            File.AppendAllText("users.txt", " "+textPassword.Text+"\n");
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - point.X;
                this.Top += e.Y - point.Y;
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            point = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - point.X;
                this.Top += e.Y - point.Y;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            point = new Point(e.X, e.Y);
        }

        private void textBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - point.X;
                this.Top += e.Y - point.Y;
            }
        }

        private void textBox1_MouseDown(object sender, MouseEventArgs e)
        {
            point = new Point(e.X, e.Y);
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - point.X;
                this.Top += e.Y - point.Y;
            }
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            point = new Point(e.X, e.Y);
        }

       

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
        
    }
}
