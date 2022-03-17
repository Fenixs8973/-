using MySql.Data.MySqlClient;
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
        public static string user = "Default";
        
        public Form1()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)//Шифровка
        {
            string operation = "encryption";
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
            Sendingdata(operation);
            encryption.EndText = null;
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
            string operation = "decryption";
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

            Sendingdata(operation);
            encryption.EndText = null;
            
        }
        void Sendingdata(string operation)
        {
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("INSERT INTO text (user, operation, opentext, closedtext, firstKey, secondKey) VALUES (@user, @oper, @OT, @CT, @fK, @sK);", db.getConnection());//@UL, @UP - заглушки для безопасности
            command.Parameters.Add("@user", MySqlDbType.VarChar).Value = Form1.user;//Присвоение значения заглушке
            command.Parameters.Add("@oper", MySqlDbType.VarChar).Value = operation;
            command.Parameters.Add("@OT", MySqlDbType.Text).Value = EnteredTextBox.Text;
            command.Parameters.Add("@CT", MySqlDbType.Text).Value = encryption.EndText;
            command.Parameters.Add("@fK", MySqlDbType.Text).Value = TextBoxFirstkey.Text;
            command.Parameters.Add("@sK", MySqlDbType.Text).Value = TextBoxSecondkey.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);
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

        private void CreateDB_Click(object sender, EventArgs e)
        {

        }

        private void CreateTables_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command1 = new MySqlCommand("CREATE TABLE users (id INT NOT NULL AUTO_INCREMENT, login VARCHAR(30) NOT NULL, pass VARCHAR(40) NOT NULL, PRIMARY KEY(id, login));", db.getConnection());
            adapter.SelectCommand = command1;
            adapter.Fill(table);
            MySqlCommand command2 = new MySqlCommand("CREATE TABLE text (User VARCHAR(30) NOT NULL, Operation VARCHAR(10), OpenText TEXT, ClosedText TEXT, FirstKey INT, SecondKey INT);", db.getConnection());
            adapter.SelectCommand = command2;
            adapter.Fill(table);
        }
    }

}
