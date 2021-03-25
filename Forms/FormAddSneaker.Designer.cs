
namespace SNKRS.Forms
{
    partial class FormAddSneaker
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
            this.numUpDownNumber = new DarkUI.Controls.DarkNumericUpDown();
            this.darkLabel1 = new DarkUI.Controls.DarkLabel();
            this.darkLabel2 = new DarkUI.Controls.DarkLabel();
            this.numUpDownQuantity = new DarkUI.Controls.DarkNumericUpDown();
            this.btnAddNumberQuantity = new DarkUI.Controls.DarkButton();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // numUpDownNumber
            // 
            this.numUpDownNumber.Location = new System.Drawing.Point(146, 63);
            this.numUpDownNumber.Name = "numUpDownNumber";
            this.numUpDownNumber.Size = new System.Drawing.Size(120, 23);
            this.numUpDownNumber.TabIndex = 1;
            this.numUpDownNumber.ValueChanged += new System.EventHandler(this.numUpDownNumber_ValueChanged);
            // 
            // darkLabel1
            // 
            this.darkLabel1.AutoSize = true;
            this.darkLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel1.Location = new System.Drawing.Point(71, 65);
            this.darkLabel1.Name = "darkLabel1";
            this.darkLabel1.Size = new System.Drawing.Size(69, 15);
            this.darkLabel1.TabIndex = 2;
            this.darkLabel1.Text = "Numeração";
            // 
            // darkLabel2
            // 
            this.darkLabel2.AutoSize = true;
            this.darkLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel2.Location = new System.Drawing.Point(71, 129);
            this.darkLabel2.Name = "darkLabel2";
            this.darkLabel2.Size = new System.Drawing.Size(69, 15);
            this.darkLabel2.TabIndex = 3;
            this.darkLabel2.Text = "Quantidade";
            // 
            // numUpDownQuantity
            // 
            this.numUpDownQuantity.Location = new System.Drawing.Point(146, 127);
            this.numUpDownQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDownQuantity.Name = "numUpDownQuantity";
            this.numUpDownQuantity.Size = new System.Drawing.Size(120, 23);
            this.numUpDownQuantity.TabIndex = 4;
            this.numUpDownQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnAddNumberQuantity
            // 
            this.btnAddNumberQuantity.Location = new System.Drawing.Point(105, 220);
            this.btnAddNumberQuantity.Name = "btnAddNumberQuantity";
            this.btnAddNumberQuantity.Padding = new System.Windows.Forms.Padding(5);
            this.btnAddNumberQuantity.Size = new System.Drawing.Size(130, 51);
            this.btnAddNumberQuantity.TabIndex = 5;
            this.btnAddNumberQuantity.Text = "Adicionar";
            this.btnAddNumberQuantity.Click += new System.EventHandler(this.btnAddNumberQuantity_Click);
            // 
            // FormAddSneaker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 337);
            this.Controls.Add(this.btnAddNumberQuantity);
            this.Controls.Add(this.numUpDownQuantity);
            this.Controls.Add(this.darkLabel2);
            this.Controls.Add(this.darkLabel1);
            this.Controls.Add(this.numUpDownNumber);
            this.Name = "FormAddSneaker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar Sneaker";
            this.Load += new System.EventHandler(this.FormNumberQuantity_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DarkUI.Controls.DarkNumericUpDown numUpDownNumber;
        private DarkUI.Controls.DarkLabel darkLabel1;
        private DarkUI.Controls.DarkLabel darkLabel2;
        private DarkUI.Controls.DarkNumericUpDown numUpDownQuantity;
        private DarkUI.Controls.DarkButton btnAddNumberQuantity;
    }
}