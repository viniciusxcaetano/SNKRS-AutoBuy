using DarkUI.Forms;
using SNKRS.Models;
using System;

namespace SNKRS.Forms
{
    public partial class FormAddSneaker : DarkForm
    {
        public Sneaker sneaker { get; set; }

        public FormAddSneaker()
        {
            InitializeComponent();
        }

        private void numUpDownNumber_ValueChanged(object sender, EventArgs e)
        {
        }

        private void FormNumberQuantity_Load(object sender, EventArgs e)
        {
            numUpDownNumber.Value = 35;
            numUpDownQuantity.Value = 1;
        }

        private void btnAddNumberQuantity_Click(object sender, EventArgs e)
        {
            sneaker = new Sneaker
            {
                Number = numUpDownNumber.Value,
                Quantity = numUpDownQuantity.Value
            };

            Visible = false;
        }
    }
}