namespace EcsportManagementKurs
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
            this.LeftMainGrid = new System.Windows.Forms.DataGridView();
            this.RightMainGrid = new System.Windows.Forms.DataGridView();
            this.ViviodLineButton = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.connectionStatusLabel = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.LeftMainGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightMainGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // LeftMainGrid
            // 
            this.LeftMainGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LeftMainGrid.Location = new System.Drawing.Point(12, 12);
            this.LeftMainGrid.Name = "LeftMainGrid";
            this.LeftMainGrid.Size = new System.Drawing.Size(704, 432);
            this.LeftMainGrid.TabIndex = 14;
            // 
            // RightMainGrid
            // 
            this.RightMainGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RightMainGrid.Location = new System.Drawing.Point(759, 12);
            this.RightMainGrid.Name = "RightMainGrid";
            this.RightMainGrid.Size = new System.Drawing.Size(704, 432);
            this.RightMainGrid.TabIndex = 17;
            // 
            // ViviodLineButton
            // 
            this.ViviodLineButton.Location = new System.Drawing.Point(642, 450);
            this.ViviodLineButton.Name = "ViviodLineButton";
            this.ViviodLineButton.Size = new System.Drawing.Size(198, 23);
            this.ViviodLineButton.TabIndex = 14;
            this.ViviodLineButton.Text = "Вывести строки договора ->";
            this.ViviodLineButton.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(612, 582);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(355, 46);
            this.button4.TabIndex = 23;
            this.button4.Text = "Сформировать Договор";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(137, 582);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(355, 46);
            this.button5.TabIndex = 24;
            this.button5.Text = "Сформировать Отчёт";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.button1.Location = new System.Drawing.Point(1229, 566);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(224, 46);
            this.button1.TabIndex = 25;
            this.button1.Text = "Удалить строку";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // connectionStatusLabel
            // 
            this.connectionStatusLabel.AutoSize = true;
            this.connectionStatusLabel.ForeColor = System.Drawing.Color.Red;
            this.connectionStatusLabel.Location = new System.Drawing.Point(1382, 615);
            this.connectionStatusLabel.Name = "connectionStatusLabel";
            this.connectionStatusLabel.Size = new System.Drawing.Size(71, 13);
            this.connectionStatusLabel.TabIndex = 26;
            this.connectionStatusLabel.Text = "No conection";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(161, 450);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(355, 23);
            this.button2.TabIndex = 27;
            this.button2.Text = "Редактировать";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.Location = new System.Drawing.Point(1007, 450);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(355, 23);
            this.button6.TabIndex = 28;
            this.button6.Text = "Редактировать";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1465, 637);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.connectionStatusLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.ViviodLineButton);
            this.Controls.Add(this.RightMainGrid);
            this.Controls.Add(this.LeftMainGrid);
            this.Name = "Form1";
            this.Text = "Форма";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LeftMainGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightMainGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView LeftMainGrid;
        private System.Windows.Forms.DataGridView RightMainGrid;
        private System.Windows.Forms.Button ViviodLineButton;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label connectionStatusLabel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button6;
    }
}

