using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace StockQuant.WinForm.Forms
{
    public partial class MainForm : Form
    {
        private readonly List<Form> forms;
        private readonly QuantForm frmQuant;

        public MainForm(QuantForm frmQuant)
        {
            InitializeComponent();

            this.frmQuant = frmQuant;

            forms = new List<Form>();
            forms.Add(frmQuant);
        }

        private void btnQuant_Click(object sender, EventArgs e)
        {
            frmQuant.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            foreach(Form form in forms)
                if(!form.IsDisposed)
                    form.Close();

            this.Close();
        }
    }
}