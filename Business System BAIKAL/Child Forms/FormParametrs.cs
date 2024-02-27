using Business_System_BAIKAL.BD;
using Business_System_BAIKAL.class_Child_form;
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
    public partial class FormParametrs : Form
    {
        public FormParametrs()
        {
            InitializeComponent();
        }

        private void AddCustomer_btn_Click(object sender, EventArgs e)
        {
            if (NameCustomer_txt.Text != "" && TelephoneCustomer_txt.Text != "" && AdressCustomer_txt.Text != "")
            {
                string sql = @"SELECT id_customer FROM customers WHERE name_customer = '"+ NameCustomer_txt.Text + "' and telephone = '"+ TelephoneCustomer_txt.Text + "' and adress = '"+ AdressCustomer_txt.Text +"' ";
                DBconnection.msCommand.CommandText = sql;
                Object result = DBconnection.msCommand.ExecuteScalar();
                if (result != null) 
                {
                    MessageBox.Show("У вас уже есть запись с таким названием!", "Дублирование записи!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    NameCustomer_txt.Text = "";
                    TelephoneCustomer_txt.Text = "";
                    AdressCustomer_txt.Text = "";
                }
                else
                {
                    if (class_customer.AddCustomer(NameCustomer_txt.Text, TelephoneCustomer_txt.Text, AdressCustomer_txt.Text))
                    {
                        MessageBox.Show("Заказчик успешно добавлен!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        class_customer.GetCustomer();
                    }
                    else
                    {
                        MessageBox.Show("Заказчик не был добавлен!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                MessageBox.Show("Заполните все обязательные поля!", "Предупреждение!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void FormParametrs_Load(object sender, EventArgs e)
        {
            class_customer.GetCustomer();
            class_label.GetLabel();
            class_titlegp.GetTitleGP();
            class_container.GetContainer();
            class_location.GetLocation();
            class_status.GetStatus();

            dataGridView1.DataSource = class_customer.dtCustomer;
            dataGridView2.DataSource = class_location.dtLocation;
            dataGridView3.DataSource = class_container.dtContainer;
            dataGridView4.DataSource = class_label.dtLabel;
            dataGridView5.DataSource = class_titlegp.dtTitleGP;
            dataGridView6.DataSource = class_status.dtStatus;
        }

        static public string EditNumCustomer, EditNameCustomer, EditTelephpneCustomer, EditAddressCustomer;
        static public string EditNumContainer, EditNameContainer;
        static public string EditNumTitleGP, EditNameTitleGP;
        static public string EditNumStatus, EditNameStatus;
        static public string EditNumLabel, EditNameLabel;
        static public string EditNumLocation, EditNameLocation;

        private void DelContainer_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string select = dataGridView3.CurrentRow.Cells[0].Value.ToString();
                DialogResult del = MessageBox.Show("Вы действительно хотите удалить запись с этой тарой?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (del == DialogResult.Yes)
                {
                    string sql = @"SELECT id_container FROM orders WHERE id_container = '" + select + "' ";
                    DBconnection.msCommand.CommandText = sql;
                    Object result = DBconnection.msCommand.ExecuteScalar();
                    if (result != null)
                    {
                        MessageBox.Show("У вас есть запись с этой тарой в таблице с заказами.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        class_container.DeleteContainer(select);
                        class_container.GetContainer();
                        dataGridView3.DataSource = class_container.dtContainer;
                        MessageBox.Show("Тара удалёна!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    } 
                }
            }
            catch
            {
                MessageBox.Show("Ошибка при удалении записи!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void DelStatus_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string select = dataGridView6.CurrentRow.Cells[0].Value.ToString();
                DialogResult del = MessageBox.Show("Вы действительно хотите удалить запись с этим статусом?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (del == DialogResult.Yes)
                {
                    string sql = @"SELECT id_status FROM orders WHERE id_status = '" + select + "' ";
                    DBconnection.msCommand.CommandText = sql;
                    Object result = DBconnection.msCommand.ExecuteScalar();
                    if (result != null)
                    {
                        MessageBox.Show("У вас есть запись с этим статусом в таблице с заказами.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        class_status.DeleteStatus(select);
                        class_status.GetStatus();
                        dataGridView6.DataSource = class_status.dtStatus;
                        MessageBox.Show("Статус удалён!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }  
                }
            }
            catch
            {
                MessageBox.Show("Ошибка при удалении записи!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void UpdateContainer_btn1_Click(object sender, EventArgs e)
        {
            if (Container_txt.Text == EditNameContainer)
            {
                if (Container_txt.Text != "")
                {
                    if (class_container.EditContainer(int.Parse(EditNumContainer), Container_txt.Text))
                    {
                        MessageBox.Show("Тара успешно изменена!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        class_container.GetContainer();
                        Container_txt.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Ошибка при изменении записи!", "Предупреждение!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Заполните все обязательные поля!", "Предупреждение!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                string sql = @"SELECT id_container FROM container WHERE title_container = '" + Container_txt.Text + "' ";
                DBconnection.msCommand.CommandText = sql;
                Object result = DBconnection.msCommand.ExecuteScalar();
                if (result != null)
                {
                    MessageBox.Show("У вас есть тара с таким названием!", "Дублирование записи!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Container_txt.Text = "";
                }
                else
                {
                    if (Container_txt.Text != "")
                    {
                        if (class_container.EditContainer(int.Parse(EditNumContainer), Container_txt.Text))
                        {
                            MessageBox.Show("Тара успешно изменена!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            class_container.GetContainer();
                            Container_txt.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("Ошибка при изменении записи!", "Предупреждение!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Заполните все обязательные поля!", "Предупреждение!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void AddStatus_btn_Click(object sender, EventArgs e)
        {
            if (Status_txt.Text != "")
            {
                string sql = @"SELECT id_status FROM status WHERE title_status = '" + Status_txt.Text + "' ";
                DBconnection.msCommand.CommandText = sql;
                Object result = DBconnection.msCommand.ExecuteScalar();
                if (result != null)
                {
                    MessageBox.Show("У вас уже есть запись с таким названием!", "Дублирование записи!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Status_txt.Text = "";
                }
                else
                {
                    if (class_status.AddStatus(Status_txt.Text))
                    {
                        MessageBox.Show("Статус успешно добавлен!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        class_status.GetStatus();
                        Status_txt.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Статус не был добавлен!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                MessageBox.Show("Заполните все обязательные поля!", "Предупреждение!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void UpdateStatus_btn_Click(object sender, EventArgs e)
        {
            EditNumStatus = dataGridView6.CurrentRow.Cells[0].Value.ToString();
            EditNameStatus = dataGridView6.CurrentRow.Cells[1].Value.ToString();
            Status_txt.Text = EditNameStatus;
        }

        private void UpdateStatus_btn1_Click(object sender, EventArgs e)
        {
            if (Status_txt.Text == EditNameStatus)
            {
                if (Status_txt.Text != "")
                {
                    if (class_status.EditStatus(int.Parse(EditNumStatus), Status_txt.Text))
                    {
                        MessageBox.Show("Статус успешно изменен!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        class_status.GetStatus();
                        Status_txt.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Ошибка при изменении записи!", "Предупреждение!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Заполните все обязательные поля!", "Предупреждение!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                string sql = @"SELECT id_status FROM status WHERE title_status = '" + Status_txt.Text + "' ";
                DBconnection.msCommand.CommandText = sql;
                Object result = DBconnection.msCommand.ExecuteScalar();
                if (result != null)
                {
                    MessageBox.Show("У вас есть статус с таким названием!", "Дублирование записи!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Status_txt.Text = "";
                }
                else
                {
                    if (Status_txt.Text != "")
                    {
                        if (class_status.EditStatus(int.Parse(EditNumStatus), Status_txt.Text))
                        {
                            MessageBox.Show("Статус успешно изменен!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            class_status.GetStatus();
                            Status_txt.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("Ошибка при изменении записи!", "Предупреждение!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Заполните все обязательные поля!", "Предупреждение!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void UpdateTitleGP_btn1_Click(object sender, EventArgs e)
        {
            if (TitleGP_txt.Text == EditNameTitleGP)
            {
                if (TitleGP_txt.Text != "")
                {
                    if (class_titlegp.EditTitleGP(int.Parse(EditNumTitleGP), TitleGP_txt.Text))
                    {
                        MessageBox.Show("Название ГП успешно изменено!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        class_titlegp.GetTitleGP();
                        TitleGP_txt.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Ошибка при изменении записи!", "Предупреждение!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }                        
                }
                else
                {
                    MessageBox.Show("Заполните все обязательные поля!", "Предупреждение!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                string sql = @"SELECT id_titleGP FROM titlegp WHERE titleGP = '" + TitleGP_txt.Text + "' ";
                DBconnection.msCommand.CommandText = sql;
                Object result = DBconnection.msCommand.ExecuteScalar();
                if (result != null)
                {
                    MessageBox.Show("У вас есть ГП с таким названием!", "Дублирование записи!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    TitleGP_txt.Text = "";
                }
                else
                {
                    if (TitleGP_txt.Text != "")
                    {
                        if (class_titlegp.EditTitleGP(int.Parse(EditNumTitleGP), TitleGP_txt.Text))
                        {
                            MessageBox.Show("Название ГП успешно изменено!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            class_titlegp.GetTitleGP();
                            TitleGP_txt.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("Ошибка при изменении записи!", "Предупреждение!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Заполните все обязательные поля!", "Предупреждение!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void UpdateTitleGP_btn_Click(object sender, EventArgs e)
        {
            EditNumTitleGP = dataGridView5.CurrentRow.Cells[0].Value.ToString();
            EditNameTitleGP = dataGridView5.CurrentRow.Cells[1].Value.ToString();
            TitleGP_txt.Text = EditNameTitleGP;
        }

        private void AddTitileGP_btn_Click(object sender, EventArgs e)
        {
            if (TitleGP_txt.Text != "")
            {
                string sql = @"SELECT id_titleGP FROM titlegp WHERE titleGP = '" + TitleGP_txt.Text + "' ";
                DBconnection.msCommand.CommandText = sql;
                Object result = DBconnection.msCommand.ExecuteScalar();
                if (result != null)
                {
                    MessageBox.Show("У вас уже есть запись с таким названием!", "Дублирование записи!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    TitleGP_txt.Text = "";
                }
                else
                {
                    if (class_titlegp.AddTitleGP(TitleGP_txt.Text))
                    {
                        MessageBox.Show("Название ГП успешно добавлено!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        class_titlegp.GetTitleGP();
                        TitleGP_txt.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("ГП не был добавлен!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                MessageBox.Show("Заполните все обязательные поля!", "Предупреждение!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void UpdateLocation_btn1_Click(object sender, EventArgs e)
        {
            if (Location_txt.Text == EditNameLocation)
            {
                if (Location_txt.Text != "")
                {
                    if (class_location.EditLocation(int.Parse(EditNumLocation), Location_txt.Text))
                    {
                        MessageBox.Show("Местоположение успешно изменено!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        class_location.GetLocation();
                        Location_txt.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Ошибка при изменении записи!", "Предупреждение!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Заполните все обязательные поля!", "Предупреждение!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                string sql = @"SELECT id_location FROM location WHERE title_location = '" + Location_txt.Text + "' ";
                DBconnection.msCommand.CommandText = sql;
                Object result = DBconnection.msCommand.ExecuteScalar();
                if (result != null)
                {
                    MessageBox.Show("У вас есть местоположение с таким названием!", "Дублирование записи!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Location_txt.Text = "";
                }
                else
                {
                    if (Location_txt.Text != "")
                    {
                        if (class_location.EditLocation(int.Parse(EditNumLocation), Location_txt.Text))
                        {
                            MessageBox.Show("Местоположение успешно изменено!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            class_location.GetLocation();
                            Location_txt.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("Ошибка при изменении записи!", "Предупреждение!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Заполните все обязательные поля!", "Предупреждение!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void UpdateLocation_btn_Click(object sender, EventArgs e)
        {
            EditNumLocation = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            EditNameLocation = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            Location_txt.Text = EditNameLocation;
        }

        private void AddLocation_btn_Click(object sender, EventArgs e)
        {
            if (Location_txt.Text != "")
            {
                string sql = @"SELECT id_location FROM location WHERE title_location = '" + Location_txt.Text + "' ";
                DBconnection.msCommand.CommandText = sql;
                Object result = DBconnection.msCommand.ExecuteScalar();
                if (result != null)
                {
                    MessageBox.Show("У вас уже есть запись с таким названием!", "Дублирование записи!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Location_txt.Text = "";
                }
                else
                {
                    if (class_location.AddLocation(Location_txt.Text))
                    {
                        MessageBox.Show("Название местоположения успешно добавлено!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        class_location.GetLocation();
                        Location_txt.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Местоположение не было добавлено!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                MessageBox.Show("Заполните все обязательные поля!", "Предупреждение!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void AddLabel_btn_Click(object sender, EventArgs e)
        {
            if (Label_txt.Text != "")
            {
                string sql = @"SELECT id_label FROM labels WHERE title_label = '" + Label_txt.Text + "' ";
                DBconnection.msCommand.CommandText = sql;
                Object result = DBconnection.msCommand.ExecuteScalar();
                if (result != null)
                {
                    MessageBox.Show("У вас уже есть запись с таким названием!", "Дублирование записи!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Label_txt.Text = "";
                }
                else
                {
                    if (class_label.AddLabel(Label_txt.Text))
                    {
                        MessageBox.Show("Название этикетки успешно добавлено!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        class_label.GetLabel();
                        Label_txt.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Этикетка не была добавлена!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                MessageBox.Show("Заполните все обязательные поля!", "Предупреждение!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void UpdateLabel_btn_Click(object sender, EventArgs e)
        {
            EditNumLabel = dataGridView4.CurrentRow.Cells[0].Value.ToString();
            EditNameLabel = dataGridView4.CurrentRow.Cells[1].Value.ToString();
            Label_txt.Text = EditNameLabel;
        }

        private void UpdateLabel_btn1_Click(object sender, EventArgs e)
        {
            if (Label_txt.Text == EditNameLabel)
            {
                if (Label_txt.Text != "")
                {
                    if (class_label.EditLabel(int.Parse(EditNumLabel), Label_txt.Text))
                    {
                        MessageBox.Show("Этикетка успешно изменено!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        class_label.GetLabel();
                        Label_txt.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Ошибка при изменении записи!", "Предупреждение!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Заполните все обязательные поля!", "Предупреждение!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                string sql = @"SELECT id_label FROM labels WHERE title_label = '" + Label_txt.Text + "' ";
                DBconnection.msCommand.CommandText = sql;
                Object result = DBconnection.msCommand.ExecuteScalar();
                if (result != null)
                {
                    MessageBox.Show("У вас есть этикетка с таким названием!", "Дублирование записи!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Label_txt.Text = "";
                }
                else
                {
                    if (Label_txt.Text != "")
                    {
                        if (class_label.EditLabel(int.Parse(EditNumLabel), Label_txt.Text))
                        {
                            MessageBox.Show("Этикетка успешно изменено!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            class_label.GetLabel();
                            Label_txt.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("Ошибка при изменении записи!", "Предупреждение!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Заполните все обязательные поля!", "Предупреждение!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void DelTitleGP_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string select = dataGridView5.CurrentRow.Cells[0].Value.ToString();
                DialogResult del = MessageBox.Show("Вы действительно хотите удалить запись с этим наименованием ГП?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (del == DialogResult.Yes)
                {
                    string sql = @"SELECT id_titleGP FROM orders WHERE id_titleGP = '" + select + "' ";
                    DBconnection.msCommand.CommandText = sql;
                    Object result = DBconnection.msCommand.ExecuteScalar();
                    if (result != null)
                    {
                        MessageBox.Show("У вас есть запись с этим названием ГП в таблице с заказами.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        class_titlegp.DeleteTitleGP(select);
                        class_titlegp.GetTitleGP();
                        dataGridView5.DataSource = class_titlegp.dtTitleGP;
                        MessageBox.Show("Наименование ГП удалёно!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }  
                }
            }
            catch
            {
                MessageBox.Show("Ошибка при удалении записи!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void DelLocation_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string select = dataGridView2.CurrentRow.Cells[0].Value.ToString();
                DialogResult del = MessageBox.Show("Вы действительно хотите удалить запись с этим местоположением?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (del == DialogResult.Yes)
                {
                    string sql = @"SELECT id_location FROM orders WHERE id_location = '" + select + "' ";
                    DBconnection.msCommand.CommandText = sql;
                    Object result = DBconnection.msCommand.ExecuteScalar();
                    if (result != null)
                    {
                        MessageBox.Show("У вас есть запись с этим местоположением в таблице с заказами.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        class_location.DeleteLocation(select);
                        class_location.GetLocation();
                        dataGridView2.DataSource = class_location.dtLocation;
                        MessageBox.Show("Местоположение удалёно!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }                   
                }
            }
            catch
            {
                MessageBox.Show("Ошибка при удалении записи!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void DelLabel_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string select = dataGridView4.CurrentRow.Cells[0].Value.ToString();
                DialogResult del = MessageBox.Show("Вы действительно хотите удалить запись с этой этикеткой?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (del == DialogResult.Yes)
                {
                    string sql = @"SELECT id_label FROM orders WHERE id_label = '"+ select +"' ";
                    DBconnection.msCommand.CommandText = sql;
                    Object result = DBconnection.msCommand.ExecuteScalar();
                    if(result != null)
                    {
                        MessageBox.Show("У вас есть запись с этой этикеткой в таблице с заказами.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        class_label.DeleteLabel(select);
                        class_label.GetLabel();
                        dataGridView4.DataSource = class_label.dtLabel;
                        MessageBox.Show("Этикетка удалёна!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    } 
                }
            }
            catch
            {
                MessageBox.Show("Ошибка при удалении записи!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void AddContainer_btn_Click(object sender, EventArgs e)
        {
            if (Container_txt.Text != "")
            {
                string sql = @"SELECT id_container FROM container WHERE title_container = '" + Container_txt.Text + "' ";
                DBconnection.msCommand.CommandText = sql;
                Object result = DBconnection.msCommand.ExecuteScalar();
                if (result != null)
                {
                    MessageBox.Show("У вас уже есть запись с таким названием!", "Дублирование записи!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Container_txt.Text = "";
                }
                else
                {
                    if (class_container.AddContainer(Container_txt.Text))
                    {
                        MessageBox.Show("Тара успешно добавлена!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        class_container.GetContainer();
                        Container_txt.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Тара не была добавлена!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                MessageBox.Show("Заполните все обязательные поля!", "Предупреждение!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void UpdateContainer_btn_Click(object sender, EventArgs e)
        {
            EditNumContainer = dataGridView3.CurrentRow.Cells[0].Value.ToString();
            EditNameContainer = dataGridView3.CurrentRow.Cells[1].Value.ToString();
            Container_txt.Text = EditNameContainer;
        }

        private void DelCustomer_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string select = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                DialogResult del = MessageBox.Show("Вы действительно хотите удалить запись с этим заказчиком?", "Подтверждение удаления", 
                                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (del == DialogResult.Yes)
                {
                    string sql = @"SELECT id_customer FROM orders WHERE id_customer = '" + select + "' ";
                    DBconnection.msCommand.CommandText = sql;
                    Object result = DBconnection.msCommand.ExecuteScalar();
                    if (result != null)
                    {
                        MessageBox.Show("У вас есть запись с этим заказчиком в таблице с заказами.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        class_customer.DeleteCustomer(select);
                        class_customer.GetCustomer();
                        dataGridView1.DataSource = class_customer.dtCustomer;
                        MessageBox.Show("Заказчик удалён!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    } 
                }
            }
            catch
            {
                MessageBox.Show("Ошибка при удалении записи!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void UpdateCustomer_btn1_Click(object sender, EventArgs e)
        {
            if (NameCustomer_txt.Text == EditNameCustomer && TelephoneCustomer_txt.Text == EditTelephpneCustomer && AdressCustomer_txt.Text == EditAddressCustomer)
            {
                if (NameCustomer_txt.Text != "" && TelephoneCustomer_txt.Text != "" && AdressCustomer_txt.Text != "")
                {
                    if(class_customer.EditCustomer(int.Parse(EditNumCustomer), NameCustomer_txt.Text, TelephoneCustomer_txt.Text, AdressCustomer_txt.Text))
                    {
                        MessageBox.Show("Заказчик успешно изменен!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        class_customer.GetCustomer();
                        NameCustomer_txt.Text = "";
                        TelephoneCustomer_txt.Text = "";
                        AdressCustomer_txt.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Ошибка при изменении записи!", "Предупреждение!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Заполните все обязательные поля!", "Предупреждение!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                string sql = @"SELECT id_customer FROM customers WHERE name_customer = '"+ NameCustomer_txt + "' ";
                DBconnection.msCommand.CommandText = sql;
                Object result = DBconnection.msCommand.ExecuteScalar();
                if (result != null)
                {
                    MessageBox.Show("У вас есть заказчик с таким именем!", "Дублирование записи!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    NameCustomer_txt.Text = "";
                    TelephoneCustomer_txt.Text = "";
                    AdressCustomer_txt.Text = "";
                }
                else
                {
                    if (NameCustomer_txt.Text != "" && TelephoneCustomer_txt.Text != "" && AdressCustomer_txt.Text != "")
                    {
                        if (class_customer.EditCustomer(int.Parse(EditNumCustomer), NameCustomer_txt.Text, TelephoneCustomer_txt.Text, AdressCustomer_txt.Text))
                        {
                            MessageBox.Show("Заказчик успешно изменен!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            class_customer.GetCustomer();
                            NameCustomer_txt.Text = "";
                            TelephoneCustomer_txt.Text = "";
                            AdressCustomer_txt.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("Ошибка при изменении записи!", "Предупреждение!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Заполните все обязательные поля!", "Предупреждение!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void UpdateCustomer_btn_Click(object sender, EventArgs e)
        {
            EditNumCustomer = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            EditNameCustomer = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            EditTelephpneCustomer = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            EditAddressCustomer = dataGridView1.CurrentRow.Cells[3].Value.ToString();

            NameCustomer_txt.Text = EditNameCustomer;
            TelephoneCustomer_txt.Text = EditTelephpneCustomer;
            AdressCustomer_txt.Text = EditAddressCustomer;
        }
    }
}
