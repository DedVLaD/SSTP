namespace Business_System_BAIKAL
{
    partial class FormMain
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnCloseUser = new FontAwesome.Sharp.IconButton();
            this.btnLaboratory = new FontAwesome.Sharp.IconButton();
            this.btnParameters = new FontAwesome.Sharp.IconButton();
            this.btnStatistics = new FontAwesome.Sharp.IconButton();
            this.btnProductions = new FontAwesome.Sharp.IconButton();
            this.btnOrders = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.lblPositionUser = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.exit = new FontAwesome.Sharp.IconButton();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.panelShadow = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(233)))), ((int)(((byte)(255)))));
            this.panelMenu.Controls.Add(this.btnCloseUser);
            this.panelMenu.Controls.Add(this.btnLaboratory);
            this.panelMenu.Controls.Add(this.btnParameters);
            this.panelMenu.Controls.Add(this.btnStatistics);
            this.panelMenu.Controls.Add(this.btnProductions);
            this.panelMenu.Controls.Add(this.btnOrders);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(231, 1033);
            this.panelMenu.TabIndex = 0;
            // 
            // btnCloseUser
            // 
            this.btnCloseUser.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCloseUser.FlatAppearance.BorderSize = 0;
            this.btnCloseUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseUser.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCloseUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(104)))), ((int)(((byte)(220)))));
            this.btnCloseUser.IconChar = FontAwesome.Sharp.IconChar.PersonWalkingArrowLoopLeft;
            this.btnCloseUser.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(104)))), ((int)(((byte)(220)))));
            this.btnCloseUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCloseUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCloseUser.Location = new System.Drawing.Point(0, 973);
            this.btnCloseUser.Name = "btnCloseUser";
            this.btnCloseUser.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnCloseUser.Size = new System.Drawing.Size(231, 60);
            this.btnCloseUser.TabIndex = 8;
            this.btnCloseUser.Text = "Сменить пользователя";
            this.btnCloseUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCloseUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCloseUser.UseVisualStyleBackColor = true;
            this.btnCloseUser.Click += new System.EventHandler(this.btnCloseUser_Click);
            // 
            // btnLaboratory
            // 
            this.btnLaboratory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLaboratory.FlatAppearance.BorderSize = 0;
            this.btnLaboratory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLaboratory.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLaboratory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(104)))), ((int)(((byte)(220)))));
            this.btnLaboratory.IconChar = FontAwesome.Sharp.IconChar.Flask;
            this.btnLaboratory.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(104)))), ((int)(((byte)(220)))));
            this.btnLaboratory.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLaboratory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLaboratory.Location = new System.Drawing.Point(0, 205);
            this.btnLaboratory.Name = "btnLaboratory";
            this.btnLaboratory.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnLaboratory.Size = new System.Drawing.Size(231, 60);
            this.btnLaboratory.TabIndex = 3;
            this.btnLaboratory.Text = "Лаборатория";
            this.btnLaboratory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLaboratory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLaboratory.UseVisualStyleBackColor = true;
            this.btnLaboratory.Click += new System.EventHandler(this.btnLaboratory_Click);
            // 
            // btnParameters
            // 
            this.btnParameters.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnParameters.FlatAppearance.BorderSize = 0;
            this.btnParameters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnParameters.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnParameters.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(104)))), ((int)(((byte)(220)))));
            this.btnParameters.IconChar = FontAwesome.Sharp.IconChar.Gears;
            this.btnParameters.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(104)))), ((int)(((byte)(220)))));
            this.btnParameters.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnParameters.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnParameters.Location = new System.Drawing.Point(0, 400);
            this.btnParameters.Name = "btnParameters";
            this.btnParameters.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnParameters.Size = new System.Drawing.Size(231, 60);
            this.btnParameters.TabIndex = 5;
            this.btnParameters.Text = "Параметры";
            this.btnParameters.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnParameters.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnParameters.UseVisualStyleBackColor = true;
            this.btnParameters.Click += new System.EventHandler(this.btnParameters_Click);
            // 
            // btnStatistics
            // 
            this.btnStatistics.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStatistics.FlatAppearance.BorderSize = 0;
            this.btnStatistics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatistics.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStatistics.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(104)))), ((int)(((byte)(220)))));
            this.btnStatistics.IconChar = FontAwesome.Sharp.IconChar.ChartColumn;
            this.btnStatistics.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(104)))), ((int)(((byte)(220)))));
            this.btnStatistics.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnStatistics.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStatistics.Location = new System.Drawing.Point(0, 335);
            this.btnStatistics.Name = "btnStatistics";
            this.btnStatistics.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnStatistics.Size = new System.Drawing.Size(231, 60);
            this.btnStatistics.TabIndex = 4;
            this.btnStatistics.Text = "Статистика";
            this.btnStatistics.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStatistics.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStatistics.UseVisualStyleBackColor = true;
            this.btnStatistics.Click += new System.EventHandler(this.btnStatistics_Click);
            // 
            // btnProductions
            // 
            this.btnProductions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProductions.FlatAppearance.BorderSize = 0;
            this.btnProductions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductions.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnProductions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(104)))), ((int)(((byte)(220)))));
            this.btnProductions.IconChar = FontAwesome.Sharp.IconChar.Building;
            this.btnProductions.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(104)))), ((int)(((byte)(220)))));
            this.btnProductions.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnProductions.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductions.Location = new System.Drawing.Point(0, 270);
            this.btnProductions.Name = "btnProductions";
            this.btnProductions.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnProductions.Size = new System.Drawing.Size(231, 60);
            this.btnProductions.TabIndex = 2;
            this.btnProductions.Text = "Производство";
            this.btnProductions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductions.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProductions.UseVisualStyleBackColor = true;
            this.btnProductions.Click += new System.EventHandler(this.btnProductions_Click);
            // 
            // btnOrders
            // 
            this.btnOrders.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOrders.FlatAppearance.BorderSize = 0;
            this.btnOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrders.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOrders.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(104)))), ((int)(((byte)(220)))));
            this.btnOrders.IconChar = FontAwesome.Sharp.IconChar.ListCheck;
            this.btnOrders.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(104)))), ((int)(((byte)(220)))));
            this.btnOrders.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnOrders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrders.Location = new System.Drawing.Point(0, 140);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnOrders.Size = new System.Drawing.Size(231, 60);
            this.btnOrders.TabIndex = 1;
            this.btnOrders.Text = "Заказы";
            this.btnOrders.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrders.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOrders.UseVisualStyleBackColor = true;
            this.btnOrders.Click += new System.EventHandler(this.btnOrders_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.btnHome);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(231, 140);
            this.panelLogo.TabIndex = 0;
            // 
            // btnHome
            // 
            this.btnHome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHome.Image = global::Business_System_BAIKAL.Properties.Resources.logo_baikal1;
            this.btnHome.Location = new System.Drawing.Point(3, 12);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(214, 122);
            this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHome.TabIndex = 0;
            this.btnHome.TabStop = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(233)))), ((int)(((byte)(255)))));
            this.panelTitleBar.Controls.Add(this.lblPositionUser);
            this.panelTitleBar.Controls.Add(this.lblUserName);
            this.panelTitleBar.Controls.Add(this.iconButton2);
            this.panelTitleBar.Controls.Add(this.iconButton1);
            this.panelTitleBar.Controls.Add(this.exit);
            this.panelTitleBar.Controls.Add(this.lblTitleChildForm);
            this.panelTitleBar.Controls.Add(this.iconCurrentChildForm);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(231, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1687, 75);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // lblPositionUser
            // 
            this.lblPositionUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPositionUser.AutoSize = true;
            this.lblPositionUser.Font = new System.Drawing.Font("Bahnschrift SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPositionUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(104)))), ((int)(((byte)(220)))));
            this.lblPositionUser.Location = new System.Drawing.Point(919, 31);
            this.lblPositionUser.Name = "lblPositionUser";
            this.lblPositionUser.Size = new System.Drawing.Size(17, 28);
            this.lblPositionUser.TabIndex = 6;
            this.lblPositionUser.Text = ".";
            // 
            // lblUserName
            // 
            this.lblUserName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Bahnschrift SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(104)))), ((int)(((byte)(220)))));
            this.lblUserName.Location = new System.Drawing.Point(315, 31);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(17, 28);
            this.lblUserName.TabIndex = 5;
            this.lblUserName.Text = ".";
            // 
            // iconButton2
            // 
            this.iconButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.iconButton2.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(104)))), ((int)(((byte)(220)))));
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 28;
            this.iconButton2.Location = new System.Drawing.Point(1567, 23);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(32, 36);
            this.iconButton2.TabIndex = 4;
            this.iconButton2.UseVisualStyleBackColor = false;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.WindowRestore;
            this.iconButton1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(104)))), ((int)(((byte)(220)))));
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 28;
            this.iconButton1.Location = new System.Drawing.Point(1605, 23);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(32, 36);
            this.iconButton1.TabIndex = 3;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // exit
            // 
            this.exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exit.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.exit.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(104)))), ((int)(((byte)(220)))));
            this.exit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.exit.IconSize = 28;
            this.exit.Location = new System.Drawing.Point(1643, 23);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(32, 36);
            this.exit.TabIndex = 2;
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // lblTitleChildForm
            // 
            this.lblTitleChildForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitleChildForm.AutoSize = true;
            this.lblTitleChildForm.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitleChildForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(104)))), ((int)(((byte)(220)))));
            this.lblTitleChildForm.Location = new System.Drawing.Point(44, 31);
            this.lblTitleChildForm.Name = "lblTitleChildForm";
            this.lblTitleChildForm.Size = new System.Drawing.Size(73, 28);
            this.lblTitleChildForm.TabIndex = 1;
            this.lblTitleChildForm.Text = "Home";
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(233)))), ((int)(((byte)(255)))));
            this.iconCurrentChildForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(104)))), ((int)(((byte)(220)))));
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.House;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(104)))), ((int)(((byte)(220)))));
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(6, 27);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(32, 32);
            this.iconCurrentChildForm.TabIndex = 0;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // panelShadow
            // 
            this.panelShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(233)))), ((int)(((byte)(255)))));
            this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShadow.Location = new System.Drawing.Point(231, 75);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(1687, 9);
            this.panelShadow.TabIndex = 2;
            // 
            // panelDesktop
            // 
            this.panelDesktop.Controls.Add(this.pictureBox1);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(231, 84);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1687, 949);
            this.panelDesktop.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::Business_System_BAIKAL.Properties.Resources.logo_baikal;
            this.pictureBox1.Location = new System.Drawing.Point(698, 328);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(335, 204);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1918, 1033);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelShadow);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(1600, 900);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.panelDesktop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton btnOrders;
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconButton btnParameters;
        private FontAwesome.Sharp.IconButton btnStatistics;
        private FontAwesome.Sharp.IconButton btnLaboratory;
        private FontAwesome.Sharp.IconButton btnProductions;
        private System.Windows.Forms.PictureBox btnHome;
        private System.Windows.Forms.Panel panelTitleBar;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Label lblTitleChildForm;
        private System.Windows.Forms.Panel panelShadow;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton exit;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblPositionUser;
        private FontAwesome.Sharp.IconButton btnCloseUser;
    }
}