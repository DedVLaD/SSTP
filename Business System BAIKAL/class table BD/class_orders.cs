using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Common;
using Business_System_BAIKAL.BD;
using System.Windows.Input;
using System.Windows.Forms;

namespace Business_System_BAIKAL.class_Child_form
{
    internal class class_orders : DBconnection
    {
        static public DataTable dtOrders = new DataTable();
        static public DataTable dtStatisticOrders = new DataTable();

        static public void GetOrders()
        {
            try
            {
                msCommand.CommandText = "SELECT orders.id_order, customers.name_customer, orders.data_order_formation, orders.end_date_agreement, " +
                                        "labels.title_label, titlegp.titleGP, container.title_container, location.title_location, status.title_status " +
                                        "FROM orders, customers, labels, titlegp, container, " +
                                        "location, status WHERE orders.id_customer = customers.id_customer and " +
                                        "orders.id_label = labels.id_label and orders.id_titleGP = titlegp.id_titleGP " +
                                        "and orders.id_container = container.id_container and " +
                                        "orders.id_location = location.id_location and orders.id_status = status.id_status";
                dtOrders.Clear();
                msDataAdapter.SelectCommand = msCommand;
                msDataAdapter.Fill(dtOrders);
            }
            catch
            {
                MessageBox.Show("Ошибка при получении данных!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        static public void StatisticOrders()
        {
            try
            {
                msCommand.CommandText = "SELECT orders.id_order, customers.name_customer, orders.end_date_agreement, compositionOrder.weight_kg FROM bs_baikal.orders, bs_baikal.compositionOrder, bs_baikal.customers WHERE orders.id_order = compositionOrder.id_composition_order AND customers.id_customer = orders.id_customer;";
                dtStatisticOrders.Clear();
                msDataAdapter.SelectCommand = msCommand;
                msDataAdapter.Fill(dtStatisticOrders);
            }
            catch
            {
                MessageBox.Show("Ошибка при получении данных!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        static public bool AddOrders(int id_customer, string data_order_formation, string end_date_agreement, int id_label, int id_titleGP, int id_container, int id_location, int id_status)
        {
            try
            {
                msCommand.CommandText = "INSERT INTO orders VALUES (null, '" + id_customer + "', '" + data_order_formation + "',  '" + end_date_agreement + "', '" + id_label + "', '" + id_titleGP + "', '" + id_container + "', '" + id_location + "', '" + id_status + "'); INSERT INTO bs_baikal.compositionorder (id_composition_order) SELECT id_order FROM bs_baikal.orders WHERE NOT EXISTS (SELECT * from bs_baikal.compositionorder WHERE bs_baikal.compositionorder.id_composition_order=bs_baikal.orders.id_order); ";
                
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

        static public bool EditOrders(int id_order, int id_customer, string data_order_formation, string end_date_agreement, 
                                      int id_label, int id_titleGP, int id_container, int id_location, int id_status)
        {
            try
            {
                msCommand.CommandText = "UPDATE orders SET id_customer = '" + id_customer + "', " +
                                        "data_order_formation = '" + data_order_formation + "', end_date_agreement = '" + 
                                        end_date_agreement + "', id_label = '" + id_label + "', id_titleGP = '" + id_titleGP + "', " +
                                        "id_container = '" + id_container + "', id_location = '" + id_location + "', id_status = '" + 
                                        id_status + "' WHERE id_order = '"+ id_order + "'; ";
                if(msCommand.ExecuteNonQuery() > 0)
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

        static public void DeletedOrders(string del)
        {
            try
            {
                msCommand.CommandText = "DELETE FROM orders WHERE id_order = '" + del + "'; ";
                msCommand.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Ошибка при удалении записи!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        //update orders location and status           !!!!!!!!!!!!!!!!!!!
        static public bool EditOrdersLocation1(int id_order)
        {
            try
            {
                msCommand.CommandText = "UPDATE orders SET id_location = '1' WHERE id_order = '" + id_order + "'; ";
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

        static public bool EditOrdersLocation2(int id_order)
        {
            try
            {
                msCommand.CommandText = "UPDATE orders SET id_location = '2' WHERE id_order = '" + id_order + "'; ";
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
        static public bool EditOrdersLocation3(int id_order)
        {
            try
            {
                msCommand.CommandText = "UPDATE orders SET id_location = '3' WHERE id_order = '" + id_order + "'; ";
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

        static public bool EditOrdersStatus1(int id_order)
        {
            try
            {
                msCommand.CommandText = "UPDATE orders SET id_status = '1' WHERE id_order = '" + id_order + "'; ";
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

        static public bool EditOrdersStatus2(int id_order)
        {
            try
            {
                msCommand.CommandText = "UPDATE orders SET id_status = '2' WHERE id_order = '" + id_order + "'; ";
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

        static public bool EditOrdersStatus3(int id_order)
        {
            try
            {
                msCommand.CommandText = "UPDATE orders SET id_status = '3' WHERE id_order = '" + id_order + "'; ";
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
    }
}
