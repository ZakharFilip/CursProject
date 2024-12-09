namespace EcsportManagementKurs
{
    partial class EditAddPage
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
            this.changeItemButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.testlabel = new System.Windows.Forms.Label();
            this.NameOfProductLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // changeItemButton
            // 
            this.changeItemButton.Location = new System.Drawing.Point(387, 75);
            this.changeItemButton.Name = "changeItemButton";
            this.changeItemButton.Size = new System.Drawing.Size(81, 23);
            this.changeItemButton.TabIndex = 1;
            this.changeItemButton.Text = "Test text";
            this.changeItemButton.UseVisualStyleBackColor = true;
            this.changeItemButton.Click += new System.EventHandler(this.changeItemButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.testlabel);
            this.groupBox1.Controls.Add(this.NameOfProductLabel);
            this.groupBox1.Controls.Add(this.changeItemButton);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(474, 104);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Редактировать";
            // 
            // testlabel
            // 
            this.testlabel.AutoSize = true;
            this.testlabel.Location = new System.Drawing.Point(75, 85);
            this.testlabel.Name = "testlabel";
            this.testlabel.Size = new System.Drawing.Size(39, 13);
            this.testlabel.TabIndex = 10;
            this.testlabel.Text = "no text";
            // 
            // NameOfProductLabel
            // 
            this.NameOfProductLabel.AutoSize = true;
            this.NameOfProductLabel.Location = new System.Drawing.Point(81, 28);
            this.NameOfProductLabel.Name = "NameOfProductLabel";
            this.NameOfProductLabel.Size = new System.Drawing.Size(292, 13);
            this.NameOfProductLabel.TabIndex = 9;
            this.NameOfProductLabel.Text = "Поставщик                        Покупатель                      Дата ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Редактировать";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(84, 44);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(122, 20);
            this.textBox2.TabIndex = 3;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(212, 44);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(121, 20);
            this.textBox4.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(339, 44);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(134, 20);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // EditAddPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 121);
            this.Controls.Add(this.groupBox1);
            this.Name = "EditAddPage";
            this.Text = "Редактировать договор договор";
            this.Load += new System.EventHandler(this.EditAddPage_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button changeItemButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label NameOfProductLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label testlabel;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}