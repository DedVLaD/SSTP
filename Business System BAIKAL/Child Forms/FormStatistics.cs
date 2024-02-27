using Business_System_BAIKAL.BD;
using Business_System_BAIKAL.class_Child_form;
using Business_System_BAIKAL.class_table_BD;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;

namespace Business_System_BAIKAL.Forms
{
    public partial class FormStatistics : Form
    {
        public FormStatistics()
        {
            InitializeComponent();
        }

        private void FormStatistics_Load(object sender, EventArgs e)
        {
            class_productbatchgp.StatisticProductBatchGP();
            dataGridView1.DataSource = class_productbatchgp.dtStatisticProductBatchGP;

            class_productbatchpayak.StatisticProductBatchPAYAK();
            dataGridView2.DataSource = class_productbatchpayak.dtStatisticProductBatchPAYAK;

            class_productbatcheok.StatisticProductBatchEOK();
            dataGridView3.DataSource = class_productbatcheok.dtStatisticProductBatchEOK;

            class_orders.StatisticOrders();
            dataGridView4.DataSource = class_orders.dtStatisticOrders;
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"end_production_date <= '" + dateTimePicker1.Text + "' " +
                "AND end_production_date >= '" + dateTimePicker2.Text + "' ";
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"end_production_date <= '" + dateTimePicker1.Text + "' " +
                "AND end_production_date >= '" + dateTimePicker2.Text + "' ";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"viscosity LIKE '%{textBox1.Text}%' " +
                $"AND electrical_capacity LIKE '%{textBox2.Text}%' ";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"electrical_capacity LIKE '%{textBox2.Text}%' " +
                $"AND viscosity LIKE '%{textBox1.Text}%' ";
        }

        private void dateTimePicker4_ValueChanged(object sender, EventArgs e)
        {
            (dataGridView2.DataSource as DataTable).DefaultView.RowFilter = $"end_production_date_PAYAK <= '" + dateTimePicker3.Text + "' " +
                "AND end_production_date_PAYAK >= '" + dateTimePicker4.Text + "' ";
        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {
            (dataGridView2.DataSource as DataTable).DefaultView.RowFilter = $"end_production_date_PAYAK <= '" + dateTimePicker3.Text + "' " +
                "AND end_production_date_PAYAK >= '" + dateTimePicker4.Text + "' ";
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            (dataGridView2.DataSource as DataTable).DefaultView.RowFilter = $"acid_number_PAYAK LIKE '%{textBox4.Text}%' ";
        }

        private void dateTimePicker6_ValueChanged(object sender, EventArgs e)
        {
            (dataGridView3.DataSource as DataTable).DefaultView.RowFilter = $"end_production_date_EOK <= '" + dateTimePicker5.Text + "' " +
                "AND end_production_date_EOK >= '" + dateTimePicker6.Text + "' ";
        }

        private void dateTimePicker5_ValueChanged(object sender, EventArgs e)
        {
            (dataGridView3.DataSource as DataTable).DefaultView.RowFilter = $"end_production_date_EOK <= '" + dateTimePicker5.Text + "' " +
                "AND end_production_date_EOK >= '" + dateTimePicker6.Text + "' ";
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            (dataGridView3.DataSource as DataTable).DefaultView.RowFilter = $"acid_number_EOK LIKE '%{textBox6.Text}%' ";
        }

        private void dateTimePicker10_ValueChanged(object sender, EventArgs e)
        {
            (dataGridView4.DataSource as DataTable).DefaultView.RowFilter = $"end_date_agreement <= '" + dateTimePicker9.Text + "' " +
                "AND end_date_agreement >= '" + dateTimePicker10.Text + "' ";
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            (dataGridView4.DataSource as DataTable).DefaultView.RowFilter = $"weight_kg LIKE '%{textBox5.Text}%' AND name_customer LIKE '%{textBox3.Text}%' ";
        }

        private void dateTimePicker9_ValueChanged(object sender, EventArgs e)
        {
            (dataGridView4.DataSource as DataTable).DefaultView.RowFilter = $"end_date_agreement <= '" + dateTimePicker9.Text + "' " +
                "AND end_date_agreement >= '" + dateTimePicker10.Text + "' ";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            (dataGridView4.DataSource as DataTable).DefaultView.RowFilter = $"name_customer LIKE '%{textBox3.Text}%' AND weight_kg LIKE '%{textBox5.Text}%'";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox5.Text = "";
            textBox3.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox4.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox6.Text = "";
        }
    }
}
