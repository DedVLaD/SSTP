namespace Business_System_BAIKAL.Forms
{
    partial class FormLaboratory
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id_composition_order = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.composition_order = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weight_kg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.UpdateCompositionOrder_btn1 = new FontAwesome.Sharp.IconButton();
            this.button1 = new System.Windows.Forms.Button();
            this.UpdateCompositionOrder_btn = new System.Windows.Forms.Button();
            this.WeightKG_txt = new System.Windows.Forms.TextBox();
            this.Passport_txt = new System.Windows.Forms.TextBox();
            this.CompositionOrder_txt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_composition_order,
            this.composition_order,
            this.passport,
            this.weight_kg});
            this.dataGridView1.Location = new System.Drawing.Point(20, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(953, 853);
            this.dataGridView1.TabIndex = 0;
            // 
            // id_composition_order
            // 
            this.id_composition_order.DataPropertyName = "id_composition_order";
            this.id_composition_order.HeaderText = "№ заказа";
            this.id_composition_order.MinimumWidth = 6;
            this.id_composition_order.Name = "id_composition_order";
            this.id_composition_order.ReadOnly = true;
            this.id_composition_order.Width = 130;
            // 
            // composition_order
            // 
            this.composition_order.DataPropertyName = "composition_order";
            this.composition_order.HeaderText = "Состав заказа";
            this.composition_order.MinimumWidth = 6;
            this.composition_order.Name = "composition_order";
            this.composition_order.ReadOnly = true;
            this.composition_order.Width = 300;
            // 
            // passport
            // 
            this.passport.DataPropertyName = "passport";
            this.passport.HeaderText = "Паспорт";
            this.passport.MinimumWidth = 6;
            this.passport.Name = "passport";
            this.passport.ReadOnly = true;
            this.passport.Width = 300;
            // 
            // weight_kg
            // 
            this.weight_kg.DataPropertyName = "weight_kg";
            this.weight_kg.HeaderText = "Масса (кг)";
            this.weight_kg.MinimumWidth = 6;
            this.weight_kg.Name = "weight_kg";
            this.weight_kg.ReadOnly = true;
            this.weight_kg.Width = 140;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.UpdateCompositionOrder_btn1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.UpdateCompositionOrder_btn);
            this.groupBox1.Controls.Add(this.WeightKG_txt);
            this.groupBox1.Controls.Add(this.Passport_txt);
            this.groupBox1.Controls.Add(this.CompositionOrder_txt);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(1107, 33);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(490, 261);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Редактирование записи";
            // 
            // UpdateCompositionOrder_btn1
            // 
            this.UpdateCompositionOrder_btn1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.UpdateCompositionOrder_btn1.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.UpdateCompositionOrder_btn1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(104)))), ((int)(((byte)(220)))));
            this.UpdateCompositionOrder_btn1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.UpdateCompositionOrder_btn1.Location = new System.Drawing.Point(418, 55);
            this.UpdateCompositionOrder_btn1.Name = "UpdateCompositionOrder_btn1";
            this.UpdateCompositionOrder_btn1.Size = new System.Drawing.Size(60, 49);
            this.UpdateCompositionOrder_btn1.TabIndex = 27;
            this.UpdateCompositionOrder_btn1.UseVisualStyleBackColor = true;
            this.UpdateCompositionOrder_btn1.Click += new System.EventHandler(this.UpdateCompositionOrder_btn1_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(267, 121);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(211, 49);
            this.button1.TabIndex = 43;
            this.button1.Text = "Отмена";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UpdateCompositionOrder_btn
            // 
            this.UpdateCompositionOrder_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.UpdateCompositionOrder_btn.Location = new System.Drawing.Point(267, 55);
            this.UpdateCompositionOrder_btn.Name = "UpdateCompositionOrder_btn";
            this.UpdateCompositionOrder_btn.Size = new System.Drawing.Size(150, 49);
            this.UpdateCompositionOrder_btn.TabIndex = 26;
            this.UpdateCompositionOrder_btn.Text = "Изменить";
            this.UpdateCompositionOrder_btn.UseVisualStyleBackColor = true;
            this.UpdateCompositionOrder_btn.Click += new System.EventHandler(this.UpdateCompositionOrder_btn_Click);
            // 
            // WeightKG_txt
            // 
            this.WeightKG_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.WeightKG_txt.Location = new System.Drawing.Point(12, 203);
            this.WeightKG_txt.Name = "WeightKG_txt";
            this.WeightKG_txt.Size = new System.Drawing.Size(208, 32);
            this.WeightKG_txt.TabIndex = 41;
            this.WeightKG_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.WeightKG_txt_KeyPress);
            // 
            // Passport_txt
            // 
            this.Passport_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Passport_txt.Location = new System.Drawing.Point(12, 138);
            this.Passport_txt.Name = "Passport_txt";
            this.Passport_txt.Size = new System.Drawing.Size(208, 32);
            this.Passport_txt.TabIndex = 40;
            // 
            // CompositionOrder_txt
            // 
            this.CompositionOrder_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CompositionOrder_txt.Location = new System.Drawing.Point(12, 72);
            this.CompositionOrder_txt.Name = "CompositionOrder_txt";
            this.CompositionOrder_txt.Size = new System.Drawing.Size(208, 32);
            this.CompositionOrder_txt.TabIndex = 39;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 111);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 24);
            this.label9.TabIndex = 25;
            this.label9.Text = "Паспорт";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 45);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 24);
            this.label7.TabIndex = 27;
            this.label7.Text = "Состав заказа";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 176);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 24);
            this.label5.TabIndex = 17;
            this.label5.Text = "Масса (кг)";
            // 
            // FormLaboratory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1687, 949);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(104)))), ((int)(((byte)(220)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormLaboratory";
            this.Text = "Лаборатория";
            this.Load += new System.EventHandler(this.FormLaboratory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_composition_order;
        private System.Windows.Forms.DataGridViewTextBoxColumn composition_order;
        private System.Windows.Forms.DataGridViewTextBoxColumn passport;
        private System.Windows.Forms.DataGridViewTextBoxColumn weight_kg;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox WeightKG_txt;
        private System.Windows.Forms.TextBox Passport_txt;
        private System.Windows.Forms.TextBox CompositionOrder_txt;
        private System.Windows.Forms.Button button1;
        private FontAwesome.Sharp.IconButton UpdateCompositionOrder_btn1;
        private System.Windows.Forms.Button UpdateCompositionOrder_btn;
    }
}