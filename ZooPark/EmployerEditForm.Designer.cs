namespace ZooPark
{
    partial class EmployerEditForm
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
            this.EditButton = new System.Windows.Forms.Button();
            this.PhoneTb = new System.Windows.Forms.MaskedTextBox();
            this.ZooBox = new System.Windows.Forms.ComboBox();
            this.PostBox = new System.Windows.Forms.ComboBox();
            this.AgeTb = new System.Windows.Forms.TextBox();
            this.EmailTb = new System.Windows.Forms.TextBox();
            this.InnTb = new System.Windows.Forms.MaskedTextBox();
            this.JoinDateTb = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.FioBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // EditButton
            // 
            this.EditButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.EditButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.EditButton.FlatAppearance.BorderSize = 0;
            this.EditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditButton.Location = new System.Drawing.Point(62, 277);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(781, 75);
            this.EditButton.TabIndex = 34;
            this.EditButton.Text = "Редактировать";
            this.EditButton.UseVisualStyleBackColor = false;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // PhoneTb
            // 
            this.PhoneTb.Location = new System.Drawing.Point(641, 51);
            this.PhoneTb.Mask = "(999) 000-0000";
            this.PhoneTb.Name = "PhoneTb";
            this.PhoneTb.Size = new System.Drawing.Size(202, 31);
            this.PhoneTb.TabIndex = 33;
            // 
            // ZooBox
            // 
            this.ZooBox.FormattingEnabled = true;
            this.ZooBox.Location = new System.Drawing.Point(203, 201);
            this.ZooBox.Name = "ZooBox";
            this.ZooBox.Size = new System.Drawing.Size(202, 31);
            this.ZooBox.TabIndex = 32;
            // 
            // PostBox
            // 
            this.PostBox.FormattingEnabled = true;
            this.PostBox.Location = new System.Drawing.Point(203, 149);
            this.PostBox.Name = "PostBox";
            this.PostBox.Size = new System.Drawing.Size(202, 31);
            this.PostBox.TabIndex = 31;
            // 
            // AgeTb
            // 
            this.AgeTb.Location = new System.Drawing.Point(203, 99);
            this.AgeTb.Name = "AgeTb";
            this.AgeTb.Size = new System.Drawing.Size(202, 31);
            this.AgeTb.TabIndex = 30;
            // 
            // EmailTb
            // 
            this.EmailTb.Location = new System.Drawing.Point(641, 99);
            this.EmailTb.Name = "EmailTb";
            this.EmailTb.Size = new System.Drawing.Size(202, 31);
            this.EmailTb.TabIndex = 28;
            // 
            // InnTb
            // 
            this.InnTb.Location = new System.Drawing.Point(641, 149);
            this.InnTb.Mask = "000000000000";
            this.InnTb.Name = "InnTb";
            this.InnTb.Size = new System.Drawing.Size(202, 31);
            this.InnTb.TabIndex = 27;
            // 
            // JoinDateTb
            // 
            this.JoinDateTb.Location = new System.Drawing.Point(641, 201);
            this.JoinDateTb.Mask = "00/00/0000 90:00";
            this.JoinDateTb.Name = "JoinDateTb";
            this.JoinDateTb.Size = new System.Drawing.Size(202, 31);
            this.JoinDateTb.TabIndex = 26;
            this.JoinDateTb.ValidatingType = typeof(System.DateTime);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(478, 204);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(147, 23);
            this.label8.TabIndex = 25;
            this.label8.Text = "Дата принятия";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(478, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 23);
            this.label7.TabIndex = 24;
            this.label7.Text = "ИНН";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(478, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 23);
            this.label6.TabIndex = 23;
            this.label6.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(478, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 23);
            this.label5.TabIndex = 22;
            this.label5.Text = "Телефон";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 23);
            this.label4.TabIndex = 21;
            this.label4.Text = "Филиал";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 23);
            this.label3.TabIndex = 20;
            this.label3.Text = "Должность";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 23);
            this.label2.TabIndex = 19;
            this.label2.Text = "Возраст";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 23);
            this.label1.TabIndex = 18;
            this.label1.Text = "ФИО";
            // 
            // FioBox
            // 
            this.FioBox.FormattingEnabled = true;
            this.FioBox.Location = new System.Drawing.Point(203, 51);
            this.FioBox.Name = "FioBox";
            this.FioBox.Size = new System.Drawing.Size(202, 31);
            this.FioBox.TabIndex = 35;
            this.FioBox.SelectedIndexChanged += new System.EventHandler(this.FioBox_SelectedIndexChanged);
            // 
            // EmployerEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(903, 391);
            this.Controls.Add(this.FioBox);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.PhoneTb);
            this.Controls.Add(this.ZooBox);
            this.Controls.Add(this.PostBox);
            this.Controls.Add(this.AgeTb);
            this.Controls.Add(this.EmailTb);
            this.Controls.Add(this.InnTb);
            this.Controls.Add(this.JoinDateTb);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EmployerEditForm";
            this.Text = "EmployerEditForm";
            this.Load += new System.EventHandler(this.EmployerEditForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.MaskedTextBox PhoneTb;
        private System.Windows.Forms.ComboBox ZooBox;
        private System.Windows.Forms.ComboBox PostBox;
        private System.Windows.Forms.TextBox AgeTb;
        private System.Windows.Forms.TextBox EmailTb;
        private System.Windows.Forms.MaskedTextBox InnTb;
        private System.Windows.Forms.MaskedTextBox JoinDateTb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox FioBox;
    }
}