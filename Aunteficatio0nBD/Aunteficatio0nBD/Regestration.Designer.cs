namespace Aunteficatio0nBD
{
    partial class Regestration
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
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.Loginlabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.SecNameLabel = new System.Windows.Forms.Label();
            this.SecNameTextBox = new System.Windows.Forms.TextBox();
            this.mailLabel = new System.Windows.Forms.Label();
            this.mailTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.Phonelabel = new System.Windows.Forms.Label();
            this.OKButt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loginTextBox
            // 
            this.loginTextBox.Location = new System.Drawing.Point(49, 22);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(94, 20);
            this.loginTextBox.TabIndex = 0;
            // 
            // Loginlabel
            // 
            this.Loginlabel.AutoSize = true;
            this.Loginlabel.Location = new System.Drawing.Point(58, 6);
            this.Loginlabel.Name = "Loginlabel";
            this.Loginlabel.Size = new System.Drawing.Size(38, 13);
            this.Loginlabel.TabIndex = 1;
            this.Loginlabel.Text = "Логин";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(55, 54);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(45, 13);
            this.passwordLabel.TabIndex = 2;
            this.passwordLabel.Text = "Пароль";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(55, 103);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(29, 13);
            this.NameLabel.TabIndex = 4;
            this.NameLabel.Text = "Имя";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(49, 80);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(94, 20);
            this.passwordTextBox.TabIndex = 5;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(49, 119);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(94, 20);
            this.NameTextBox.TabIndex = 6;
            // 
            // SecNameLabel
            // 
            this.SecNameLabel.AutoSize = true;
            this.SecNameLabel.Location = new System.Drawing.Point(58, 142);
            this.SecNameLabel.Name = "SecNameLabel";
            this.SecNameLabel.Size = new System.Drawing.Size(56, 13);
            this.SecNameLabel.TabIndex = 7;
            this.SecNameLabel.Text = "Фамилия";
            // 
            // SecNameTextBox
            // 
            this.SecNameTextBox.Location = new System.Drawing.Point(49, 158);
            this.SecNameTextBox.Name = "SecNameTextBox";
            this.SecNameTextBox.Size = new System.Drawing.Size(94, 20);
            this.SecNameTextBox.TabIndex = 8;
            // 
            // mailLabel
            // 
            this.mailLabel.AutoSize = true;
            this.mailLabel.Location = new System.Drawing.Point(55, 181);
            this.mailLabel.Name = "mailLabel";
            this.mailLabel.Size = new System.Drawing.Size(37, 13);
            this.mailLabel.TabIndex = 9;
            this.mailLabel.Text = "Почта";
            // 
            // mailTextBox
            // 
            this.mailTextBox.Location = new System.Drawing.Point(49, 197);
            this.mailTextBox.Name = "mailTextBox";
            this.mailTextBox.Size = new System.Drawing.Size(94, 20);
            this.mailTextBox.TabIndex = 10;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(49, 236);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(94, 20);
            this.phoneTextBox.TabIndex = 11;
            // 
            // Phonelabel
            // 
            this.Phonelabel.AutoSize = true;
            this.Phonelabel.Location = new System.Drawing.Point(55, 220);
            this.Phonelabel.Name = "Phonelabel";
            this.Phonelabel.Size = new System.Drawing.Size(52, 13);
            this.Phonelabel.TabIndex = 12;
            this.Phonelabel.Text = "Телефон";
            // 
            // OKButt
            // 
            this.OKButt.Location = new System.Drawing.Point(46, 278);
            this.OKButt.Name = "OKButt";
            this.OKButt.Size = new System.Drawing.Size(97, 23);
            this.OKButt.TabIndex = 13;
            this.OKButt.Text = "Подтвердить";
            this.OKButt.UseVisualStyleBackColor = true;
            this.OKButt.Click += new System.EventHandler(this.button1_Click);
            // 
            // Regestration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(195, 313);
            this.Controls.Add(this.OKButt);
            this.Controls.Add(this.Phonelabel);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.mailTextBox);
            this.Controls.Add(this.mailLabel);
            this.Controls.Add(this.SecNameTextBox);
            this.Controls.Add(this.SecNameLabel);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.Loginlabel);
            this.Controls.Add(this.loginTextBox);
            this.Name = "Regestration";
            this.Text = "Regestration";
            this.Load += new System.EventHandler(this.Regestration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.Label Loginlabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label SecNameLabel;
        private System.Windows.Forms.TextBox SecNameTextBox;
        private System.Windows.Forms.Label mailLabel;
        private System.Windows.Forms.TextBox mailTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.Label Phonelabel;
        private System.Windows.Forms.Button OKButt;
    }
}