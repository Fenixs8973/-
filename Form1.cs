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
            encryption.FirstKey = Convert.ToInt32(TextBoxFirstkey.Text);
            encryption.SecondKey = Convert.ToInt32(TextBoxFSecondkey.Text);

            encryption.Rut();
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
            encryption.FirstKey = Convert.ToInt32(TextBoxFirstkey.Text);
            encryption.SecondKey = Convert.ToInt32(TextBoxFSecondkey.Text);

            encryption.Rut();
            
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
