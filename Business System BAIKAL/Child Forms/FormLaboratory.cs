using Business_System_BAIKAL.BD;
using Business_System_BAIKAL.class_Child_form;
using Business_System_BAIKAL.class_table_BD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Business_System_BAIKAL.Forms
{
    public partial class FormLaboratory : Form
    {
        public FormLaboratory()
        {
            InitializeComponent();
        }

        private void FormLaboratory_Load(object sender, EventArgs e)
        {
            class_compositionorder.GetCompositiOnorder();
            dataGridView1.DataSource = class_compositionorder.dtCompositiOnorder;
        }

        static public string EditNumCompositionOrder, EditCompositionOrder, EditPassport, EditWeightKG;

        private void WeightKG_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CompositionOrder_txt.Text = "";
            Passport_txt.Text = "";
            WeightKG_txt.Text = "";
        }

        private void UpdateCompositionOrder_btn1_Click(object sender, EventArgs e)
        {
            if (CompositionOrder_txt.Text == EditCompositionOrder && Passport_txt.Text == EditPassport && WeightKG_txt.Text == EditWeightKG)
            {
                    if (class_compositionorder.EditCompositiOnorder(int.Parse(EditNumCompositionOrder), CompositionOrder_txt.Text, Passport_txt.Text, WeightKG_txt.Text))
                    {
                        MessageBox.Show("Состав заказа успешно изменен!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        class_compositionorder.GetCompositiOnorder();
                        CompositionOrder_txt.Text = "";
                        Passport_txt.Text = "";
                        WeightKG_txt.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Ошибка при изменении записи!", "Предупреждение!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
            }
            else
            {
                    if (class_compositionorder.EditCompositiOnorder(int.Parse(EditNumCompositionOrder), CompositionOrder_txt.Text, Passport_txt.Text, WeightKG_txt.Text))
                    {
                        MessageBox.Show("Состав заказа успешно изменен!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        class_compositionorder.GetCompositiOnorder();
                        CompositionOrder_txt.Text = "";
                        Passport_txt.Text = "";
                        WeightKG_txt.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Ошибка при изменении записи!", "Предупреждение!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
            }
        }

        private void UpdateCompositionOrder_btn_Click(object sender, EventArgs e)
        {
            EditNumCompositionOrder = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            EditCompositionOrder = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            EditPassport = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            EditWeightKG = dataGridView1.CurrentRow.Cells[3].Value.ToString();

            CompositionOrder_txt.Text = EditCompositionOrder;
            Passport_txt.Text = EditPassport;
            WeightKG_txt.Text = EditWeightKG;
        }
    }
}
