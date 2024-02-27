using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business_System_BAIKAL.BD;

namespace Business_System_BAIKAL.class_table_BD
{
    internal class class_compositionorder : DBconnection
    {
        static public DataTable dtCompositiOnorder = new DataTable();

        static public void GetCompositiOnorder()
        {
            try
            {
                msCommand.CommandText = "SELECT * FROM compositionOrder";
                dtCompositiOnorder.Clear();
                msDataAdapter.SelectCommand = msCommand;
                msDataAdapter.Fill(dtCompositiOnorder);
            }
            catch
            {
                MessageBox.Show("Ошибка при получении данных!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        static public bool AddCompositionOrder(int id_composition_order, string composition_order, string passport, string weight_kg)
        {
            try
            {
                msCommand.CommandText = "INSERT INTO `bs_baikal`.`compositionorder` (`id_composition_order`, `composition_order`, `passport`, `weight_kg`) VALUES ('"+ id_composition_order + "', '"+ composition_order +"', '"+ passport +"', '"+ weight_kg +"'); ";
                
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

        static public bool EditCompositiOnorder(int id_composition_order, string composition_order, string passport, string weight_kg)
        {
            try
            {
                msCommand.CommandText = "UPDATE compositionorder SET composition_order = '" + composition_order + "', passport = '" +
                                        passport + "', weight_kg = '" + weight_kg + "' WHERE id_composition_order = '" + id_composition_order + "'; ";
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

        static public void DeleteCompositiOnorder(string del)
        {
            try
            {
                msCommand.CommandText = "DELETE FROM compositionorder WHERE id_composition_order = '" + del + "'; ";
                msCommand.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Ошибка при удалении записи!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
