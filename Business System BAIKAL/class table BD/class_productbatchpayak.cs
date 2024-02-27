using Business_System_BAIKAL.BD;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Business_System_BAIKAL.class_table_BD
{
    internal class class_productbatchpayak : DBconnection
    {
        static public DataTable dtProductBatchPAYAK = new DataTable();
        static public DataTable dtStatisticProductBatchPAYAK = new DataTable();

        static public void GetProductBatchPAYAK()
        {
            try
            {
                msCommand.CommandText = "SELECT * FROM productbatchpayak";
                dtProductBatchPAYAK.Clear();
                msDataAdapter.SelectCommand = msCommand;
                msDataAdapter.Fill(dtProductBatchPAYAK);
            }
            catch
            {
                MessageBox.Show("Ошибка при получении данных!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        static public void StatisticProductBatchPAYAK()
        {
            try
            {
                msCommand.CommandText = "SELECT id_productBatchPAYAK, end_production_date_PAYAK, acid_number_PAYAK FROM productbatchpayak";
                dtStatisticProductBatchPAYAK.Clear();
                msDataAdapter.SelectCommand = msCommand;
                msDataAdapter.Fill(dtStatisticProductBatchPAYAK);
            }
            catch
            {
                MessageBox.Show("Ошибка при получении данных!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        static public bool AddProductBatchPAYAK(int id_productBatchGP_PAYAK, string begin_production_date_PAYAK, string end_production_date_PAYAK, string acid_number_PAYAK, string comment_PAYAK)
        {
            try
            {
                msCommand.CommandText = "INSERT INTO `bs_baikal`.`productbatchpayak` (`id_productBatchGP_PAYAK`, `begin_production_date_PAYAK`, `end_production_date_PAYAK`, `acid_number_PAYAK`, `comment_PAYAK`) VALUES ('" + id_productBatchGP_PAYAK + "', '" + begin_production_date_PAYAK + "', '" + end_production_date_PAYAK + "', '" + acid_number_PAYAK + "', '" + comment_PAYAK + "'); ";
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

        static public bool EditProductBatchPAYAK(int id_productBatchPAYAK, int id_productBatchGP_PAYAK, string begin_production_date_PAYAK, string end_production_date_PAYAK, string acid_number_PAYAK, string comment_PAYAK)
        {
            try
            {
                msCommand.CommandText = "UPDATE productbatchpayak SET id_productBatchGP_PAYAK = '" + id_productBatchGP_PAYAK + "', begin_production_date_PAYAK = '" +
                                        begin_production_date_PAYAK + "', end_production_date_PAYAK = '" + end_production_date_PAYAK + "', " +
                                        "acid_number_PAYAK = '" + acid_number_PAYAK + "', comment_PAYAK = '" + comment_PAYAK + "' " +
                                        "WHERE id_productBatchPAYAK = '" + id_productBatchPAYAK + "'; ";
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

        static public void DeleteProductBatchPAYAK(string del)
        {
            try
            {
                msCommand.CommandText = "DELETE FROM productbatchpayak WHERE id_productBatchPAYAK = '" + del + "'; ";
                msCommand.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Ошибка при удалении записи!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
