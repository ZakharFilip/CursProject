namespace EcsportManagementKurs
{
    partial class InsertForm
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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AddContractButt = new System.Windows.Forms.Button();
            this.NameOfProductLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DataSelecter = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AddContractLineButt = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.DataInsertGrid = new System.Windows.Forms.DataGridView();
            this.backToMainButt = new System.Windows.Forms.Button();
            this.RedactPenisbutton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataInsertGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(222, 41);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 20);
            this.textBox2.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(94, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(122, 20);
            this.textBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Новый договор:";
            // 
            // AddContractButt
            // 
            this.AddContractButt.Location = new System.Drawing.Point(379, 67);
            this.AddContractButt.Name = "AddContractButt";
            this.AddContractButt.Size = new System.Drawing.Size(89, 23);
            this.AddContractButt.TabIndex = 8;
            this.AddContractButt.Text = "Добавить";
            this.AddContractButt.UseVisualStyleBackColor = true;
            this.AddContractButt.Click += new System.EventHandler(this.AddContractButt_Click);
            // 
            // NameOfProductLabel
            // 
            this.NameOfProductLabel.AutoSize = true;
            this.NameOfProductLabel.Location = new System.Drawing.Point(91, 25);
            this.NameOfProductLabel.Name = "NameOfProductLabel";
            this.NameOfProductLabel.Size = new System.Drawing.Size(292, 13);
            this.NameOfProductLabel.TabIndex = 9;
            this.NameOfProductLabel.Text = "Поставщик                        Покупатель                      Дата ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DataSelecter);
            this.groupBox1.Controls.Add(this.NameOfProductLabel);
            this.groupBox1.Controls.Add(this.AddContractButt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(474, 104);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Новый Договор";
            // 
            // DataSelecter
            // 
            this.DataSelecter.Location = new System.Drawing.Point(349, 41);
            this.DataSelecter.Name = "DataSelecter";
            this.DataSelecter.Size = new System.Drawing.Size(119, 20);
            this.DataSelecter.TabIndex = 10;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.AddContractLineButt);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Controls.Add(this.textBox5);
            this.groupBox2.Controls.Add(this.textBox6);
            this.groupBox2.Location = new System.Drawing.Point(12, 122);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(474, 104);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Добавить строку договора";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(323, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Сырьё                                 Объём(кг)                        Сумма(руб)" +
    " ";
            // 
            // AddContractLineButt
            // 
            this.AddContractLineButt.Location = new System.Drawing.Point(379, 67);
            this.AddContractLineButt.Name = "AddContractLineButt";
            this.AddContractLineButt.Size = new System.Drawing.Size(89, 23);
            this.AddContractLineButt.TabIndex = 8;
            this.AddContractLineButt.Text = "Добавить";
            this.AddContractLineButt.UseVisualStyleBackColor = true;
            this.AddContractLineButt.Click += new System.EventHandler(this.AddContractLineButt_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Новая строка:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(349, 41);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(119, 20);
            this.textBox4.TabIndex = 5;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(94, 41);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(122, 20);
            this.textBox5.TabIndex = 3;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(222, 41);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(121, 20);
            this.textBox6.TabIndex = 4;
            // 
            // DataInsertGrid
            // 
            this.DataInsertGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataInsertGrid.Location = new System.Drawing.Point(505, 56);
            this.DataInsertGrid.Name = "DataInsertGrid";
            this.DataInsertGrid.Size = new System.Drawing.Size(513, 370);
            this.DataInsertGrid.TabIndex = 18;
            // 
            // backToMainButt
            // 
            this.backToMainButt.Location = new System.Drawing.Point(11, 403);
            this.backToMainButt.Name = "backToMainButt";
            this.backToMainButt.Size = new System.Drawing.Size(89, 23);
            this.backToMainButt.TabIndex = 10;
            this.backToMainButt.Text = "Назад";
            this.backToMainButt.UseVisualStyleBackColor = true;
            this.backToMainButt.Click += new System.EventHandler(this.backToMainButt_Click);
            // 
            // RedactPenisbutton
            // 
            this.RedactPenisbutton.Location = new System.Drawing.Point(505, 12);
            this.RedactPenisbutton.Name = "RedactPenisbutton";
            this.RedactPenisbutton.Size = new System.Drawing.Size(128, 23);
            this.RedactPenisbutton.TabIndex = 19;
            this.RedactPenisbutton.Text = "Редактировань";
            this.RedactPenisbutton.UseVisualStyleBackColor = true;
            this.RedactPenisbutton.Click += new System.EventHandler(this.RedactPenisbutton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(639, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "Заполнить договор";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // InsertForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 438);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.RedactPenisbutton);
            this.Controls.Add(this.backToMainButt);
            this.Controls.Add(this.DataInsertGrid);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "InsertForm";
            this.Text = "Создание";
            this.Load += new System.EventHandler(this.InsertForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataInsertGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddContractButt;
        private System.Windows.Forms.Label NameOfProductLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AddContractLineButt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.DataGridView DataInsertGrid;
        private System.Windows.Forms.Button backToMainButt;
        private System.Windows.Forms.Button RedactPenisbutton;
        private System.Windows.Forms.DateTimePicker DataSelecter;
        private System.Windows.Forms.Button button1;
    }
}