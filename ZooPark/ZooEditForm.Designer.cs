namespace ZooPark
{
    partial class ZooEditForm
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
            this.InnTb = new System.Windows.Forms.MaskedTextBox();
            this.PhoneTb = new System.Windows.Forms.MaskedTextBox();
            this.EditButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AddressTb = new System.Windows.Forms.TextBox();
            this.NameBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // InnTb
            // 
            this.InnTb.Location = new System.Drawing.Point(144, 147);
            this.InnTb.Mask = "000000000000";
            this.InnTb.Name = "InnTb";
            this.InnTb.Size = new System.Drawing.Size(284, 26);
            this.InnTb.TabIndex = 19;
            // 
            // PhoneTb
            // 
            this.PhoneTb.Location = new System.Drawing.Point(144, 107);
            this.PhoneTb.Mask = "(999) 000-0000";
            this.PhoneTb.Name = "PhoneTb";
            this.PhoneTb.Size = new System.Drawing.Size(284, 26);
            this.PhoneTb.TabIndex = 18;
            // 
            // EditButton
            // 
            this.EditButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.EditButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.EditButton.FlatAppearance.BorderSize = 0;
            this.EditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditButton.Location = new System.Drawing.Point(46, 211);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(382, 75);
            this.EditButton.TabIndex = 17;
            this.EditButton.Text = "Редактировать";
            this.EditButton.UseVisualStyleBackColor = false;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 150);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 19);
            this.label3.TabIndex = 16;
            this.label3.Text = "ИНН";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 110);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 19);
            this.label4.TabIndex = 15;
            this.label4.Text = "Телефон";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 19);
            this.label2.TabIndex = 14;
            this.label2.Text = "Адрес";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 19);
            this.label1.TabIndex = 13;
            this.label1.Text = "Название";
            // 
            // AddressTb
            // 
            this.AddressTb.Location = new System.Drawing.Point(144, 66);
            this.AddressTb.Margin = new System.Windows.Forms.Padding(4);
            this.AddressTb.Name = "AddressTb";
            this.AddressTb.Size = new System.Drawing.Size(284, 26);
            this.AddressTb.TabIndex = 12;
            // 
            // NameBox
            // 
            this.NameBox.FormattingEnabled = true;
            this.NameBox.Location = new System.Drawing.Point(144, 28);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(284, 27);
            this.NameBox.TabIndex = 20;
            this.NameBox.SelectedIndexChanged += new System.EventHandler(this.NameBox_SelectedIndexChanged);
            // 
            // ZooEditForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(489, 313);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.InnTb);
            this.Controls.Add(this.PhoneTb);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddressTb);
            this.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "ZooEditForm";
            this.Text = "ZooEditForm";
            this.Load += new System.EventHandler(this.ZooEditForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox InnTb;
        private System.Windows.Forms.MaskedTextBox PhoneTb;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AddressTb;
        private System.Windows.Forms.ComboBox NameBox;
    }
}