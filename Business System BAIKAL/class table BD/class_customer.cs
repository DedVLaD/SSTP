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
    internal class class_customer : DBconnection
    {
        static public DataTable dtCustomer = new DataTable();

        static public void GetCustomer()
        {
            try
            {
                msCommand.CommandText = "SELECT * FROM customers";
                dtCustomer.Clear();
                msDataAdapter.SelectCommand = msCommand;
                msDataAdapter.Fill(dtCustomer);
            }
            catch
            {
                MessageBox.Show("Ошибка при получении данных!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        static public bool AddCustomer(string name_customer, string telephone, string adress)
        {
            try
            {
                //msCommand.CommandText = "INSERT INTO customers VALUES ('" + name_customer + "', '" + telephone + "',  '" + adress + "'); ";
                msCommand.CommandText = "INSERT INTO `bs_baikal`.`customers` (`name_customer`, `telephone`, `adress`) VALUES('" + name_customer + "', '" + telephone + "', '" + adress + "'); ";
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

        static public bool EditCustomer(int id_customer, string name_customer, string telephone, string adress)
        {
            try
            {
                msCommand.CommandText = "UPDATE customers SET name_customer = '" + name_customer + "', telephone = '" +
                                        telephone + "', adress = '" + adress + "' WHERE id_customer = '" + id_customer + "'; ";
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

        static public void DeleteCustomer(string del)
        {
            try
            {
                msCommand.CommandText = "DELETE FROM customers WHERE id_customer = '" + del + "'; ";
                msCommand.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Ошибка при удалении записи!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
