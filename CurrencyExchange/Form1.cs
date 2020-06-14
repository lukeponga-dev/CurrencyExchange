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
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExchange_Click(object sender, EventArgs e)
        {
            //String to Decimal
            Decimal money = Convert.ToDecimal(txtNZD.Text);
            Decimal exchange = Convert.ToDecimal(txtEchRt.Text);
            // convert int for money counter
            // varibiles
            var conversion = money / exchange;
            var convToStr = Convert.ToString(conversion);

            txtResult.Text = convToStr;

        }
    }
}
