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
    internal class class_label : DBconnection
    {
        static public DataTable dtLabel = new DataTable();

        static public void GetLabel()
        {
            try
            {
                msCommand.CommandText = "SELECT * FROM labels";
                dtLabel.Clear();
                msDataAdapter.SelectCommand = msCommand;
                msDataAdapter.Fill(dtLabel);
            }
            catch
            {
                MessageBox.Show("Ошибка при получении данных!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        static public bool AddLabel(string title_label)
        {
            try
            {
                msCommand.CommandText = "INSERT INTO `bs_baikal`.`labels` (`title_label`) VALUES('" + title_label + "'); ";
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

        static public bool EditLabel(int id_label, string title_label)
        {
            try
            {
                msCommand.CommandText = "UPDATE labels SET title_label = '" + title_label + "' WHERE id_label = '" + id_label + "'; ";
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

        static public void DeleteLabel(string del)
        {
            try
            {
                msCommand.CommandText = "DELETE FROM labels WHERE id_label = '" + del + "'; ";
                msCommand.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Ошибка при удалении записи!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
