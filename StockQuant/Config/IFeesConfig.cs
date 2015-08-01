namespace StockQuant.Config
{
    public interface IFeesConfig
    {
        double commission { get; set; }

        double commission_min { get; set; }

        double vat_on_commission { get; set; }

        double pse_fee { get; set; }

        double sccp_fee { get; set; }

        double sales_tax { get; set; }
    }
}