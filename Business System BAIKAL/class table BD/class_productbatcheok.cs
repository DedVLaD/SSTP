using Business_System_BAIKAL.BD;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Business_System_BAIKAL.class_table_BD
{
    internal class class_productbatcheok : DBconnection
    {
        static public DataTable dtProductBatchEOK = new DataTable();
        static public DataTable dtStatisticProductBatchEOK = new DataTable();

        static public void GetProductBatchEOK()
        {
            try
            {
                msCommand.CommandText = "SELECT * FROM productbatcheok";
                dtProductBatchEOK.Clear();
                msDataAdapter.SelectCommand = msCommand;
                msDataAdapter.Fill(dtProductBatchEOK);
            }
            catch
            {
                MessageBox.Show("Ошибка при получении данных!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        static public void StatisticProductBatchEOK()
        {
            try
            {
                msCommand.CommandText = "SELECT id_productBatchEOK, end_production_date_EOK, acid_number_EOK FROM productbatcheok";
                dtStatisticProductBatchEOK.Clear();
                msDataAdapter.SelectCommand = msCommand;
                msDataAdapter.Fill(dtStatisticProductBatchEOK);
            }
            catch
            {
                MessageBox.Show("Ошибка при получении данных!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        static public bool AddProductBatchEOK(int id_productBatchGP_EOK, string begin_production_date_EOK, string end_production_date_EOK, string acid_number_EOK, string comment_EOK)
        {
            try
            {
                msCommand.CommandText = "INSERT INTO `bs_baikal`.`productbatcheok` (`id_productBatchGP_EOK`, `begin_production_date_EOK`, `end_production_date_EOK`, `acid_number_EOK`, `comment_EOK`) VALUES ('" + id_productBatchGP_EOK + "', '" + begin_production_date_EOK + "',  '" + end_production_date_EOK + "',  '" + acid_number_EOK + "',  '" + comment_EOK + "'); ";
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

        static public bool EditProductBatchEOK(int id_productBatchEOK, int id_productBatchGP_EOK, string begin_production_date_EOK, string end_production_date_EOK, string acid_number_EOK, string comment_EOK)
        {
            try
            {
                msCommand.CommandText = "UPDATE productbatcheok SET id_productBatchGP_EOK = '" + id_productBatchGP_EOK + "', begin_production_date_EOK = '" +
                                        begin_production_date_EOK + "', end_production_date_EOK = '" + end_production_date_EOK + "', " +
                                        "acid_number_EOK = '" + acid_number_EOK + "', comment_EOK = '" + comment_EOK + "' " +
                                        "WHERE id_productBatchEOK = '" + id_productBatchEOK + "'; ";
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

        static public void DeleteProductBatchEOK(string del)
        {
            try
            {
                msCommand.CommandText = "DELETE FROM productbatcheok WHERE id_productBatchEOK = '" + del + "'; ";
                msCommand.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Ошибка при удалении записи!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
