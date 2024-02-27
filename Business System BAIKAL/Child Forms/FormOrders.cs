using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Business_System_BAIKAL.BD;
using Business_System_BAIKAL.class_Child_form;
using MySqlX.XDevAPI.Common;
using Business_System_BAIKAL.class_table_BD;

namespace Business_System_BAIKAL.Forms
{
    public partial class FormOrders : Form
    {
        public FormOrders()
        {
            InitializeComponent();
        }

        private void LoadComboBoxCustomer()
        {
            class_customer.GetCustomer();

            customer_cbx.DataSource = class_customer.dtCustomer;
            customer_cbx.DisplayMember = "name_customer";
            customer_cbx.ValueMember = "id_customer";
        }

        private void LoadComboBoxLabel()
        {
            class_label.GetLabel();

            label_cbx.DataSource = class_label.dtLabel;
            label_cbx.DisplayMember = "title_label";
            label_cbx.ValueMember = "id_label";
        }

        private void LoadComboBoxTitleGP()
        {
            class_titlegp.GetTitleGP();

            titleGP_cbx.DataSource = class_titlegp.dtTitleGP;
            titleGP_cbx.DisplayMember = "titleGP";
            titleGP_cbx.ValueMember = "id_titleGP";
        }

        private void LoadComboBoxContainer()
        {
            class_container.GetContainer();

            container_cbx.DataSource = class_container.dtContainer;
            container_cbx.DisplayMember = "title_container";
            container_cbx.ValueMember = "id_container";
        }

        private void LoadComboBoxLocation()
        {
            class_location.GetLocation();

            location_cbx.DataSource = class_location.dtLocation;
            location_cbx.DisplayMember = "title_location";
            location_cbx.ValueMember = "id_location";
        }

        private void LoadComboBoxStatus()
        {
            class_status.GetStatus();

            status_cbx.DataSource = class_status.dtStatus;
            status_cbx.DisplayMember = "title_status";
            status_cbx.ValueMember = "id_status";
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Text = "";
            dateTimePicker2.Text = "";
          
            LoadComboBoxCustomer();
            LoadComboBoxLabel();
            LoadComboBoxTitleGP();
            LoadComboBoxContainer();
            LoadComboBoxLocation();
            LoadComboBoxStatus();
        }

        static public string EditOrder, EditCustomer, EditDateTimePicker4, EditDateTimePicker3, EditLabel, EditTitleGP, EditContainer, EditLocation, EditStatus;

        private void iconButton6_Click(object sender, EventArgs e)
        {
            string EditNumStatus = dataGridView1.CurrentRow.Cells[0].Value.ToString();

            if (class_orders.EditOrdersStatus3(int.Parse(EditNumStatus)))
            {
                MessageBox.Show("Статус заказа успешно изменено!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                class_orders.GetOrders();
                dataGridView1.DataSource = class_orders.dtOrders;
            }
        }

        private void iconButton7_Click(object sender, EventArgs e)
        {
            string EditNumStatus = dataGridView1.CurrentRow.Cells[0].Value.ToString();

            if (class_orders.EditOrdersStatus2(int.Parse(EditNumStatus)))
            {
                MessageBox.Show("Статус заказа успешно изменено!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                class_orders.GetOrders();
                dataGridView1.DataSource = class_orders.dtOrders;
            }
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            string EditNumStatus = dataGridView1.CurrentRow.Cells[0].Value.ToString();

            if (class_orders.EditOrdersStatus1(int.Parse(EditNumStatus)))
            {
                MessageBox.Show("Статус заказа успешно изменено!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                class_orders.GetOrders();
                dataGridView1.DataSource = class_orders.dtOrders;
            }
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            string EditNumLocation = dataGridView1.CurrentRow.Cells[0].Value.ToString();

            if (class_orders.EditOrdersLocation3(int.Parse(EditNumLocation)))
            {
                MessageBox.Show("Местоположение заказа успешно изменено!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                class_orders.GetOrders();
                dataGridView1.DataSource = class_orders.dtOrders;
            }
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            string EditNumLocation = dataGridView1.CurrentRow.Cells[0].Value.ToString();

            if (class_orders.EditOrdersLocation2(int.Parse(EditNumLocation)))
            {
                MessageBox.Show("Местоположение заказа успешно изменено!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                class_orders.GetOrders();
                dataGridView1.DataSource = class_orders.dtOrders;
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            string EditNumLocation = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            
            if (class_orders.EditOrdersLocation1(int.Parse(EditNumLocation)))
            {
                MessageBox.Show("Местоположение заказа успешно изменено!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                class_orders.GetOrders();
                dataGridView1.DataSource = class_orders.dtOrders;
            }
            
        }

        private void EnableUpdateOrder_Click(object sender, EventArgs e)
        {
            EditOrder = dataGridView1.CurrentRow.Cells[0].Value.ToString();

            EditCustomer = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            EditDateTimePicker4 = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            EditDateTimePicker3 = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            EditLabel = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            EditTitleGP = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            EditContainer = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            EditLocation = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            EditStatus = dataGridView1.CurrentRow.Cells[8].Value.ToString();
        }

        private void FormOrders_Load(object sender, EventArgs e)
        {
            class_orders.GetOrders();
            dataGridView1.DataSource = class_orders.dtOrders;

            groupBox1.Enabled = true;

            LoadComboBoxCustomer();
            LoadComboBoxLabel();
            LoadComboBoxTitleGP();
            LoadComboBoxContainer();
            LoadComboBoxLocation();
            LoadComboBoxStatus();
        }

        private void AddOrder_btn_Click(object sender, EventArgs e)
        {
            string Qcustomer = customer_cbx.SelectedValue.ToString();
            int id_customer = int.Parse(Qcustomer);

            string Qlabel = label_cbx.SelectedValue.ToString();
            int id_label = int.Parse(Qlabel);

            string QtitleGP = titleGP_cbx.SelectedValue.ToString();
            int id_titleGP = int.Parse(QtitleGP);

            string Qcontainer = container_cbx.SelectedValue.ToString();
            int id_container = int.Parse(Qcontainer);

            string Qlocation = location_cbx.SelectedValue.ToString();
            int id_location = int.Parse(Qlocation);

            string Qstatus = status_cbx.SelectedValue.ToString();
            int id_status = int.Parse(Qstatus);

            DateTime dataZacl = dateTimePicker1.Value;
            DateTime dataOconch = dateTimePicker2.Value;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            dateTimePicker2.CustomFormat = "yyyy-MM-dd";
            if(dataZacl >= dataOconch)
            {
                MessageBox.Show("Дата заключение договора не может быть равна или больше даты окончания договора!", 
                                "Предупреждение!",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (customer_cbx.Text != "" && dateTimePicker1.Text != "" && dateTimePicker2.Text != "" &&
                label_cbx.Text != "" && titleGP_cbx.Text != "" && container_cbx.Text != "" && 
                location_cbx.Text != "" && status_cbx.Text != "")
            {
                if(class_orders.AddOrders(id_customer, dateTimePicker1.Value.ToString("yyyy-MM-dd"), 
                                          dateTimePicker2.Value.ToString("yyyy-MM-dd"), id_label, id_titleGP, id_container,
                                          id_location, id_status))
                {
                    MessageBox.Show("Заказ успешно добавлен!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    class_orders.GetOrders();
                    dataGridView1.DataSource = class_orders.dtOrders;
                }
                else
                {
                    MessageBox.Show("Заказ не был добавлен!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Заполните все обязательные поля!", "Предупреждение!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
