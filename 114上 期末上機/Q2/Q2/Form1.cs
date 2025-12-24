using System;
using System.Windows.Forms;

namespace Q2
{
    public partial class Form1 : Form
    {
        // prices
        private const decimal PRICE_OIL = 780m;
        private const decimal PRICE_LUBE = 540m;
        private const decimal PRICE_RADIATOR = 900m;
        private const decimal PRICE_TRANS = 2400m;
        private const decimal PRICE_INSPECT = 450m;
        private const decimal PRICE_MUFFLER = 3000m;
        private const decimal PRICE_TIRE = 600m;
        private const decimal LABOR_RATE = 80m; // assume NT$80 per hour
        private const decimal TAX_RATE = 0.06m;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
        
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
       
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labelHours_Click(object sender, EventArgs e)
        {

        }
    }
}
