namespace ZooPark
{
    partial class EmployerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployerForm));
            this.EmployerDataGrid = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.SelectButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.EmployerButton = new System.Windows.Forms.ToolStripMenuItem();
            this.DutyButton = new System.Windows.Forms.ToolStripMenuItem();
            this.PostButton = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.InsertButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.EmployerInsertButton = new System.Windows.Forms.ToolStripMenuItem();
            this.DutyInsertButton = new System.Windows.Forms.ToolStripMenuItem();
            this.DutyBox = new System.Windows.Forms.ToolStripComboBox();
            this.DutyDateTb = new System.Windows.Forms.ToolStripTextBox();
            this.DutyInsertButtonConf = new System.Windows.Forms.ToolStripMenuItem();
            this.PostInsertButton = new System.Windows.Forms.ToolStripMenuItem();
            this.PostNameTb = new System.Windows.Forms.ToolStripTextBox();
            this.PostSalaryTb = new System.Windows.Forms.ToolStripTextBox();
            this.PostInsertButtonConf = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.EditButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.EmployerEditButton = new System.Windows.Forms.ToolStripMenuItem();
            this.DutyEditButton = new System.Windows.Forms.ToolStripMenuItem();
            this.DutyEditEmployerBox = new System.Windows.Forms.ToolStripComboBox();
            this.DutyEditDateBox = new System.Windows.Forms.ToolStripComboBox();
            this.DutyEditButtonConf = new System.Windows.Forms.ToolStripMenuItem();
            this.PostEditButton = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.DutyDataGrid = new System.Windows.Forms.DataGridView();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PostDataGrid = new System.Windows.Forms.DataGridView();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.DeleteEmployerButton = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteEmployerBox = new System.Windows.Forms.ToolStripComboBox();
            this.DeleteEmployerButtonConf = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteDutyButton = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteDutyBox = new System.Windows.Forms.ToolStripComboBox();
            this.DeleteDutyButtonConf = new System.Windows.Forms.ToolStripMenuItem();
            this.DeletePostButton = new System.Windows.Forms.ToolStripMenuItem();
            this.DeletePostBox = new System.Windows.Forms.ToolStripComboBox();
            this.DeletePostButtonConf = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.EmployerDataGrid)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DutyDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PostDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // EmployerDataGrid
            // 
            this.EmployerDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployerDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.EmployerDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EmployerDataGrid.Location = new System.Drawing.Point(0, 33);
            this.EmployerDataGrid.Name = "EmployerDataGrid";
            this.EmployerDataGrid.RowTemplate.Height = 24;
            this.EmployerDataGrid.Size = new System.Drawing.Size(1000, 417);
            this.EmployerDataGrid.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "ФИО";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Возраст";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Должность";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Зоопарк";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Телефон";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Email";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "ИНН";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Дата принятия";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SelectButton,
            this.toolStripSeparator4,
            this.InsertButton,
            this.toolStripSeparator1,
            this.EditButton,
            this.toolStripSeparator2,
            this.DeleteButton,
            this.toolStripSeparator3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1000, 33);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // SelectButton
            // 
            this.SelectButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.SelectButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EmployerButton,
            this.DutyButton,
            this.PostButton});
            this.SelectButton.Image = ((System.Drawing.Image)(resources.GetObject("SelectButton.Image")));
            this.SelectButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SelectButton.Name = "SelectButton";
            this.SelectButton.Size = new System.Drawing.Size(82, 30);
            this.SelectButton.Text = "Таблица";
            // 
            // EmployerButton
            // 
            this.EmployerButton.Name = "EmployerButton";
            this.EmployerButton.Size = new System.Drawing.Size(166, 26);
            this.EmployerButton.Text = "Сотрудники";
            this.EmployerButton.Click += new System.EventHandler(this.EmployerGrid_Fill);
            // 
            // DutyButton
            // 
            this.DutyButton.Name = "DutyButton";
            this.DutyButton.Size = new System.Drawing.Size(166, 26);
            this.DutyButton.Text = "Дежурства";
            this.DutyButton.Click += new System.EventHandler(this.DutyGrid_Fill);
            // 
            // PostButton
            // 
            this.PostButton.Name = "PostButton";
            this.PostButton.Size = new System.Drawing.Size(166, 26);
            this.PostButton.Text = "Должности";
            this.PostButton.Click += new System.EventHandler(this.PostGrid_Fill);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 33);
            // 
            // InsertButton
            // 
            this.InsertButton.AutoSize = false;
            this.InsertButton.BackColor = System.Drawing.Color.GhostWhite;
            this.InsertButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.InsertButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EmployerInsertButton,
            this.DutyInsertButton,
            this.PostInsertButton});
            this.InsertButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InsertButton.Image = ((System.Drawing.Image)(resources.GetObject("InsertButton.Image")));
            this.InsertButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.InsertButton.Name = "InsertButton";
            this.InsertButton.Size = new System.Drawing.Size(90, 30);
            this.InsertButton.Text = "Добавить";
            // 
            // EmployerInsertButton
            // 
            this.EmployerInsertButton.Name = "EmployerInsertButton";
            this.EmployerInsertButton.Size = new System.Drawing.Size(223, 26);
            this.EmployerInsertButton.Text = "Сотрудника";
            this.EmployerInsertButton.Click += new System.EventHandler(this.EmployerInsertButton_Click);
            // 
            // DutyInsertButton
            // 
            this.DutyInsertButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DutyBox,
            this.DutyDateTb,
            this.DutyInsertButtonConf});
            this.DutyInsertButton.Name = "DutyInsertButton";
            this.DutyInsertButton.Size = new System.Drawing.Size(223, 26);
            this.DutyInsertButton.Text = "Запись дежурства";
            this.DutyInsertButton.Click += new System.EventHandler(this.DutyInsertButton_Click);
            // 
            // DutyBox
            // 
            this.DutyBox.Name = "DutyBox";
            this.DutyBox.Size = new System.Drawing.Size(200, 28);
            // 
            // DutyDateTb
            // 
            this.DutyDateTb.Name = "DutyDateTb";
            this.DutyDateTb.Size = new System.Drawing.Size(200, 27);
            this.DutyDateTb.Text = "дд.мм.гггг";
            this.DutyDateTb.Click += new System.EventHandler(this.DutyDateTb_Click);
            // 
            // DutyInsertButtonConf
            // 
            this.DutyInsertButtonConf.Name = "DutyInsertButtonConf";
            this.DutyInsertButtonConf.Size = new System.Drawing.Size(266, 26);
            this.DutyInsertButtonConf.Text = "Добавить";
            this.DutyInsertButtonConf.Click += new System.EventHandler(this.DutyInsertButtonConf_Click);
            // 
            // PostInsertButton
            // 
            this.PostInsertButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PostNameTb,
            this.PostSalaryTb,
            this.PostInsertButtonConf});
            this.PostInsertButton.Name = "PostInsertButton";
            this.PostInsertButton.Size = new System.Drawing.Size(223, 26);
            this.PostInsertButton.Text = "Должность";
            // 
            // PostNameTb
            // 
            this.PostNameTb.Name = "PostNameTb";
            this.PostNameTb.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PostNameTb.Size = new System.Drawing.Size(145, 27);
            this.PostNameTb.Text = "Название";
            this.PostNameTb.Click += new System.EventHandler(this.PostNameTb_Click);
            // 
            // PostSalaryTb
            // 
            this.PostSalaryTb.Name = "PostSalaryTb";
            this.PostSalaryTb.Size = new System.Drawing.Size(145, 27);
            this.PostSalaryTb.Text = "Зарплата";
            this.PostSalaryTb.Click += new System.EventHandler(this.PostSalaryTb_Click);
            // 
            // PostInsertButtonConf
            // 
            this.PostInsertButtonConf.Name = "PostInsertButtonConf";
            this.PostInsertButtonConf.Size = new System.Drawing.Size(211, 26);
            this.PostInsertButtonConf.Text = "Добавить";
            this.PostInsertButtonConf.Click += new System.EventHandler(this.PostInsertButtonConf_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 33);
            // 
            // EditButton
            // 
            this.EditButton.AutoSize = false;
            this.EditButton.BackColor = System.Drawing.Color.GhostWhite;
            this.EditButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.EditButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EmployerEditButton,
            this.DutyEditButton,
            this.PostEditButton});
            this.EditButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditButton.Image = ((System.Drawing.Image)(resources.GetObject("EditButton.Image")));
            this.EditButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(110, 30);
            this.EditButton.Text = "Редактировать";
            // 
            // EmployerEditButton
            // 
            this.EmployerEditButton.Name = "EmployerEditButton";
            this.EmployerEditButton.Size = new System.Drawing.Size(223, 26);
            this.EmployerEditButton.Text = "Сотрудника";
            this.EmployerEditButton.Click += new System.EventHandler(this.EmployerEditButton_Click);
            // 
            // DutyEditButton
            // 
            this.DutyEditButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DutyEditEmployerBox,
            this.DutyEditDateBox,
            this.DutyEditButtonConf});
            this.DutyEditButton.Name = "DutyEditButton";
            this.DutyEditButton.Size = new System.Drawing.Size(223, 26);
            this.DutyEditButton.Text = "Запись дежурства";
            this.DutyEditButton.Click += new System.EventHandler(this.DutyEditButton_Click);
            // 
            // DutyEditEmployerBox
            // 
            this.DutyEditEmployerBox.Name = "DutyEditEmployerBox";
            this.DutyEditEmployerBox.Size = new System.Drawing.Size(200, 28);
            // 
            // DutyEditDateBox
            // 
            this.DutyEditDateBox.Name = "DutyEditDateBox";
            this.DutyEditDateBox.Size = new System.Drawing.Size(200, 28);
            this.DutyEditDateBox.SelectedIndexChanged += new System.EventHandler(this.DutyEditDateBox_SelectedIndexChanged);
            // 
            // DutyEditButtonConf
            // 
            this.DutyEditButtonConf.Name = "DutyEditButtonConf";
            this.DutyEditButtonConf.Size = new System.Drawing.Size(266, 26);
            this.DutyEditButtonConf.Text = "Редактировать";
            this.DutyEditButtonConf.Click += new System.EventHandler(this.DutyEditButtonConf_Click);
            // 
            // PostEditButton
            // 
            this.PostEditButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox1,
            this.toolStripTextBox1});
            this.PostEditButton.Name = "PostEditButton";
            this.PostEditButton.Size = new System.Drawing.Size(223, 26);
            this.PostEditButton.Text = "Должность";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 28);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 27);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 33);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 33);
            // 
            // DutyDataGrid
            // 
            this.DutyDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DutyDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column10,
            this.Column11});
            this.DutyDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DutyDataGrid.Location = new System.Drawing.Point(0, 33);
            this.DutyDataGrid.Name = "DutyDataGrid";
            this.DutyDataGrid.RowTemplate.Height = 24;
            this.DutyDataGrid.Size = new System.Drawing.Size(1000, 417);
            this.DutyDataGrid.TabIndex = 3;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Сотрудник";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Дата дежурства";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            // 
            // PostDataGrid
            // 
            this.PostDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PostDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column12,
            this.Column13,
            this.Column14});
            this.PostDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PostDataGrid.Location = new System.Drawing.Point(0, 33);
            this.PostDataGrid.Name = "PostDataGrid";
            this.PostDataGrid.RowTemplate.Height = 24;
            this.PostDataGrid.Size = new System.Drawing.Size(1000, 417);
            this.PostDataGrid.TabIndex = 4;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "ID";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            // 
            // Column13
            // 
            this.Column13.HeaderText = "Название";
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            // 
            // Column14
            // 
            this.Column14.HeaderText = "Зарплата";
            this.Column14.Name = "Column14";
            this.Column14.ReadOnly = true;
            // 
            // DeleteButton
            // 
            this.DeleteButton.AutoSize = false;
            this.DeleteButton.BackColor = System.Drawing.Color.GhostWhite;
            this.DeleteButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.DeleteButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DeleteEmployerButton,
            this.DeleteDutyButton,
            this.DeletePostButton});
            this.DeleteButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.Image = ((System.Drawing.Image)(resources.GetObject("DeleteButton.Image")));
            this.DeleteButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(110, 30);
            this.DeleteButton.Text = "Удалить";
            // 
            // DeleteEmployerButton
            // 
            this.DeleteEmployerButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DeleteEmployerBox,
            this.DeleteEmployerButtonConf});
            this.DeleteEmployerButton.Name = "DeleteEmployerButton";
            this.DeleteEmployerButton.Size = new System.Drawing.Size(223, 26);
            this.DeleteEmployerButton.Text = "Сотрудника";
            this.DeleteEmployerButton.Click += new System.EventHandler(this.DeleteEmployerButton_Click);
            // 
            // DeleteEmployerBox
            // 
            this.DeleteEmployerBox.Name = "DeleteEmployerBox";
            this.DeleteEmployerBox.Size = new System.Drawing.Size(200, 28);
            // 
            // DeleteEmployerButtonConf
            // 
            this.DeleteEmployerButtonConf.Name = "DeleteEmployerButtonConf";
            this.DeleteEmployerButtonConf.Size = new System.Drawing.Size(266, 26);
            this.DeleteEmployerButtonConf.Text = "Удалить";
            this.DeleteEmployerButtonConf.Click += new System.EventHandler(this.DeleteEmployerButtonConf_Click);
            // 
            // DeleteDutyButton
            // 
            this.DeleteDutyButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DeleteDutyBox,
            this.DeleteDutyButtonConf});
            this.DeleteDutyButton.Name = "DeleteDutyButton";
            this.DeleteDutyButton.Size = new System.Drawing.Size(223, 26);
            this.DeleteDutyButton.Text = "Запись дежурства";
            this.DeleteDutyButton.Click += new System.EventHandler(this.DeleteDutyButton_Click);
            // 
            // DeleteDutyBox
            // 
            this.DeleteDutyBox.Name = "DeleteDutyBox";
            this.DeleteDutyBox.Size = new System.Drawing.Size(250, 28);
            // 
            // DeleteDutyButtonConf
            // 
            this.DeleteDutyButtonConf.Name = "DeleteDutyButtonConf";
            this.DeleteDutyButtonConf.Size = new System.Drawing.Size(316, 26);
            this.DeleteDutyButtonConf.Text = "Удалить";
            // 
            // DeletePostButton
            // 
            this.DeletePostButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DeletePostBox,
            this.DeletePostButtonConf});
            this.DeletePostButton.Name = "DeletePostButton";
            this.DeletePostButton.Size = new System.Drawing.Size(223, 26);
            this.DeletePostButton.Text = "Должность";
            this.DeletePostButton.Click += new System.EventHandler(this.DeletePostButton_Click);
            // 
            // DeletePostBox
            // 
            this.DeletePostBox.Name = "DeletePostBox";
            this.DeletePostBox.Size = new System.Drawing.Size(200, 28);
            // 
            // DeletePostButtonConf
            // 
            this.DeletePostButtonConf.Name = "DeletePostButtonConf";
            this.DeletePostButtonConf.Size = new System.Drawing.Size(266, 26);
            this.DeletePostButtonConf.Text = "Удалить";
            this.DeletePostButtonConf.Click += new System.EventHandler(this.DeletePostButtonConf_Click);
            // 
            // EmployerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 450);
            this.Controls.Add(this.PostDataGrid);
            this.Controls.Add(this.DutyDataGrid);
            this.Controls.Add(this.EmployerDataGrid);
            this.Controls.Add(this.toolStrip1);
            this.Name = "EmployerForm";
            this.Text = "EmployerForm";
            ((System.ComponentModel.ISupportInitialize)(this.EmployerDataGrid)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DutyDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PostDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView EmployerDataGrid;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripDropDownButton SelectButton;
        private System.Windows.Forms.ToolStripMenuItem EmployerButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem DutyButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridView DutyDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.ToolStripMenuItem PostButton;
        private System.Windows.Forms.DataGridView PostDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.ToolStripDropDownButton InsertButton;
        private System.Windows.Forms.ToolStripMenuItem EmployerInsertButton;
        private System.Windows.Forms.ToolStripMenuItem DutyInsertButton;
        private System.Windows.Forms.ToolStripComboBox DutyBox;
        private System.Windows.Forms.ToolStripTextBox DutyDateTb;
        private System.Windows.Forms.ToolStripMenuItem DutyInsertButtonConf;
        private System.Windows.Forms.ToolStripMenuItem PostInsertButton;
        private System.Windows.Forms.ToolStripTextBox PostNameTb;
        private System.Windows.Forms.ToolStripTextBox PostSalaryTb;
        private System.Windows.Forms.ToolStripMenuItem PostInsertButtonConf;
        private System.Windows.Forms.ToolStripDropDownButton EditButton;
        private System.Windows.Forms.ToolStripMenuItem EmployerEditButton;
        private System.Windows.Forms.ToolStripMenuItem DutyEditButton;
        private System.Windows.Forms.ToolStripComboBox DutyEditEmployerBox;
        private System.Windows.Forms.ToolStripComboBox DutyEditDateBox;
        private System.Windows.Forms.ToolStripMenuItem DutyEditButtonConf;
        private System.Windows.Forms.ToolStripMenuItem PostEditButton;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripDropDownButton DeleteButton;
        private System.Windows.Forms.ToolStripMenuItem DeleteEmployerButton;
        private System.Windows.Forms.ToolStripComboBox DeleteEmployerBox;
        private System.Windows.Forms.ToolStripMenuItem DeleteEmployerButtonConf;
        private System.Windows.Forms.ToolStripMenuItem DeleteDutyButton;
        private System.Windows.Forms.ToolStripComboBox DeleteDutyBox;
        private System.Windows.Forms.ToolStripMenuItem DeleteDutyButtonConf;
        private System.Windows.Forms.ToolStripMenuItem DeletePostButton;
        private System.Windows.Forms.ToolStripComboBox DeletePostBox;
        private System.Windows.Forms.ToolStripMenuItem DeletePostButtonConf;
    }
}