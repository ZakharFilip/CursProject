namespace EcsportManagementKurs
{
    partial class EditContractLine
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.NameOfProductLabel = new System.Windows.Forms.Label();
            this.changeItemButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.NameOfProductLabel);
            this.groupBox1.Controls.Add(this.changeItemButton);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(474, 104);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Редактировать";
            // 
            // NameOfProductLabel
            // 
            this.NameOfProductLabel.AutoSize = true;
            this.NameOfProductLabel.Location = new System.Drawing.Point(91, 25);
            this.NameOfProductLabel.Name = "NameOfProductLabel";
            this.NameOfProductLabel.Size = new System.Drawing.Size(323, 13);
            this.NameOfProductLabel.TabIndex = 9;
            this.NameOfProductLabel.Text = "Сырьё                                 Объём(кг)                        Сумма(руб)" +
    " ";
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(349, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(119, 20);
            this.textBox1.TabIndex = 0;
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
            this.textBox2.Location = new System.Drawing.Point(94, 41);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(122, 20);
            this.textBox2.TabIndex = 3;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(222, 41);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(121, 20);
            this.textBox4.TabIndex = 4;
            // 
            // EditContractLine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 131);
            this.Controls.Add(this.groupBox1);
            this.Name = "EditContractLine";
            this.Text = "Редактировать строку";
            this.Load += new System.EventHandler(this.EditContractLine_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label NameOfProductLabel;
        private System.Windows.Forms.Button changeItemButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox4;
    }
}