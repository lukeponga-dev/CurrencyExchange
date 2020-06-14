using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurrencyExchange
{
    public partial class Form1 : Form
    {
        Double UsDollar = 0.64;
        Double Euro = 0.57;
        Double NZD = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbCurrency.Text = "Choose One...";
            cmbCurrency.Items.Add("US Dollar");
            cmbCurrency.Items.Add("Euro");
            cmbCurrency.Items.Add("NewZealandDollars");
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnCurrency.Visible = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            btnCurrency.Visible = true;
            txtConvert.Clear();
            lblConvert.Text = "";

        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            Double NewZealndDollar = Double.Parse(txtConvert.Text);
            if(cmbCurrency.Text =="UsDollar")
            {
                lblConvert.Text = System.Convert.ToString(("$" + NewZealndDollar * UsDollar));
            }
        }
    }
}
