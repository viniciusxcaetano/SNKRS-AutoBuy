
namespace SNKRS.Forms
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxCreditCardMonth = new DarkUI.Controls.DarkComboBox();
            this.textBoxCreditCardYear = new DarkUI.Controls.DarkComboBox();
            this.textBoxCreditCardCpfCnpj = new DarkUI.Controls.DarkTextBox();
            this.textBoxCreditCardName = new DarkUI.Controls.DarkTextBox();
            this.textBoxCreditCardNumber = new DarkUI.Controls.DarkTextBox();
            this.textBoxCreditCardCode = new DarkUI.Controls.DarkTextBox();
            this.textBoxCreditCardInstallment = new DarkUI.Controls.DarkNumericUpDown();
            this.btnBuy = new DarkUI.Controls.DarkButton();
            this.textBoxLinkSnkrs = new DarkUI.Controls.DarkTextBox();
            this.checkedListBoxAccounts = new System.Windows.Forms.CheckedListBox();
            this.btnDeleteAccount = new DarkUI.Controls.DarkButton();
            this.btnAddAccount = new DarkUI.Controls.DarkButton();
            this.checkedListBoxSneakers = new System.Windows.Forms.CheckedListBox();
            this.btnAddNumberQuantity = new DarkUI.Controls.DarkButton();
            this.btnDeleteNumberQuantity = new DarkUI.Controls.DarkButton();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxCreditCardInstallment)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(171, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Contas Nike";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(227, 450);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Link do Sneaker";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(546, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Nº Cartão de Crédito";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(519, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Nome Impresso no cartão";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Gainsboro;
            this.label6.Location = new System.Drawing.Point(499, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "CPF/CNPJ do titular do cartão";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Gainsboro;
            this.label8.Location = new System.Drawing.Point(544, 252);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 15);
            this.label8.TabIndex = 13;
            this.label8.Text = "Código de segurança";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Gainsboro;
            this.label9.Location = new System.Drawing.Point(583, 296);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 15);
            this.label9.TabIndex = 14;
            this.label9.Text = "Parcelamento";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Gainsboro;
            this.label10.Location = new System.Drawing.Point(559, 213);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 15);
            this.label10.TabIndex = 12;
            this.label10.Text = "Validade do cartão";
            // 
            // textBoxCreditCardMonth
            // 
            this.textBoxCreditCardMonth.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.textBoxCreditCardMonth.FormattingEnabled = true;
            this.textBoxCreditCardMonth.Location = new System.Drawing.Point(672, 210);
            this.textBoxCreditCardMonth.Name = "textBoxCreditCardMonth";
            this.textBoxCreditCardMonth.Size = new System.Drawing.Size(70, 24);
            this.textBoxCreditCardMonth.TabIndex = 23;
            // 
            // textBoxCreditCardYear
            // 
            this.textBoxCreditCardYear.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.textBoxCreditCardYear.FormattingEnabled = true;
            this.textBoxCreditCardYear.Location = new System.Drawing.Point(761, 210);
            this.textBoxCreditCardYear.Name = "textBoxCreditCardYear";
            this.textBoxCreditCardYear.Size = new System.Drawing.Size(70, 24);
            this.textBoxCreditCardYear.TabIndex = 24;
            // 
            // textBoxCreditCardCpfCnpj
            // 
            this.textBoxCreditCardCpfCnpj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.textBoxCreditCardCpfCnpj.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxCreditCardCpfCnpj.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.textBoxCreditCardCpfCnpj.Location = new System.Drawing.Point(672, 169);
            this.textBoxCreditCardCpfCnpj.Name = "textBoxCreditCardCpfCnpj";
            this.textBoxCreditCardCpfCnpj.Size = new System.Drawing.Size(208, 23);
            this.textBoxCreditCardCpfCnpj.TabIndex = 25;
            // 
            // textBoxCreditCardName
            // 
            this.textBoxCreditCardName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.textBoxCreditCardName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxCreditCardName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.textBoxCreditCardName.Location = new System.Drawing.Point(672, 129);
            this.textBoxCreditCardName.Name = "textBoxCreditCardName";
            this.textBoxCreditCardName.Size = new System.Drawing.Size(292, 23);
            this.textBoxCreditCardName.TabIndex = 26;
            // 
            // textBoxCreditCardNumber
            // 
            this.textBoxCreditCardNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.textBoxCreditCardNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxCreditCardNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.textBoxCreditCardNumber.Location = new System.Drawing.Point(672, 88);
            this.textBoxCreditCardNumber.Name = "textBoxCreditCardNumber";
            this.textBoxCreditCardNumber.Size = new System.Drawing.Size(211, 23);
            this.textBoxCreditCardNumber.TabIndex = 27;
            // 
            // textBoxCreditCardCode
            // 
            this.textBoxCreditCardCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.textBoxCreditCardCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxCreditCardCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.textBoxCreditCardCode.Location = new System.Drawing.Point(672, 252);
            this.textBoxCreditCardCode.Name = "textBoxCreditCardCode";
            this.textBoxCreditCardCode.Size = new System.Drawing.Size(70, 23);
            this.textBoxCreditCardCode.TabIndex = 28;
            // 
            // textBoxCreditCardInstallment
            // 
            this.textBoxCreditCardInstallment.Location = new System.Drawing.Point(672, 294);
            this.textBoxCreditCardInstallment.Name = "textBoxCreditCardInstallment";
            this.textBoxCreditCardInstallment.Size = new System.Drawing.Size(70, 23);
            this.textBoxCreditCardInstallment.TabIndex = 29;
            // 
            // btnBuy
            // 
            this.btnBuy.Location = new System.Drawing.Point(479, 503);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Padding = new System.Windows.Forms.Padding(5);
            this.btnBuy.Size = new System.Drawing.Size(126, 48);
            this.btnBuy.TabIndex = 30;
            this.btnBuy.Text = "Comprar";
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // textBoxLinkSnkrs
            // 
            this.textBoxLinkSnkrs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.textBoxLinkSnkrs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxLinkSnkrs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.textBoxLinkSnkrs.Location = new System.Drawing.Point(323, 448);
            this.textBoxLinkSnkrs.Name = "textBoxLinkSnkrs";
            this.textBoxLinkSnkrs.Size = new System.Drawing.Size(467, 23);
            this.textBoxLinkSnkrs.TabIndex = 32;
            // 
            // checkedListBoxAccounts
            // 
            this.checkedListBoxAccounts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.checkedListBoxAccounts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBoxAccounts.ForeColor = System.Drawing.Color.Gainsboro;
            this.checkedListBoxAccounts.FormattingEnabled = true;
            this.checkedListBoxAccounts.Location = new System.Drawing.Point(61, 89);
            this.checkedListBoxAccounts.Name = "checkedListBoxAccounts";
            this.checkedListBoxAccounts.Size = new System.Drawing.Size(294, 90);
            this.checkedListBoxAccounts.TabIndex = 0;
            // 
            // btnDeleteAccount
            // 
            this.btnDeleteAccount.Location = new System.Drawing.Point(180, 188);
            this.btnDeleteAccount.Name = "btnDeleteAccount";
            this.btnDeleteAccount.Padding = new System.Windows.Forms.Padding(5);
            this.btnDeleteAccount.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteAccount.TabIndex = 33;
            this.btnDeleteAccount.Text = "Excluir";
            // 
            // btnAddAccount
            // 
            this.btnAddAccount.Location = new System.Drawing.Point(261, 188);
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.Padding = new System.Windows.Forms.Padding(5);
            this.btnAddAccount.Size = new System.Drawing.Size(75, 23);
            this.btnAddAccount.TabIndex = 34;
            this.btnAddAccount.Text = "Adicionar";
            this.btnAddAccount.Click += new System.EventHandler(this.btnAddAccount_Click);
            // 
            // checkedListBoxSneakers
            // 
            this.checkedListBoxSneakers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.checkedListBoxSneakers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBoxSneakers.ForeColor = System.Drawing.Color.Gainsboro;
            this.checkedListBoxSneakers.FormattingEnabled = true;
            this.checkedListBoxSneakers.Location = new System.Drawing.Point(61, 266);
            this.checkedListBoxSneakers.Name = "checkedListBoxSneakers";
            this.checkedListBoxSneakers.Size = new System.Drawing.Size(294, 90);
            this.checkedListBoxSneakers.TabIndex = 35;
            // 
            // btnAddNumberQuantity
            // 
            this.btnAddNumberQuantity.Location = new System.Drawing.Point(258, 362);
            this.btnAddNumberQuantity.Name = "btnAddNumberQuantity";
            this.btnAddNumberQuantity.Padding = new System.Windows.Forms.Padding(5);
            this.btnAddNumberQuantity.Size = new System.Drawing.Size(75, 23);
            this.btnAddNumberQuantity.TabIndex = 37;
            this.btnAddNumberQuantity.Text = "Adicionar";
            this.btnAddNumberQuantity.Click += new System.EventHandler(this.btnAddNumberQuantity_Click);
            // 
            // btnDeleteNumberQuantity
            // 
            this.btnDeleteNumberQuantity.Location = new System.Drawing.Point(177, 362);
            this.btnDeleteNumberQuantity.Name = "btnDeleteNumberQuantity";
            this.btnDeleteNumberQuantity.Padding = new System.Windows.Forms.Padding(5);
            this.btnDeleteNumberQuantity.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteNumberQuantity.TabIndex = 36;
            this.btnDeleteNumberQuantity.Text = "Excluir";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(142, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 15);
            this.label3.TabIndex = 38;
            this.label3.Text = "Numeração e Quantidade";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(1027, 585);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAddNumberQuantity);
            this.Controls.Add(this.btnDeleteNumberQuantity);
            this.Controls.Add(this.checkedListBoxSneakers);
            this.Controls.Add(this.btnAddAccount);
            this.Controls.Add(this.btnDeleteAccount);
            this.Controls.Add(this.textBoxLinkSnkrs);
            this.Controls.Add(this.btnBuy);
            this.Controls.Add(this.textBoxCreditCardInstallment);
            this.Controls.Add(this.textBoxCreditCardCode);
            this.Controls.Add(this.textBoxCreditCardNumber);
            this.Controls.Add(this.textBoxCreditCardName);
            this.Controls.Add(this.textBoxCreditCardCpfCnpj);
            this.Controls.Add(this.textBoxCreditCardYear);
            this.Controls.Add(this.textBoxCreditCardMonth);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkedListBoxAccounts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SNKRS - AutoBuy";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.textBoxCreditCardInstallment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private DarkUI.Controls.DarkComboBox textBoxCreditCardMonth;
        private DarkUI.Controls.DarkComboBox textBoxCreditCardYear;
        private DarkUI.Controls.DarkTextBox textBoxCreditCardCpfCnpj;
        private DarkUI.Controls.DarkTextBox textBoxCreditCardName;
        private DarkUI.Controls.DarkTextBox textBoxCreditCardNumber;
        private DarkUI.Controls.DarkTextBox textBoxCreditCardCode;
        private DarkUI.Controls.DarkNumericUpDown textBoxCreditCardInstallment;
        private DarkUI.Controls.DarkButton btnBuy;
        private DarkUI.Controls.DarkTextBox textBoxLinkSnkrs;
        private System.Windows.Forms.CheckedListBox checkedListBoxAccounts;
        private DarkUI.Controls.DarkButton btnDeleteAccount;
        private DarkUI.Controls.DarkButton btnAddAccount;
        private System.Windows.Forms.CheckedListBox checkedListBoxSneakers;
        private DarkUI.Controls.DarkButton btnAddNumberQuantity;
        private DarkUI.Controls.DarkButton btnDeleteNumberQuantity;
        private System.Windows.Forms.Label label3;
    }
}