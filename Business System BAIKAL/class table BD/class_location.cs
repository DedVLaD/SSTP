using Business_System_BAIKAL.BD;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Business_System_BAIKAL.class_Child_form
{
    internal class class_location : DBconnection
    {
        static public DataTable dtLocation = new DataTable();

        static public void GetLocation()
        {
            try
            {
                msCommand.CommandText = "SELECT * FROM location";
                dtLocation.Clear();
                msDataAdapter.SelectCommand = msCommand;
                msDataAdapter.Fill(dtLocation);
            }
            catch
            {
                MessageBox.Show("Ошибка при получении данных!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        static public bool AddLocation(string title_location)
        {
            try
            {
                msCommand.CommandText = "INSERT INTO `bs_baikal`.`location` (`title_location`) VALUES('" + title_location + "'); ";
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

        static public bool EditLocation(int id_location, string title_location)
        {
            try
            {
                msCommand.CommandText = "UPDATE location SET title_location = '" + title_location + "' WHERE id_location = '" + id_location + "'; ";
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

        static public void DeleteLocation(string del)
        {
            try
            {
                msCommand.CommandText = "DELETE FROM location WHERE id_location = '" + del + "'; ";
                msCommand.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Ошибка при удалении записи!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
