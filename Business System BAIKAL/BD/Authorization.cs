using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;
using System.Collections;
using MySql.Data.MySqlClient;
using System.Data.Common;

namespace Business_System_BAIKAL.BD
{
    
    internal class Authorization
    {
        static public string position, us_lname, us_fname, us_otch, user;

        static public void AuthorizationUser(string login, string password)
        {
            try
            {
                DBconnection.msCommand.CommandText = @"SELECT title_position FROM positions,
                    authorization_users WHERE login = '" + login + "' and password = '" + password +
                    "'and authorization_users.id_position = positions.id_position";
                Object result = DBconnection.msCommand.ExecuteScalar();
                if (result != null)
                {
                    position = result.ToString();
                    user = login;
                    
                }
                else
                {
                    user = null;
                    position = null;

                }
            }
            catch
            {
                position = null;
                user = null;
                MessageBox.Show("Ошибка при авторизации!", "Проверьте данные и попробуйте снова!",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
            }
        }

        static public string AuthorizationFIO(string login)
        {
            try
            {
                login = FormAuthorization.loginActive;

                DBconnection.msCommand.CommandText = @"SELECT us_lname, us_fname, us_otch, login FROM users, 
                                                        authorization_users WHERE login = @login and authorization_users.id_user = 
                                                        users.id_user";               
                DBconnection.msCommand.Parameters.AddWithValue("@login", login);

                using (MySqlDataReader reader = DBconnection.msCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        us_lname = reader["us_lname"].ToString();
                        us_fname = reader["us_fname"].ToString();
                        us_otch = reader["us_otch"].ToString();
                    }
                }
                // Возвращаем строку, содержащую ФИО пользователя
                return $"{us_lname} {us_fname} {us_otch}";
            }
            catch
            {
                return null;
            }
        }
    }
}
