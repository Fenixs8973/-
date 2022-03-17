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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            string loginUser = LoginBox.Text;
            string passUser = PassBox.Text;
            Form1 form = new Form1();

            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL AND `pass` = @uP", db.getConnection());//@UL, @UP - заглушки для безопасности
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;//Присвоение значения заглушке
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passUser;

            adapter.SelectCommand = command;//Указываем какую команду выполнять
            adapter.Fill(table);//Заполняем объект table полученными данными loginUser и passUser

            if (table.Rows.Count > 0)//Если колличество соответсвующих записей в table > 0, то пользователь есть
            {
                Form1.user = loginUser;
                MessageBox.Show("Успешная авторизация");
                
            }
            else
                MessageBox.Show("Логон или пароль неверны");
        }

        private void LoginBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PassBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
