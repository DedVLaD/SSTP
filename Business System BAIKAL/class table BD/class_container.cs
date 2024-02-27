using Business_System_BAIKAL.BD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Business_System_BAIKAL.class_Child_form
{
    internal class class_container : DBconnection
    {
        static public DataTable dtContainer = new DataTable();

        static public void GetContainer()
        {
            try
            {
                msCommand.CommandText = "SELECT * FROM container";
                dtContainer.Clear();
                msDataAdapter.SelectCommand = msCommand;
                msDataAdapter.Fill(dtContainer);
            }
            catch
            {
                MessageBox.Show("Ошибка при получении данных!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        static public bool AddContainer(string title_container)
        {
            try
            {
                msCommand.CommandText = "INSERT INTO `bs_baikal`.`container` (`title_container`) VALUES('" + title_container + "'); ";
                if (msCommand.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                MessageBox.Show("Ошибка при добавлении записи!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        static public bool EditContainer(int id_container, string title_container)
        {
            try
            {
                msCommand.CommandText = "UPDATE container SET title_container = '" + title_container + "' WHERE id_container = '" + id_container + "'; ";
                if (msCommand.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                MessageBox.Show("Ошибка при редактировании записи!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        static public void DeleteContainer(string del)
        {
            try
            {
                msCommand.CommandText = "DELETE FROM container WHERE id_container = '" + del + "'; ";
                msCommand.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Ошибка при удалении записи!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
