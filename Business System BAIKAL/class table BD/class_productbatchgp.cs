using Business_System_BAIKAL.BD;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;

namespace Business_System_BAIKAL.class_table_BD
{
    internal class class_productbatchgp : DBconnection
    {
        static public DataTable dtProductBatchGP = new DataTable();
        static public DataTable dtStatisticProductBatchGP = new DataTable();
        

        static public void GetProductBatchGP()
        {
            try
            {
                msCommand.CommandText = "SELECT * FROM productbatchgp";
                dtProductBatchGP.Clear();
                msDataAdapter.SelectCommand = msCommand;
                msDataAdapter.Fill(dtProductBatchGP);
            }
            catch
            {
                MessageBox.Show("Ошибка при получении данных!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        static public void StatisticProductBatchGP()
        {
            try
            {
                msCommand.CommandText = "SELECT id_productBatchGP, end_production_date, viscosity, electrical_capacity FROM productbatchgp";
                dtStatisticProductBatchGP.Clear();
                msDataAdapter.SelectCommand = msCommand;
                msDataAdapter.Fill(dtStatisticProductBatchGP);
            }
            catch
            {
                MessageBox.Show("Ошибка при получении данных!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        static public bool AddProductBatchGP(int id_composition_order, string begin_production_date, string end_production_date, string viscosity, string electrical_capacity)
        {
            try
            {
                msCommand.CommandText = "INSERT INTO `bs_baikal`.`productbatchgp` (`id_composition_order`, `begin_production_date`, `end_production_date`, `viscosity`, `electrical_capacity`) VALUES ('" + id_composition_order + "', '" + begin_production_date + "', '" + end_production_date + "', '" + viscosity + "', '" + electrical_capacity + "'); ";
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

        static public bool EditProductBatchGP(int id_productBatchGP, int id_composition_order, string begin_production_date, string end_production_date, string viscosity, string electrical_capacity)
        {
            try
            {
                msCommand.CommandText = "UPDATE productbatchgp SET id_composition_order = '" + id_composition_order + "', begin_production_date = '" +
                                        begin_production_date + "', end_production_date = '" + end_production_date + "', " +
                                        "viscosity = '" + viscosity + "', electrical_capacity = '" + electrical_capacity + "' " +
                                        "WHERE id_productBatchGP = '" + id_productBatchGP + "'; ";
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

        static public void DeleteProductBatchGP(string del)
        {
            try
            {
                msCommand.CommandText = "DELETE FROM productbatchgp WHERE id_productBatchGP = '" + del + "'; ";
                msCommand.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Ошибка при удалении записи!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
