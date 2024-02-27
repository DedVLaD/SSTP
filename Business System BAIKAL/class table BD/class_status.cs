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
    internal class class_status : DBconnection
    {
        static public DataTable dtStatus = new DataTable();
        static public void GetStatus()
        {
            try
            {
                msCommand.CommandText = "SELECT * FROM status";
                dtStatus.Clear();
                msDataAdapter.SelectCommand = msCommand;
                msDataAdapter.Fill(dtStatus);
            }
            catch
            {
                MessageBox.Show("Ошибка при получении данных!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        static public bool AddStatus(string title_status)
        {
            try
            {
                msCommand.CommandText = "INSERT INTO `bs_baikal`.`status` (`title_status`) VALUES('" + title_status + "'); ";
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

        static public bool EditStatus(int id_status, string title_status)
        {
            try
            {
                msCommand.CommandText = "UPDATE status SET title_status = '" + title_status + "' WHERE id_status = '" + id_status + "'; ";
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

        static public void DeleteStatus(string del)
        {
            try
            {
                msCommand.CommandText = "DELETE FROM status WHERE id_status = '" + del + "'; ";
                msCommand.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Ошибка при удалении записи!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
