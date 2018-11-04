namespace ZooPark
{
    partial class EmployerInsertForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.JoinDateTb = new System.Windows.Forms.MaskedTextBox();
            this.InnTb = new System.Windows.Forms.MaskedTextBox();
            this.EmailTb = new System.Windows.Forms.TextBox();
            this.FioTb = new System.Windows.Forms.TextBox();
            this.AgeTb = new System.Windows.Forms.TextBox();
            this.PostBox = new System.Windows.Forms.ComboBox();
            this.ZooBox = new System.Windows.Forms.ComboBox();
            this.PhoneTb = new System.Windows.Forms.MaskedTextBox();
            this.InsertButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "ФИО";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Возраст";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Должность";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Филиал";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(468, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Телефон";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(468, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "Email";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(468, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 23);
            this.label7.TabIndex = 6;
            this.label7.Text = "ИНН";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(468, 214);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(147, 23);
            this.label8.TabIndex = 7;
            this.label8.Text = "Дата принятия";
            // 
            // JoinDateTb
            // 
            this.JoinDateTb.Location = new System.Drawing.Point(631, 211);
            this.JoinDateTb.Mask = "00/00/0000 90:00";
            this.JoinDateTb.Name = "JoinDateTb";
            this.JoinDateTb.Size = new System.Drawing.Size(202, 31);
            this.JoinDateTb.TabIndex = 8;
            this.JoinDateTb.ValidatingType = typeof(System.DateTime);
            // 
            // InnTb
            // 
            this.InnTb.Location = new System.Drawing.Point(631, 159);
            this.InnTb.Mask = "000000000000";
            this.InnTb.Name = "InnTb";
            this.InnTb.Size = new System.Drawing.Size(202, 31);
            this.InnTb.TabIndex = 9;
            // 
            // EmailTb
            // 
            this.EmailTb.Location = new System.Drawing.Point(631, 109);
            this.EmailTb.Name = "EmailTb";
            this.EmailTb.Size = new System.Drawing.Size(202, 31);
            this.EmailTb.TabIndex = 10;
            // 
            // FioTb
            // 
            this.FioTb.Location = new System.Drawing.Point(193, 61);
            this.FioTb.Name = "FioTb";
            this.FioTb.Size = new System.Drawing.Size(202, 31);
            this.FioTb.TabIndex = 12;
            // 
            // AgeTb
            // 
            this.AgeTb.Location = new System.Drawing.Point(193, 109);
            this.AgeTb.Name = "AgeTb";
            this.AgeTb.Size = new System.Drawing.Size(202, 31);
            this.AgeTb.TabIndex = 13;
            // 
            // PostBox
            // 
            this.PostBox.FormattingEnabled = true;
            this.PostBox.Location = new System.Drawing.Point(193, 159);
            this.PostBox.Name = "PostBox";
            this.PostBox.Size = new System.Drawing.Size(202, 31);
            this.PostBox.TabIndex = 14;
            // 
            // ZooBox
            // 
            this.ZooBox.FormattingEnabled = true;
            this.ZooBox.Location = new System.Drawing.Point(193, 211);
            this.ZooBox.Name = "ZooBox";
            this.ZooBox.Size = new System.Drawing.Size(202, 31);
            this.ZooBox.TabIndex = 15;
            // 
            // PhoneTb
            // 
            this.PhoneTb.Location = new System.Drawing.Point(631, 61);
            this.PhoneTb.Mask = "(999) 000-0000";
            this.PhoneTb.Name = "PhoneTb";
            this.PhoneTb.Size = new System.Drawing.Size(202, 31);
            this.PhoneTb.TabIndex = 16;
            // 
            // InsertButton
            // 
            this.InsertButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.InsertButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.InsertButton.FlatAppearance.BorderSize = 0;
            this.InsertButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InsertButton.Location = new System.Drawing.Point(52, 287);
            this.InsertButton.Name = "InsertButton";
            this.InsertButton.Size = new System.Drawing.Size(781, 75);
            this.InsertButton.TabIndex = 17;
            this.InsertButton.Text = "Добавить";
            this.InsertButton.UseVisualStyleBackColor = false;
            this.InsertButton.Click += new System.EventHandler(this.InsertButton_Click);
            // 
            // EmployerInsertForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(903, 391);
            this.Controls.Add(this.InsertButton);
            this.Controls.Add(this.PhoneTb);
            this.Controls.Add(this.ZooBox);
            this.Controls.Add(this.PostBox);
            this.Controls.Add(this.AgeTb);
            this.Controls.Add(this.FioTb);
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
            this.Name = "EmployerInsertForm";
            this.Text = "EmployerInsertForm";
            this.Load += new System.EventHandler(this.EmployerInsertForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox JoinDateTb;
        private System.Windows.Forms.MaskedTextBox InnTb;
        private System.Windows.Forms.TextBox EmailTb;
        private System.Windows.Forms.TextBox FioTb;
        private System.Windows.Forms.TextBox AgeTb;
        private System.Windows.Forms.ComboBox PostBox;
        private System.Windows.Forms.ComboBox ZooBox;
        private System.Windows.Forms.MaskedTextBox PhoneTb;
        private System.Windows.Forms.Button InsertButton;
    }
}