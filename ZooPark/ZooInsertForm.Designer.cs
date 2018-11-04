namespace ZooPark
{
    partial class ZooInsertForm
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
            this.NameTb = new System.Windows.Forms.TextBox();
            this.AddressTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.InsertButton = new System.Windows.Forms.Button();
            this.PhoneTb = new System.Windows.Forms.MaskedTextBox();
            this.InnTb = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // NameTb
            // 
            this.NameTb.Location = new System.Drawing.Point(144, 27);
            this.NameTb.Margin = new System.Windows.Forms.Padding(4);
            this.NameTb.Name = "NameTb";
            this.NameTb.Size = new System.Drawing.Size(284, 26);
            this.NameTb.TabIndex = 0;
            // 
            // AddressTb
            // 
            this.AddressTb.Location = new System.Drawing.Point(144, 66);
            this.AddressTb.Margin = new System.Windows.Forms.Padding(4);
            this.AddressTb.Name = "AddressTb";
            this.AddressTb.Size = new System.Drawing.Size(284, 26);
            this.AddressTb.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Название";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Адрес";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 150);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "ИНН";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 110);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Телефон";
            // 
            // InsertButton
            // 
            this.InsertButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.InsertButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.InsertButton.FlatAppearance.BorderSize = 0;
            this.InsertButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InsertButton.Location = new System.Drawing.Point(46, 211);
            this.InsertButton.Name = "InsertButton";
            this.InsertButton.Size = new System.Drawing.Size(382, 75);
            this.InsertButton.TabIndex = 8;
            this.InsertButton.Text = "Добавить";
            this.InsertButton.UseVisualStyleBackColor = false;
            this.InsertButton.Click += new System.EventHandler(this.InsertButton_Click);
            // 
            // PhoneTb
            // 
            this.PhoneTb.Location = new System.Drawing.Point(144, 107);
            this.PhoneTb.Mask = "(999) 000-0000";
            this.PhoneTb.Name = "PhoneTb";
            this.PhoneTb.Size = new System.Drawing.Size(284, 26);
            this.PhoneTb.TabIndex = 9;
            // 
            // InnTb
            // 
            this.InnTb.Location = new System.Drawing.Point(144, 147);
            this.InnTb.Mask = "000000000000";
            this.InnTb.Name = "InnTb";
            this.InnTb.Size = new System.Drawing.Size(284, 26);
            this.InnTb.TabIndex = 10;
            // 
            // ZooInsertForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(489, 313);
            this.Controls.Add(this.InnTb);
            this.Controls.Add(this.PhoneTb);
            this.Controls.Add(this.InsertButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddressTb);
            this.Controls.Add(this.NameTb);
            this.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ZooInsertForm";
            this.Text = "ZooEditForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameTb;
        private System.Windows.Forms.TextBox AddressTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button InsertButton;
        private System.Windows.Forms.MaskedTextBox PhoneTb;
        private System.Windows.Forms.MaskedTextBox InnTb;
    }
}