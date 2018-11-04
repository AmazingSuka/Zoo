namespace ZooPark
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ZooButton = new System.Windows.Forms.Button();
            this.EmployerButton = new System.Windows.Forms.Button();
            this.AnimalButton = new System.Windows.Forms.Button();
            this.CellButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ZooButton
            // 
            this.ZooButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(194)))), ((int)(((byte)(242)))));
            this.ZooButton.FlatAppearance.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.ZooButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ZooButton.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ZooButton.Location = new System.Drawing.Point(0, 12);
            this.ZooButton.Name = "ZooButton";
            this.ZooButton.Size = new System.Drawing.Size(360, 73);
            this.ZooButton.TabIndex = 0;
            this.ZooButton.Text = "Филиалы";
            this.ZooButton.UseVisualStyleBackColor = false;
            this.ZooButton.Click += new System.EventHandler(this.ZooButton_Click);
            // 
            // EmployerButton
            // 
            this.EmployerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(194)))), ((int)(((byte)(242)))));
            this.EmployerButton.FlatAppearance.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.EmployerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EmployerButton.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployerButton.Location = new System.Drawing.Point(0, 91);
            this.EmployerButton.Name = "EmployerButton";
            this.EmployerButton.Size = new System.Drawing.Size(360, 73);
            this.EmployerButton.TabIndex = 1;
            this.EmployerButton.Text = "Сотрудники";
            this.EmployerButton.UseVisualStyleBackColor = false;
            this.EmployerButton.Click += new System.EventHandler(this.EmployerButton_Click);
            // 
            // AnimalButton
            // 
            this.AnimalButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(194)))), ((int)(((byte)(242)))));
            this.AnimalButton.FlatAppearance.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.AnimalButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AnimalButton.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnimalButton.Location = new System.Drawing.Point(0, 170);
            this.AnimalButton.Name = "AnimalButton";
            this.AnimalButton.Size = new System.Drawing.Size(360, 73);
            this.AnimalButton.TabIndex = 2;
            this.AnimalButton.Text = "Каталог Животных";
            this.AnimalButton.UseVisualStyleBackColor = false;
            this.AnimalButton.Click += new System.EventHandler(this.AnimalButton_Click);
            // 
            // CellButton
            // 
            this.CellButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(194)))), ((int)(((byte)(242)))));
            this.CellButton.FlatAppearance.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.CellButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CellButton.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CellButton.Location = new System.Drawing.Point(0, 249);
            this.CellButton.Name = "CellButton";
            this.CellButton.Size = new System.Drawing.Size(360, 73);
            this.CellButton.TabIndex = 3;
            this.CellButton.Text = "Вольеры";
            this.CellButton.UseVisualStyleBackColor = false;
            this.CellButton.Click += new System.EventHandler(this.CellButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.Controls.Add(this.CellButton);
            this.panel1.Controls.Add(this.AnimalButton);
            this.panel1.Controls.Add(this.EmployerButton);
            this.panel1.Controls.Add(this.ZooButton);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(360, 333);
            this.panel1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 333);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button ZooButton;
        private System.Windows.Forms.Button EmployerButton;
        private System.Windows.Forms.Button AnimalButton;
        private System.Windows.Forms.Button CellButton;
        private System.Windows.Forms.Panel panel1;
    }
}

