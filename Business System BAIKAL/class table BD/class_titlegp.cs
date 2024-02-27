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
    internal class class_titlegp : DBconnection
    {
        static public DataTable dtTitleGP = new DataTable();

        static public void GetTitleGP()
        {
            try
            {
                msCommand.CommandText = "SELECT * FROM titlegp";
                dtTitleGP.Clear();
                msDataAdapter.SelectCommand = msCommand;
                msDataAdapter.Fill(dtTitleGP);
            }
            catch
            {
                MessageBox.Show("Ошибка при получении данных!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        static public bool AddTitleGP(string titleGP)
        {
            try
            {
                msCommand.CommandText = "INSERT INTO `bs_baikal`.`titlegp` (`titleGP`) VALUES('" + titleGP + "'); ";
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

        static public bool EditTitleGP(int id_titleGP, string titleGP)
        {
            try
            {
                msCommand.CommandText = "UPDATE titlegp SET titleGP = '" + titleGP + "' WHERE id_titleGP = '" + id_titleGP + "'; ";
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

        static public void DeleteTitleGP(string del)
        {
            try
            {
                msCommand.CommandText = "DELETE FROM titlegp WHERE id_titleGP = '" + del + "'; ";
                msCommand.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Ошибка при удалении записи!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
