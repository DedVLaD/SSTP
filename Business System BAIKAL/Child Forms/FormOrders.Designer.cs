namespace Business_System_BAIKAL.Forms
{
    partial class FormOrders
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bSBAIKALDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bS_BAIKALDataSet = new Business_System_BAIKAL.BS_BAIKALDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.status_cbx = new System.Windows.Forms.ComboBox();
            this.titleGP_cbx = new System.Windows.Forms.ComboBox();
            this.container_cbx = new System.Windows.Forms.ComboBox();
            this.location_cbx = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AddOrder_btn = new FontAwesome.Sharp.IconButton();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label18 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.label_cbx = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.customer_cbx = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.iconButton5 = new FontAwesome.Sharp.IconButton();
            this.iconButton6 = new FontAwesome.Sharp.IconButton();
            this.iconButton7 = new FontAwesome.Sharp.IconButton();
            this.id_order = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name_customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_order_formation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.end_date_agreement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.title_label = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleGP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.title_container = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.title_location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.title_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bSBAIKALDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bS_BAIKALDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_order,
            this.name_customer,
            this.data_order_formation,
            this.end_date_agreement,
            this.title_label,
            this.titleGP,
            this.title_container,
            this.title_location,
            this.title_status});
            this.dataGridView1.DataSource = this.bSBAIKALDataSetBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(20, 33);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1637, 432);
            this.dataGridView1.TabIndex = 8;
            // 
            // bSBAIKALDataSetBindingSource
            // 
            this.bSBAIKALDataSetBindingSource.DataSource = this.bS_BAIKALDataSet;
            this.bSBAIKALDataSetBindingSource.Position = 0;
            // 
            // bS_BAIKALDataSet
            // 
            this.bS_BAIKALDataSet.DataSetName = "BS_BAIKALDataSet";
            this.bS_BAIKALDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(378, 218);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "Местоположение";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(378, 141);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 24);
            this.label3.TabIndex = 13;
            this.label3.Text = "Тара";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(378, 281);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 24);
            this.label4.TabIndex = 15;
            this.label4.Text = "Статус";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(378, 73);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(178, 24);
            this.label5.TabIndex = 17;
            this.label5.Text = "Наименование ГП";
            // 
            // status_cbx
            // 
            this.status_cbx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.status_cbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.status_cbx.FormattingEnabled = true;
            this.status_cbx.Location = new System.Drawing.Point(378, 304);
            this.status_cbx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.status_cbx.Name = "status_cbx";
            this.status_cbx.Size = new System.Drawing.Size(273, 32);
            this.status_cbx.TabIndex = 18;
            // 
            // titleGP_cbx
            // 
            this.titleGP_cbx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.titleGP_cbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.titleGP_cbx.FormattingEnabled = true;
            this.titleGP_cbx.Location = new System.Drawing.Point(378, 101);
            this.titleGP_cbx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.titleGP_cbx.Name = "titleGP_cbx";
            this.titleGP_cbx.Size = new System.Drawing.Size(273, 32);
            this.titleGP_cbx.TabIndex = 19;
            // 
            // container_cbx
            // 
            this.container_cbx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.container_cbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.container_cbx.FormattingEnabled = true;
            this.container_cbx.Location = new System.Drawing.Point(378, 171);
            this.container_cbx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.container_cbx.Name = "container_cbx";
            this.container_cbx.Size = new System.Drawing.Size(273, 32);
            this.container_cbx.TabIndex = 20;
            // 
            // location_cbx
            // 
            this.location_cbx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.location_cbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.location_cbx.FormattingEnabled = true;
            this.location_cbx.Location = new System.Drawing.Point(378, 241);
            this.location_cbx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.location_cbx.Name = "location_cbx";
            this.location_cbx.Size = new System.Drawing.Size(273, 32);
            this.location_cbx.TabIndex = 21;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.AddOrder_btn);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.iconButton3);
            this.groupBox1.Controls.Add(this.label_cbx);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.status_cbx);
            this.groupBox1.Controls.Add(this.location_cbx);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.container_cbx);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.titleGP_cbx);
            this.groupBox1.Controls.Add(this.customer_cbx);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(87, 499);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(702, 436);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавление записи";
            // 
            // AddOrder_btn
            // 
            this.AddOrder_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddOrder_btn.Font = new System.Drawing.Font("Bahnschrift", 14F, System.Drawing.FontStyle.Bold);
            this.AddOrder_btn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.AddOrder_btn.IconColor = System.Drawing.Color.Black;
            this.AddOrder_btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.AddOrder_btn.Location = new System.Drawing.Point(44, 361);
            this.AddOrder_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddOrder_btn.Name = "AddOrder_btn";
            this.AddOrder_btn.Size = new System.Drawing.Size(250, 70);
            this.AddOrder_btn.TabIndex = 38;
            this.AddOrder_btn.Text = "Добавить";
            this.AddOrder_btn.UseVisualStyleBackColor = true;
            this.AddOrder_btn.Click += new System.EventHandler(this.AddOrder_btn_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker2.Location = new System.Drawing.Point(43, 243);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(273, 32);
            this.dateTimePicker2.TabIndex = 36;
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(40, 218);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(273, 24);
            this.label18.TabIndex = 35;
            this.label18.Text = "Предпологаемая дата окон.";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.Location = new System.Drawing.Point(43, 173);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(273, 32);
            this.dateTimePicker1.TabIndex = 34;
            // 
            // iconButton3
            // 
            this.iconButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButton3.Font = new System.Drawing.Font("Bahnschrift", 14F, System.Drawing.FontStyle.Bold);
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton3.IconColor = System.Drawing.Color.Black;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.Location = new System.Drawing.Point(378, 361);
            this.iconButton3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(273, 70);
            this.iconButton3.TabIndex = 33;
            this.iconButton3.Text = "Отмена";
            this.iconButton3.UseVisualStyleBackColor = true;
            this.iconButton3.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // label_cbx
            // 
            this.label_cbx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label_cbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.label_cbx.FormattingEnabled = true;
            this.label_cbx.Location = new System.Drawing.Point(43, 304);
            this.label_cbx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.label_cbx.Name = "label_cbx";
            this.label_cbx.Size = new System.Drawing.Size(273, 32);
            this.label_cbx.TabIndex = 32;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(40, 281);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 24);
            this.label9.TabIndex = 25;
            this.label9.Text = "Этикетка";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(40, 147);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(175, 24);
            this.label8.TabIndex = 26;
            this.label8.Text = "Дата заключения";
            // 
            // customer_cbx
            // 
            this.customer_cbx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.customer_cbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.customer_cbx.FormattingEnabled = true;
            this.customer_cbx.Location = new System.Drawing.Point(43, 101);
            this.customer_cbx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.customer_cbx.Name = "customer_cbx";
            this.customer_cbx.Size = new System.Drawing.Size(273, 32);
            this.customer_cbx.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 73);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 24);
            this.label7.TabIndex = 27;
            this.label7.Text = "Заказчик";
            // 
            // iconButton1
            // 
            this.iconButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButton1.Font = new System.Drawing.Font("Bahnschrift", 14F, System.Drawing.FontStyle.Bold);
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(69, 41);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(250, 70);
            this.iconButton1.TabIndex = 39;
            this.iconButton1.Text = "Производственный участок";
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // iconButton2
            // 
            this.iconButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButton2.Font = new System.Drawing.Font("Bahnschrift", 14F, System.Drawing.FontStyle.Bold);
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton2.IconColor = System.Drawing.Color.Black;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.Location = new System.Drawing.Point(69, 121);
            this.iconButton2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(250, 70);
            this.iconButton2.TabIndex = 40;
            this.iconButton2.Text = "Склад";
            this.iconButton2.UseVisualStyleBackColor = true;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // iconButton4
            // 
            this.iconButton4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButton4.Font = new System.Drawing.Font("Bahnschrift", 14F, System.Drawing.FontStyle.Bold);
            this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton4.IconColor = System.Drawing.Color.Black;
            this.iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton4.Location = new System.Drawing.Point(69, 201);
            this.iconButton4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Size = new System.Drawing.Size(250, 70);
            this.iconButton4.TabIndex = 41;
            this.iconButton4.Text = "Отгружен";
            this.iconButton4.UseVisualStyleBackColor = true;
            this.iconButton4.Click += new System.EventHandler(this.iconButton4_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.iconButton1);
            this.groupBox2.Controls.Add(this.iconButton4);
            this.groupBox2.Controls.Add(this.iconButton2);
            this.groupBox2.Location = new System.Drawing.Point(865, 552);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(377, 305);
            this.groupBox2.TabIndex = 42;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Изменение местоположения заказа";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.iconButton5);
            this.groupBox3.Controls.Add(this.iconButton6);
            this.groupBox3.Controls.Add(this.iconButton7);
            this.groupBox3.Location = new System.Drawing.Point(1248, 552);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(377, 305);
            this.groupBox3.TabIndex = 43;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Изменение статуса заказа";
            // 
            // iconButton5
            // 
            this.iconButton5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButton5.Font = new System.Drawing.Font("Bahnschrift", 14F, System.Drawing.FontStyle.Bold);
            this.iconButton5.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton5.IconColor = System.Drawing.Color.Black;
            this.iconButton5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton5.Location = new System.Drawing.Point(39, 41);
            this.iconButton5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.iconButton5.Name = "iconButton5";
            this.iconButton5.Size = new System.Drawing.Size(312, 70);
            this.iconButton5.TabIndex = 39;
            this.iconButton5.Text = "Согласование с Главным химиком";
            this.iconButton5.UseVisualStyleBackColor = true;
            this.iconButton5.Click += new System.EventHandler(this.iconButton5_Click);
            // 
            // iconButton6
            // 
            this.iconButton6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButton6.Font = new System.Drawing.Font("Bahnschrift", 14F, System.Drawing.FontStyle.Bold);
            this.iconButton6.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton6.IconColor = System.Drawing.Color.Black;
            this.iconButton6.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton6.Location = new System.Drawing.Point(69, 201);
            this.iconButton6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.iconButton6.Name = "iconButton6";
            this.iconButton6.Size = new System.Drawing.Size(250, 70);
            this.iconButton6.TabIndex = 41;
            this.iconButton6.Text = "Закрыт";
            this.iconButton6.UseVisualStyleBackColor = true;
            this.iconButton6.Click += new System.EventHandler(this.iconButton6_Click);
            // 
            // iconButton7
            // 
            this.iconButton7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButton7.Font = new System.Drawing.Font("Bahnschrift", 14F, System.Drawing.FontStyle.Bold);
            this.iconButton7.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton7.IconColor = System.Drawing.Color.Black;
            this.iconButton7.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton7.Location = new System.Drawing.Point(69, 121);
            this.iconButton7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.iconButton7.Name = "iconButton7";
            this.iconButton7.Size = new System.Drawing.Size(250, 70);
            this.iconButton7.TabIndex = 40;
            this.iconButton7.Text = "Активен";
            this.iconButton7.UseVisualStyleBackColor = true;
            this.iconButton7.Click += new System.EventHandler(this.iconButton7_Click);
            // 
            // id_order
            // 
            this.id_order.DataPropertyName = "id_order";
            this.id_order.HeaderText = "№ Заказа";
            this.id_order.MinimumWidth = 6;
            this.id_order.Name = "id_order";
            this.id_order.ReadOnly = true;
            this.id_order.Width = 130;
            // 
            // name_customer
            // 
            this.name_customer.DataPropertyName = "name_customer";
            this.name_customer.HeaderText = "Заказчик";
            this.name_customer.MinimumWidth = 6;
            this.name_customer.Name = "name_customer";
            this.name_customer.ReadOnly = true;
            this.name_customer.Width = 125;
            // 
            // data_order_formation
            // 
            this.data_order_formation.DataPropertyName = "data_order_formation";
            this.data_order_formation.HeaderText = "Дата заключения";
            this.data_order_formation.MinimumWidth = 6;
            this.data_order_formation.Name = "data_order_formation";
            this.data_order_formation.ReadOnly = true;
            this.data_order_formation.Width = 135;
            // 
            // end_date_agreement
            // 
            this.end_date_agreement.DataPropertyName = "end_date_agreement";
            this.end_date_agreement.HeaderText = "Дата окончания";
            this.end_date_agreement.MinimumWidth = 6;
            this.end_date_agreement.Name = "end_date_agreement";
            this.end_date_agreement.ReadOnly = true;
            this.end_date_agreement.Width = 125;
            // 
            // title_label
            // 
            this.title_label.DataPropertyName = "title_label";
            this.title_label.HeaderText = "Этикетка";
            this.title_label.MinimumWidth = 6;
            this.title_label.Name = "title_label";
            this.title_label.ReadOnly = true;
            this.title_label.Width = 225;
            // 
            // titleGP
            // 
            this.titleGP.DataPropertyName = "titleGP";
            this.titleGP.HeaderText = "Наименование ГП";
            this.titleGP.MinimumWidth = 6;
            this.titleGP.Name = "titleGP";
            this.titleGP.ReadOnly = true;
            this.titleGP.Width = 105;
            // 
            // title_container
            // 
            this.title_container.DataPropertyName = "title_container";
            this.title_container.HeaderText = "Тара";
            this.title_container.MinimumWidth = 6;
            this.title_container.Name = "title_container";
            this.title_container.ReadOnly = true;
            this.title_container.Width = 140;
            // 
            // title_location
            // 
            this.title_location.DataPropertyName = "title_location";
            this.title_location.HeaderText = "Местоположение";
            this.title_location.MinimumWidth = 6;
            this.title_location.Name = "title_location";
            this.title_location.ReadOnly = true;
            this.title_location.Width = 270;
            // 
            // title_status
            // 
            this.title_status.DataPropertyName = "title_status";
            this.title_status.HeaderText = "Статус";
            this.title_status.MinimumWidth = 6;
            this.title_status.Name = "title_status";
            this.title_status.ReadOnly = true;
            this.title_status.Width = 300;
            // 
            // FormOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1687, 949);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(104)))), ((int)(((byte)(220)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormOrders";
            this.Text = "Заказы";
            this.Load += new System.EventHandler(this.FormOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bSBAIKALDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bS_BAIKALDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private BS_BAIKALDataSet bS_BAIKALDataSet;
        private System.Windows.Forms.BindingSource bSBAIKALDataSetBindingSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox status_cbx;
        private System.Windows.Forms.ComboBox titleGP_cbx;
        private System.Windows.Forms.ComboBox container_cbx;
        private System.Windows.Forms.ComboBox location_cbx;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox label_cbx;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox customer_cbx;
        private System.Windows.Forms.Label label7;
        private FontAwesome.Sharp.IconButton iconButton3;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private FontAwesome.Sharp.IconButton AddOrder_btn;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private FontAwesome.Sharp.IconButton iconButton5;
        private FontAwesome.Sharp.IconButton iconButton6;
        private FontAwesome.Sharp.IconButton iconButton7;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_order;
        private System.Windows.Forms.DataGridViewTextBoxColumn name_customer;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_order_formation;
        private System.Windows.Forms.DataGridViewTextBoxColumn end_date_agreement;
        private System.Windows.Forms.DataGridViewTextBoxColumn title_label;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleGP;
        private System.Windows.Forms.DataGridViewTextBoxColumn title_container;
        private System.Windows.Forms.DataGridViewTextBoxColumn title_location;
        private System.Windows.Forms.DataGridViewTextBoxColumn title_status;
    }
}