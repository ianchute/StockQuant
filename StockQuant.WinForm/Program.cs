using System;
using System.Windows.Forms;
using SimpleInjector;
using StockQuant.WinForm.Config;
using StockQuant.WinForm.Forms;

namespace StockQuant.WinForm
{
    static class Program
    {
        private static Container container = new Container();

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            DependencyConfig.Configure(container);
            Form mainForm = container.GetInstance<MainForm>();
            Application.Run(mainForm);
        }
    }
}