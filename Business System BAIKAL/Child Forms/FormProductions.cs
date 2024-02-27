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
    public partial class FormProductions : Form
    {
        public FormProductions()
        {
            InitializeComponent();
        }

        private void FormProductions_Load(object sender, EventArgs e)
        {
            class_productbatchgp.GetProductBatchGP();
            dataGridView1.DataSource = class_productbatchgp.dtProductBatchGP;

            class_productbatchpayak.GetProductBatchPAYAK();
            dataGridView2.DataSource = class_productbatchpayak.dtProductBatchPAYAK;

            class_productbatcheok.GetProductBatchEOK();
            dataGridView3.DataSource = class_productbatcheok.dtProductBatchEOK;
        }

        static public string EditNumProductBatchGP, EditNumCompositionOrder, EditBeginProductionDate, EditEndProductionDate, EditViscosity, EditElectricalCapacity;
        static public string EditNumProductBatchPAYAK, EditNumProductBatchGPPAYAK, EditBeginProductionDatePAYAK, EditEndProductionDatePAYAK, EditAcidNumberPAYAK, EditCommentPAYAK;

        private void button1_Click(object sender, EventArgs e)
        {
            NumCompositionOrder_txt.Text = "";
            dateTimePicker1.Text = "";
            dateTimePicker2.Text = "";
            Viscosity_txt.Text = "";
            ElectricalCapacity_txt.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NumProductBatchGPPAYAK_txt.Text = "";
            dateTimePicker3.Text = "";
            dateTimePicker4.Text = "";
            AcidNumberPAYAK_txt.Text = "";
            CommentPAYAK_txt.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NumProductBatchGPEOK_txt.Text = "";
            dateTimePicker5.Text = "";
            dateTimePicker6.Text = "";
            AcidNumberEOK_txt.Text = "";
            CommentEOK_txt.Text = "";
        }

        private void NumCompositionOrder_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void Viscosity_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void ElectricalCapacity_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void NumProductBatchGPPAYAK_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void AcidNumberPAYAK_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void NumProductBatchGPEOK_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void AcidNumberEOK_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UpdateProductBatchEOK_btn1_Click(object sender, EventArgs e)
        {
            if (NumProductBatchGPEOK_txt.Text == EditNumProductBatchGPEOK && dateTimePicker5.Text == EditBeginProductionDateEOK &&
                dateTimePicker6.Text == EditEndProductionDateEOK && AcidNumberEOK_txt.Text == EditAcidNumberEOK &&
                CommentEOK_txt.Text == EditCommentEOK)
            {

                DateTime dataZacl = dateTimePicker5.Value;
                DateTime dataOconch = dateTimePicker6.Value;
                dateTimePicker5.CustomFormat = "yyyy-MM-dd";
                dateTimePicker6.CustomFormat = "yyyy-MM-dd";
                if (dataZacl >= dataOconch)
                {
                    MessageBox.Show("Дата заключение договора не может быть равна или больше даты окончания!",
                                    "Предупреждение!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (NumProductBatchGPEOK_txt.Text != "" && dateTimePicker5.Text != "" &&
                dateTimePicker6.Text != "")
                {
                    if (class_productbatcheok.EditProductBatchEOK(int.Parse(EditNumProductBatchEOK), int.Parse(NumProductBatchGPEOK_txt.Text),
                        dateTimePicker5.Value.ToString("yyyy-MM-dd"), dateTimePicker6.Value.ToString("yyyy-MM-dd"),
                        AcidNumberEOK_txt.Text, CommentEOK_txt.Text))
                    {
                        MessageBox.Show("Партия ЭОКа успешно изменена!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        class_productbatcheok.GetProductBatchEOK();

                        NumProductBatchGPEOK_txt.Text = "";
                        dateTimePicker5.Text = "";
                        dateTimePicker6.Text = "";
                        AcidNumberEOK_txt.Text = "";
                        CommentEOK_txt.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Ошибка при изменении записи!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Заполните все обязательные поля!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                DateTime dataZacl = dateTimePicker5.Value;
                DateTime dataOconch = dateTimePicker6.Value;
                dateTimePicker5.CustomFormat = "yyyy-MM-dd";
                dateTimePicker6.CustomFormat = "yyyy-MM-dd";
                if (dataZacl >= dataOconch)
                {
                    MessageBox.Show("Дата заключение договора не может быть равна или больше даты окончания!",
                                    "Предупреждение!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (NumProductBatchGPEOK_txt.Text != "" && dateTimePicker5.Text != "" &&
                dateTimePicker6.Text != "")
                {
                    if (class_productbatcheok.EditProductBatchEOK(int.Parse(EditNumProductBatchEOK), int.Parse(NumProductBatchGPEOK_txt.Text),
                        dateTimePicker5.Value.ToString("yyyy-MM-dd"), dateTimePicker6.Value.ToString("yyyy-MM-dd"),
                        AcidNumberEOK_txt.Text, CommentEOK_txt.Text))
                    {
                        MessageBox.Show("Партия ЭОКа успешно изменена!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        class_productbatcheok.GetProductBatchEOK();

                        NumProductBatchGPEOK_txt.Text = "";
                        dateTimePicker5.Text = "";
                        dateTimePicker6.Text = "";
                        AcidNumberEOK_txt.Text = "";
                        CommentEOK_txt.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Ошибка при изменении записи!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Заполните все обязательные поля!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        static public string EditNumProductBatchEOK, EditNumProductBatchGPEOK, EditBeginProductionDateEOK, EditEndProductionDateEOK, EditAcidNumberEOK, EditCommentEOK;


        private void AddProductBatchEOK_btn_Click(object sender, EventArgs e)
        {
            if (NumProductBatchGPEOK_txt.Text != "" && dateTimePicker5.Text != "" &&
                dateTimePicker6.Text != "")
            {
                DateTime dataZacl = dateTimePicker5.Value;
                DateTime dataOconch = dateTimePicker6.Value;
                dateTimePicker5.CustomFormat = "yyyy-MM-dd";
                dateTimePicker6.CustomFormat = "yyyy-MM-dd";
                if (dataZacl >= dataOconch)
                {
                    MessageBox.Show("Дата начала не может быть равна или больше даты окончания!",
                                    "Предупреждение!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (class_productbatcheok.AddProductBatchEOK(int.Parse(NumProductBatchGPEOK_txt.Text), dateTimePicker5.Value.ToString("yyyy-MM-dd"), dateTimePicker6.Value.ToString("yyyy-MM-dd"), AcidNumberEOK_txt.Text, CommentEOK_txt.Text))
                {
                    MessageBox.Show("Партия ЭОКа успешно добавлена!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    class_productbatcheok.GetProductBatchEOK();

                    NumProductBatchGPEOK_txt.Text = "";
                    dateTimePicker5.Text = "";
                    dateTimePicker6.Text = "";
                    AcidNumberEOK_txt.Text = "";
                    CommentEOK_txt.Text = "";
                }
                else
                {
                    MessageBox.Show("Партия ЭОКа не была добавлена!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Заполните все обязательные поля!", "Предупреждение!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void AddProductBatchPAYAK_btn_Click(object sender, EventArgs e)
        {
            if (NumProductBatchGPPAYAK_txt.Text != "" && dateTimePicker3.Text != "" &&
                dateTimePicker4.Text != "")
            {

                DateTime dataZacl = dateTimePicker3.Value;
                DateTime dataOconch = dateTimePicker4.Value;
                dateTimePicker3.CustomFormat = "yyyy-MM-dd";
                dateTimePicker4.CustomFormat = "yyyy-MM-dd";
                if (dataZacl >= dataOconch)
                {
                    MessageBox.Show("Дата начала не может быть равна или больше даты окончания!",
                                    "Предупреждение!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (class_productbatchpayak.AddProductBatchPAYAK(int.Parse(NumProductBatchGPPAYAK_txt.Text), dateTimePicker3.Value.ToString("yyyy-MM-dd"), dateTimePicker4.Value.ToString("yyyy-MM-dd"), AcidNumberPAYAK_txt.Text, CommentPAYAK_txt.Text))
                {
                    MessageBox.Show("Партия ПЭАЯКа успешно добавлена!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    class_productbatchpayak.GetProductBatchPAYAK();

                    NumProductBatchGPPAYAK_txt.Text = "";
                    dateTimePicker3.Text = "";
                    dateTimePicker4.Text = "";
                    AcidNumberPAYAK_txt.Text = "";
                    CommentPAYAK_txt.Text = "";
                }
                else
                {
                    MessageBox.Show("Партия ПЭАЯКа не была добавлена!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Заполните все обязательные поля!", "Предупреждение!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void UpdateProductBatchPAYAK_btn1_Click(object sender, EventArgs e)
        {
            if (NumProductBatchGPPAYAK_txt.Text == EditNumProductBatchGPPAYAK && dateTimePicker3.Text == EditBeginProductionDatePAYAK &&
                dateTimePicker4.Text == EditEndProductionDatePAYAK && AcidNumberPAYAK_txt.Text == EditAcidNumberPAYAK &&
                CommentPAYAK_txt.Text == EditCommentPAYAK)
            {

                DateTime dataZacl = dateTimePicker3.Value;
                DateTime dataOconch = dateTimePicker4.Value;
                dateTimePicker3.CustomFormat = "yyyy-MM-dd";
                dateTimePicker4.CustomFormat = "yyyy-MM-dd";
                if (dataZacl >= dataOconch)
                {
                    MessageBox.Show("Дата заключение договора не может быть равна или больше даты окончания!",
                                    "Предупреждение!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (NumProductBatchGPPAYAK_txt.Text != "" && dateTimePicker3.Text != "" &&
                dateTimePicker4.Text != "")
                {
                    if (class_productbatchpayak.EditProductBatchPAYAK(int.Parse(EditNumProductBatchPAYAK), int.Parse(NumProductBatchGPPAYAK_txt.Text), 
                        dateTimePicker3.Value.ToString("yyyy-MM-dd"), dateTimePicker4.Value.ToString("yyyy-MM-dd"), 
                        AcidNumberPAYAK_txt.Text, CommentPAYAK_txt.Text))
                    {
                        MessageBox.Show("Партия ПЭАЯКа успешно изменена!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        class_productbatchpayak.GetProductBatchPAYAK();

                        NumProductBatchGPPAYAK_txt.Text = "";
                        dateTimePicker3.Text = "";
                        dateTimePicker4.Text = "";
                        AcidNumberPAYAK_txt.Text = "";
                        CommentPAYAK_txt.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Ошибка при изменении записи!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Заполните все обязательные поля!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                DateTime dataZacl = dateTimePicker3.Value;
                DateTime dataOconch = dateTimePicker4.Value;
                dateTimePicker3.CustomFormat = "yyyy-MM-dd";
                dateTimePicker4.CustomFormat = "yyyy-MM-dd";
                if (dataZacl >= dataOconch)
                {
                    MessageBox.Show("Дата заключение договора не может быть равна или больше даты окончания!",
                                    "Предупреждение!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (NumProductBatchGPPAYAK_txt.Text != "" && dateTimePicker3.Text != "" &&
                dateTimePicker4.Text != "")
                {
                    if (class_productbatchpayak.EditProductBatchPAYAK(int.Parse(EditNumProductBatchPAYAK), int.Parse(NumProductBatchGPPAYAK_txt.Text),
                        dateTimePicker3.Value.ToString("yyyy-MM-dd"), dateTimePicker4.Value.ToString("yyyy-MM-dd"),
                        AcidNumberPAYAK_txt.Text, CommentPAYAK_txt.Text))
                    {
                        MessageBox.Show("Партия ПЭАЯКа успешно изменена!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        class_productbatchpayak.GetProductBatchPAYAK();

                        NumProductBatchGPPAYAK_txt.Text = "";
                        dateTimePicker3.Text = "";
                        dateTimePicker4.Text = "";
                        AcidNumberPAYAK_txt.Text = "";
                        CommentPAYAK_txt.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Ошибка при изменении записи!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Заполните все обязательные поля!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void AddProductBatchGP_btn_Click(object sender, EventArgs e)
        {   
            if (NumCompositionOrder_txt.Text != "" && dateTimePicker1.Text != "" &&
                dateTimePicker2.Text != "")
            {

                DateTime dataZacl = dateTimePicker1.Value;
                DateTime dataOconch = dateTimePicker2.Value;
                dateTimePicker1.CustomFormat = "yyyy-MM-dd";
                dateTimePicker2.CustomFormat = "yyyy-MM-dd";
                if (dataZacl >= dataOconch)
                {
                    MessageBox.Show("Дата начала не может быть равна или больше даты окончания!",
                                    "Предупреждение!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (class_productbatchgp.AddProductBatchGP(int.Parse(NumCompositionOrder_txt.Text), dateTimePicker1.Value.ToString("yyyy-MM-dd"), dateTimePicker2.Value.ToString("yyyy-MM-dd"), Viscosity_txt.Text, ElectricalCapacity_txt.Text))
                {
                    MessageBox.Show("Партия ГП успешно добавлена!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    class_productbatchgp.GetProductBatchGP();

                    NumCompositionOrder_txt.Text = "";
                    dateTimePicker1.Text = "";
                    dateTimePicker2.Text = "";
                    Viscosity_txt.Text = "";
                    ElectricalCapacity_txt.Text = "";
                }
                else
                {
                    MessageBox.Show("Партия ГП не была добавлена!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Заполните все обязательные поля!", "Предупреждение!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void UpdateProductBatchGPbtn_Click(object sender, EventArgs e)
        {
            EditNumProductBatchGP = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            EditNumCompositionOrder = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            EditBeginProductionDate = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            EditEndProductionDate = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            EditViscosity = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            EditElectricalCapacity = dataGridView1.CurrentRow.Cells[5].Value.ToString();

            NumCompositionOrder_txt.Text = EditNumCompositionOrder;
            dateTimePicker1.Text = EditBeginProductionDate;
            dateTimePicker2.Text = EditEndProductionDate;
            Viscosity_txt.Text = EditViscosity;
            ElectricalCapacity_txt.Text = EditElectricalCapacity;
        }

        private void UpdateProductBatchGP_btn1_Click(object sender, EventArgs e)
        {
            if (NumCompositionOrder_txt.Text == EditNumCompositionOrder && dateTimePicker1.Text == EditBeginProductionDate && 
                dateTimePicker2.Text == EditEndProductionDate && Viscosity_txt.Text == EditViscosity && 
                ElectricalCapacity_txt.Text == EditElectricalCapacity)
            {

                DateTime dataZacl = dateTimePicker1.Value;
                DateTime dataOconch = dateTimePicker2.Value;
                dateTimePicker1.CustomFormat = "yyyy-MM-dd";
                dateTimePicker2.CustomFormat = "yyyy-MM-dd";
                if (dataZacl >= dataOconch)
                {
                    MessageBox.Show("Дата заключение договора не может быть равна или больше даты окончания!",
                                    "Предупреждение!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (NumCompositionOrder_txt.Text != "" && dateTimePicker1.Text != "" &&
                dateTimePicker2.Text != "")
                {
                    if (class_productbatchgp.EditProductBatchGP(int.Parse(EditNumProductBatchGP), int.Parse(NumCompositionOrder_txt.Text),
                        dateTimePicker1.Value.ToString("yyyy-MM-dd"), dateTimePicker2.Value.ToString("yyyy-MM-dd"), Viscosity_txt.Text, ElectricalCapacity_txt.Text))
                    {
                        MessageBox.Show("Партия ГП успешно изменена!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        class_productbatchgp.GetProductBatchGP();
                        NumCompositionOrder_txt.Text = "";
                        dateTimePicker1.Text = "";
                        dateTimePicker2.Text = "";
                        Viscosity_txt.Text = "";
                        ElectricalCapacity_txt.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Ошибка при изменении записи!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Заполните все обязательные поля!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                DateTime dataZacl = dateTimePicker1.Value;
                DateTime dataOconch = dateTimePicker2.Value;
                dateTimePicker1.CustomFormat = "yyyy-MM-dd";
                dateTimePicker2.CustomFormat = "yyyy-MM-dd";
                if (dataZacl >= dataOconch)
                {
                    MessageBox.Show("Дата заключение договора не может быть равна или больше даты окончания!",
                                    "Предупреждение!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (NumCompositionOrder_txt.Text != "" && dateTimePicker1.Text != "" &&
                dateTimePicker2.Text != "")
                {
                    if (class_productbatchgp.EditProductBatchGP(int.Parse(EditNumProductBatchGP), int.Parse(NumCompositionOrder_txt.Text),
                        dateTimePicker1.Value.ToString("yyyy-MM-dd"), dateTimePicker2.Value.ToString("yyyy-MM-dd"), Viscosity_txt.Text, ElectricalCapacity_txt.Text))
                    {
                        MessageBox.Show("Партия ГП успешно изменена!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        class_productbatchgp.GetProductBatchGP();
                        NumCompositionOrder_txt.Text = "";
                        dateTimePicker1.Text = "";
                        dateTimePicker2.Text = "";
                        Viscosity_txt.Text = "";
                        ElectricalCapacity_txt.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Ошибка при изменении записи!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Заполните все обязательные поля!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void UpdateProductBatchEOK_btn_Click(object sender, EventArgs e)
        {
            EditNumProductBatchEOK = dataGridView3.CurrentRow.Cells[0].Value.ToString();
            EditNumProductBatchGPEOK = dataGridView3.CurrentRow.Cells[1].Value.ToString();
            EditBeginProductionDateEOK = dataGridView3.CurrentRow.Cells[2].Value.ToString();
            EditEndProductionDateEOK = dataGridView3.CurrentRow.Cells[3].Value.ToString();
            EditAcidNumberEOK = dataGridView3.CurrentRow.Cells[4].Value.ToString();
            EditCommentEOK = dataGridView3.CurrentRow.Cells[5].Value.ToString();

            NumProductBatchGPEOK_txt.Text = EditNumProductBatchGPEOK;
            dateTimePicker5.Text = EditBeginProductionDateEOK;
            dateTimePicker6.Text = EditEndProductionDateEOK;
            AcidNumberEOK_txt.Text = EditAcidNumberEOK;
            CommentEOK_txt.Text = EditCommentEOK;
        }

        private void UpdateProductBatchPAYAK_btn_Click(object sender, EventArgs e)
        {
            EditNumProductBatchPAYAK = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            EditNumProductBatchGPPAYAK = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            EditBeginProductionDatePAYAK = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            EditEndProductionDatePAYAK = dataGridView2.CurrentRow.Cells[3].Value.ToString();
            EditAcidNumberPAYAK = dataGridView2.CurrentRow.Cells[4].Value.ToString();
            EditCommentPAYAK = dataGridView2.CurrentRow.Cells[5].Value.ToString();

            NumProductBatchGPPAYAK_txt.Text = EditNumProductBatchGPPAYAK;
            dateTimePicker3.Text = EditBeginProductionDatePAYAK;
            dateTimePicker4.Text = EditEndProductionDatePAYAK;
            AcidNumberPAYAK_txt.Text = EditAcidNumberPAYAK;
            CommentPAYAK_txt.Text = EditCommentPAYAK;
        }
    }
}
