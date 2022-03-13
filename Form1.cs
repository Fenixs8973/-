using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Шифровщик
{
    public partial class Form1 : Form
    {
        static Encryption encryption = new Encryption();
        public int FirstKey;
        public int SecondKey;
        static string alph = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";//алфавит
        static char[] Alphabet = alph.ToCharArray();//Заполенение массива алфвитом

        
        public Form1()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)//Шифровка
        {
            encryption.hut = 2;
            Encryption.EnteredText = EnteredTextBox.Text;
            if (TextBoxFirstkey.Text != "" && TextBoxSecondkey.Text != "")
            {
                encryption.FirstKey = Convert.ToInt32(TextBoxFirstkey.Text);
                encryption.SecondKey = Convert.ToInt32(TextBoxSecondkey.Text);
                encryption.Rut();
            }
            else
            {
                MessageBox.Show("Введите значение ключей (до 8 цифр)");
            }
        }
        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            encryption.hut = 1;
            Encryption.EnteredText = EnteredTextBox.Text;
            if (TextBoxFirstkey.Text != "" && TextBoxSecondkey.Text != "")
            {
                encryption.FirstKey = Convert.ToInt32(TextBoxFirstkey.Text);
                encryption.SecondKey = Convert.ToInt32(TextBoxSecondkey.Text);
                encryption.Rut();
            }
            else
            {
                MessageBox.Show("Введите значение ключей (до 8 цифр)");
            }
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void Registration_Click(object sender, EventArgs e)
        {

        }

        private void Login_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
        }

        private void Registration_Click_1(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.Show();
        }
    }

}
