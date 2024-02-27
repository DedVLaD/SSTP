using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MySql.Data.Types;
using System.Windows.Forms;
using System.Security.Cryptography.X509Certificates;
using MySql.Data.MySqlClient;


namespace Business_System_BAIKAL.BD
{
    internal class DBconnection
    {

        static string DBconnect = @"server=localhost; user=root; password=root; database=BS_BAIKAL";
        static public MySqlDataAdapter msDataAdapter;
        static MySqlConnection myConnect;
        static public MySqlCommand msCommand;

        public static bool ConnectionDB()
        {
            try
            {
                myConnect = new MySqlConnection(DBconnect);
                myConnect.Open();
                msCommand = new MySqlCommand();
                msCommand.Connection = myConnect;
                msDataAdapter = new MySqlDataAdapter(msCommand);
                return true;
            }
            catch
            {
                MessageBox.Show("Ошибка соединения с базой данных!", "Нет соединения!",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        public static void CloseDB()
        {
            myConnect.Close();
        }

        public MySqlConnection GetConnection()
        {
            return myConnect;
        }
    }
}
