using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using StockQuant.Models;

namespace StockQuant.WinForm.Forms
{
    public partial class QuantForm : Form
    {
        private readonly IProfitLossCalculatorService plSvc;
        private readonly IFeeCalculatorService feeSvc;

        public QuantForm(IProfitLossCalculatorService plSvc, IFeeCalculatorService feeSvc)
        {
            InitializeComponent();
            this.plSvc = plSvc;
            this.feeSvc = feeSvc;
        }

        private void btnQuant_Click(object sender, EventArgs e)
        {
            if (worker.IsBusy)
                MessageBox.Show("The previous operation has not yet finished. Please wait.");

            worker.DoWork += worker_DoWork;
            worker.RunWorkerCompleted += worker_RunWorkerCompleted;

            worker.RunWorkerAsync();
        }

        void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            worker.DoWork -= worker_DoWork;
            worker.RunWorkerCompleted -= worker_RunWorkerCompleted;
        }

        void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            if (this.InvokeRequired)
                Invoke(new MethodInvoker(Quant));
            else
                Quant();
        }

        void Quant()
        {
            double price = 0;
            double volume = 0;
            double gross = 0;

            try
            {
                if (txtPrice.Text.Length != 0)
                    price = double.Parse(txtPrice.Text);
                if (txtVolume.Text.Length != 0)
                    volume = double.Parse(txtVolume.Text);
                if (txtGross.Text.Length != 0)
                    gross = double.Parse(txtGross.Text);

                if (txtPrice.Text.Length == 0)
                {
                    price =  gross / volume;
                    txtPrice.Text = string.Format("{0}", price);
                }
                if (txtVolume.Text.Length == 0)
                {
                    volume = gross / price;
                    txtVolume.Text = string.Format("{0}", volume);
                }
                gross = price * volume;
                txtGross.Text = string.Format("{0}", gross);

                Buy buy = new Buy()
                {
                    Price = price,
                    Volume = (int)volume
                };
                Fees buyFees = feeSvc.CalculateFees(buy);
                txtBuyFees.Clear();
                txtBuyFees.Text += string.Format("Gross     : {0}\n", buy.Price * buy.Volume);
                txtBuyFees.Text += string.Format("Fees      : {0}\n", buyFees.Total);
                txtBuyFees.Text += string.Format("      Commission: {0}\n", buyFees.Commission);
                txtBuyFees.Text += string.Format("      PSE Fee   : {0}\n", buyFees.PseFee);
                txtBuyFees.Text += string.Format("      SCCP Fee  : {0}\n", buyFees.SccpFee);
                txtBuyFees.Text += string.Format("---------------------------\n");
                txtBuyFees.Text += string.Format("Net       : {0}\n", (buy.Price * buy.Volume) + buyFees.Total);

                txtPlTable.Clear();
                PrintForProfits(buy, -0.10, -0.05, 0.0, 0.01, 0.05, 0.10, 0.15, 0.20);
            }
            catch
            { }
        }

        void PrintForProfits(Buy buy, params double[] profits)
        {
            txtPlTable.Text += "Profit-Loss table\n\n";

            txtPlTable.Text += "Target".PadLeft(10, ' ');
            foreach (double profit in profits)
                txtPlTable.Text += string.Format("{0}%", profit * 100).PadLeft(10, ' ');
            txtPlTable.Text += "\n";
 
            txtPlTable.Text += "Profit".PadLeft(10, ' ');
            foreach (double profit in profits)
                txtPlTable.Text += string.Format("P{0}", buy.Price * buy.Volume * profit).PadLeft(10, ' ');
            txtPlTable.Text += "\n";

            List<Sell> sells = new List<Sell>();

            txtPlTable.Text += "Price".PadLeft(10, ' ');
            foreach (double profit in profits)
            {
                Sell sell = plSvc.GetSellActionForTargetProfitPercentage(buy, profit);
                sells.Add(sell);
                txtPlTable.Text += string.Format("P{0}", Math.Round(sell.Price, 4)).PadLeft(10, ' ');
            }
            txtPlTable.Text += "\n";

            txtPlTable.Text += "Diff".PadLeft(10, ' ');
            foreach (Sell sell in sells)
                txtPlTable.Text += string.Format("P{0}", Math.Round(sell.Price - buy.Price, 4)).PadLeft(10, ' ');
            txtPlTable.Text += "\n";

            txtPlTable.Text += "Diff%".PadLeft(10, ' ');
            foreach (Sell sell in sells)
                txtPlTable.Text += string.Format("{0}%", Math.Round(100 * (sell.Price / buy.Price - 1), 4)).PadLeft(10, ' ');
            txtPlTable.Text += "\n";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (worker.IsBusy)
                MessageBox.Show("The previous operation has not yet finished. Please wait.");
            this.Hide();
        }
    }
}