using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Шифровщик
{
    internal class DB
    {
        MySqlConnection connectionsql = new MySqlConnection("server=localhost;port=3306;username=root;password=root;database=cryption");

        public void OpenConnection()
        {
            if(connectionsql.State == System.Data.ConnectionState.Closed)
                connectionsql.Open();
        }
        public void CloseConnection()
        {
            if (connectionsql.State == System.Data.ConnectionState.Open)
                connectionsql.Close();
        }
        public MySqlConnection getConnection()
        {
            return connectionsql;
        }
    }
}
