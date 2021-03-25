
namespace SNKRS
{
    partial class FormAddAccount
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxEmail = new DarkUI.Controls.DarkTextBox();
            this.textBoxPassword = new DarkUI.Controls.DarkTextBox();
            this.darkLabel1 = new DarkUI.Controls.DarkLabel();
            this.darkLabel2 = new DarkUI.Controls.DarkLabel();
            this.darkLabel3 = new DarkUI.Controls.DarkLabel();
            this.btnAddAccount = new DarkUI.Controls.DarkButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 1;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.textBoxEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.textBoxEmail.Location = new System.Drawing.Point(151, 72);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(212, 23);
            this.textBoxEmail.TabIndex = 7;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.textBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.textBoxPassword.Location = new System.Drawing.Point(151, 115);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(212, 23);
            this.textBoxPassword.TabIndex = 8;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // darkLabel1
            // 
            this.darkLabel1.AutoSize = true;
            this.darkLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel1.Location = new System.Drawing.Point(162, 28);
            this.darkLabel1.Name = "darkLabel1";
            this.darkLabel1.Size = new System.Drawing.Size(66, 15);
            this.darkLabel1.TabIndex = 9;
            this.darkLabel1.Text = "Conta Nike";
            // 
            // darkLabel2
            // 
            this.darkLabel2.AutoSize = true;
            this.darkLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel2.Location = new System.Drawing.Point(35, 74);
            this.darkLabel2.Name = "darkLabel2";
            this.darkLabel2.Size = new System.Drawing.Size(109, 15);
            this.darkLabel2.TabIndex = 10;
            this.darkLabel2.Text = "Endereço de e-mail";
            // 
            // darkLabel3
            // 
            this.darkLabel3.AutoSize = true;
            this.darkLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel3.Location = new System.Drawing.Point(105, 117);
            this.darkLabel3.Name = "darkLabel3";
            this.darkLabel3.Size = new System.Drawing.Size(39, 15);
            this.darkLabel3.TabIndex = 11;
            this.darkLabel3.Text = "Senha";
            // 
            // btnAddAccount
            // 
            this.btnAddAccount.Location = new System.Drawing.Point(147, 182);
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.Padding = new System.Windows.Forms.Padding(5);
            this.btnAddAccount.Size = new System.Drawing.Size(125, 47);
            this.btnAddAccount.TabIndex = 12;
            this.btnAddAccount.Text = "Adicionar";
            this.btnAddAccount.Click += new System.EventHandler(this.btnAddAccount_Click);
            // 
            // FormAddAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 275);
            this.Controls.Add(this.btnAddAccount);
            this.Controls.Add(this.darkLabel3);
            this.Controls.Add(this.darkLabel2);
            this.Controls.Add(this.darkLabel1);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.label1);
            this.Name = "FormAddAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar Conta";
            this.Load += new System.EventHandler(this.FormAddAccount_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private DarkUI.Controls.DarkTextBox textBoxEmail;
        private DarkUI.Controls.DarkTextBox textBoxPassword;
        private DarkUI.Controls.DarkLabel darkLabel1;
        private DarkUI.Controls.DarkLabel darkLabel2;
        private DarkUI.Controls.DarkLabel darkLabel3;
        private DarkUI.Controls.DarkButton btnAddAccount;
    }
}

