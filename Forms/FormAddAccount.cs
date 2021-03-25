using DarkUI.Forms;
using OpenQA.Selenium.Chrome;
using SNKRS.Models;
using SNKRS.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SNKRS
{
    public partial class FormAddAccount : DarkForm
    {
        public List<ChromeDriver> chromeDriver { get; set; }
        public Account account { get; set; }
        public FormAddAccount()
        {
            InitializeComponent();
        }

        private void FormAddAccount_Load(object sender, EventArgs e)
        {
            //ChromeDriver chrome1 = new ChromeDriver(BrowserSettings.ChromeDriverService, BrowserSettings.ChromeOptions(null));
            //chrome1.Navigate().GoToUrl("https://www.nike.com.br/Snkrs1");

            //ChromeDriver chrome2 = new ChromeDriver(BrowserSettings.ChromeDriverService, BrowserSettings.ChromeOptions(null));
            //chrome2.Navigate().GoToUrl("https://www.nike.com.br/Snkrs2");

        }

        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            if (textBoxEmail.Text != "" && textBoxPassword.Text != "")
            {
                account = new Account
                {
                    email = textBoxEmail.Text,
                    password = textBoxPassword.Text
                };
                Visible = false;
            }
        }
    }
}