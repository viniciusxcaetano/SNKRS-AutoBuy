using DarkUI.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DarkUI.Collections;
using DarkUI.Config;
using DarkUI.Controls;
using DarkUI.Docking;
using DarkUI.Renderers;
using SNKRS.Models;

namespace SNKRS.Forms
{
    public partial class FormMain : DarkForm
    {
        public List<Sneaker> Sneakers { get; set; }
        public List<Account> Accounts { get; set; }

        public FormMain()
        {
            InitializeComponent();
        }

        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            FormAddAccount formAddAccount = new FormAddAccount();
            formAddAccount.Show();
            formAddAccount.VisibleChanged += formAddAccountChanged;
        }

        private void btnAddNumberQuantity_Click(object sender, EventArgs e)
        {
            FormAddSneaker formNumberQuantity = new FormAddSneaker();
            formNumberQuantity.Show();
            formNumberQuantity.VisibleChanged += formNumberQuantityChanged;
        }

        private void formNumberQuantityChanged(object sender, EventArgs e)
        {
            FormAddSneaker formNumberQuantity = (FormAddSneaker)sender;
            if (!formNumberQuantity.Visible)
            {
                Sneakers.Add(formNumberQuantity.sneaker);
                checkedListBoxSneakers.Items.Clear();
                checkedListBoxSneakers.Items.AddRange(Sneakers.Select(s => "Númeração: " + s.Number.ToString() + " - Quantidade: " + s.Quantity.ToString()).ToArray());
                formNumberQuantity.Dispose();
            }
        }

        private void formAddAccountChanged(object sender, EventArgs e)
        {
            FormAddAccount formAddAccount = (FormAddAccount)sender;
            if (!formAddAccount.Visible)
            {
                Accounts.Add(formAddAccount.account);
                checkedListBoxAccounts.Items.AddRange(Accounts.Select(p => p.email).ToArray());
                formAddAccount.Dispose();
            }

        }

        private void FormMain_Load(object sender, EventArgs e)
        {

            Sneakers = new List<Sneaker>();
            Accounts = new List<Account>();
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {

        }
    }
}
