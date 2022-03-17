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
    public partial class SignUp : Form
    {

        public SignUp()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            string loginUser = LoginBox.Text;
            string passUser = null;
            if(PassBox.Text == null || PassBox2.Text == null)
            {
                MessageBox.Show("Заполните все поля паролей");
            }
            else
            {
                if (PassBox.Text == PassBox2.Text)
                    passUser = PassBox.Text;
                else
                    MessageBox.Show("Пароли не верны");
            }
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("INSERT INTO users (login, pass) VALUES (@UL, @UP);", db.getConnection());//@UL, @UP - заглушки для безопасности
            command.Parameters.Add("@UL", MySqlDbType.VarChar).Value = loginUser;//Присвоение значения заглушке
            command.Parameters.Add("@UP", MySqlDbType.VarChar).Value = passUser;

            adapter.SelectCommand = command;//Указываем какую команду выполнять
            adapter.Fill(table);//Заполн яем объект table полученными данными loginUser и passUser
            MessageBox.Show("теперь вы можете войти");
        }

        private void LoginBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
