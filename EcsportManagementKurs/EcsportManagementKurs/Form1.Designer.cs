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
            this.components = new System.ComponentModel.Container();
            this.LeftMainGrid = new System.Windows.Forms.DataGridView();
            this.contextMenuStripLeft = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.редактироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.RightMainGrid = new System.Windows.Forms.DataGridView();
            this.contextMenuStripRight = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.редактироватьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.строкуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.контрактToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ViviodLineButton = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.connectionStatusLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.LeftMainGrid)).BeginInit();
            this.contextMenuStripLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RightMainGrid)).BeginInit();
            this.contextMenuStripRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // LeftMainGrid
            // 
            this.LeftMainGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LeftMainGrid.ContextMenuStrip = this.contextMenuStripLeft;
            this.LeftMainGrid.Location = new System.Drawing.Point(12, 12);
            this.LeftMainGrid.Name = "LeftMainGrid";
            this.LeftMainGrid.Size = new System.Drawing.Size(704, 432);
            this.LeftMainGrid.TabIndex = 14;
            this.LeftMainGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.LeftMainGrid_CellContentClick);
            // 
            // contextMenuStripLeft
            // 
            this.contextMenuStripLeft.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.редактироватьToolStripMenuItem,
            this.удалитьToolStripMenuItem,
            this.удалитьToolStripMenuItem2});
            this.contextMenuStripLeft.Name = "contextMenuStripLeft";
            this.contextMenuStripLeft.Size = new System.Drawing.Size(191, 70);
            // 
            // редактироватьToolStripMenuItem
            // 
            this.редактироватьToolStripMenuItem.Name = "редактироватьToolStripMenuItem";
            this.редактироватьToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.редактироватьToolStripMenuItem.Text = "Редактировать";
            this.редактироватьToolStripMenuItem.Click += new System.EventHandler(this.редактироватьToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.удалитьToolStripMenuItem.Text = "Вывести содержание";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem2
            // 
            this.удалитьToolStripMenuItem2.Name = "удалитьToolStripMenuItem2";
            this.удалитьToolStripMenuItem2.Size = new System.Drawing.Size(190, 22);
            this.удалитьToolStripMenuItem2.Text = "Удалить";
            this.удалитьToolStripMenuItem2.Click += new System.EventHandler(this.удалитьToolStripMenuItem2_Click);
            // 
            // RightMainGrid
            // 
            this.RightMainGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RightMainGrid.ContextMenuStrip = this.contextMenuStripRight;
            this.RightMainGrid.Location = new System.Drawing.Point(759, 12);
            this.RightMainGrid.Name = "RightMainGrid";
            this.RightMainGrid.Size = new System.Drawing.Size(704, 432);
            this.RightMainGrid.TabIndex = 17;
            // 
            // contextMenuStripRight
            // 
            this.contextMenuStripRight.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.редактироватьToolStripMenuItem1,
            this.удалитьToolStripMenuItem1});
            this.contextMenuStripRight.Name = "contextMenuStripRight";
            this.contextMenuStripRight.Size = new System.Drawing.Size(155, 48);
            // 
            // редактироватьToolStripMenuItem1
            // 
            this.редактироватьToolStripMenuItem1.Name = "редактироватьToolStripMenuItem1";
            this.редактироватьToolStripMenuItem1.Size = new System.Drawing.Size(154, 22);
            this.редактироватьToolStripMenuItem1.Text = "Редактировать";
            this.редактироватьToolStripMenuItem1.Click += new System.EventHandler(this.редактироватьToolStripMenuItem1_Click);
            // 
            // удалитьToolStripMenuItem1
            // 
            this.удалитьToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.строкуToolStripMenuItem,
            this.контрактToolStripMenuItem});
            this.удалитьToolStripMenuItem1.Name = "удалитьToolStripMenuItem1";
            this.удалитьToolStripMenuItem1.Size = new System.Drawing.Size(154, 22);
            this.удалитьToolStripMenuItem1.Text = "Удалить";
            // 
            // строкуToolStripMenuItem
            // 
            this.строкуToolStripMenuItem.Name = "строкуToolStripMenuItem";
            this.строкуToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.строкуToolStripMenuItem.Text = "Строку";
            // 
            // контрактToolStripMenuItem
            // 
            this.контрактToolStripMenuItem.Name = "контрактToolStripMenuItem";
            this.контрактToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.контрактToolStripMenuItem.Text = "Контракт";
            // 
            // ViviodLineButton
            // 
            this.ViviodLineButton.Location = new System.Drawing.Point(642, 450);
            this.ViviodLineButton.Name = "ViviodLineButton";
            this.ViviodLineButton.Size = new System.Drawing.Size(198, 23);
            this.ViviodLineButton.TabIndex = 14;
            this.ViviodLineButton.Text = "Вывести строки договора ->";
            this.ViviodLineButton.UseVisualStyleBackColor = true;
            this.ViviodLineButton.Click += new System.EventHandler(this.ViviodLineButton_Click);
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
            this.button5.Click += new System.EventHandler(this.button5_Click);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1465, 637);
            this.Controls.Add(this.connectionStatusLabel);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.ViviodLineButton);
            this.Controls.Add(this.RightMainGrid);
            this.Controls.Add(this.LeftMainGrid);
            this.Name = "Form1";
            this.Text = "Форма";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LeftMainGrid)).EndInit();
            this.contextMenuStripLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RightMainGrid)).EndInit();
            this.contextMenuStripRight.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView LeftMainGrid;
        private System.Windows.Forms.DataGridView RightMainGrid;
        private System.Windows.Forms.Button ViviodLineButton;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label connectionStatusLabel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripLeft;
        private System.Windows.Forms.ToolStripMenuItem редактироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripRight;
        private System.Windows.Forms.ToolStripMenuItem редактироватьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem строкуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem контрактToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem2;
    }
}

