using StockQuant.Config;
using StockQuant.Models;

namespace StockQuant.Concrete
{
    public class FeeCalculatorService : IFeeCalculatorService
    {
        private readonly IFeesConfig config;

        public FeeCalculatorService(IFeesConfig config)
        {
            this.config = config;
        }

        public Fees CalculateFees(StockAction action)
        {
            double grossValue = action.Price * action.Volume;
            Fees result = new Fees();

            result.Commission = CalculateBrokerCommissions(grossValue);
            result.PseFee = CalculatePseFee(grossValue);
            result.SccpFee = CalculateSccpFee(grossValue);
            if (action is Sell)
                result.SalesTax = CalculateSalesTax(grossValue);

            result.Total = 
                result.Commission 
                + result.PseFee 
                + result.SalesTax 
                + result.SccpFee;

            return result;
        }

        protected double CalculateBrokerCommissions(double grossValue)
        {
            double commissionRate = config.commission;
            double minimumCommission = config.commission_min;
            double commissionVatRate = config.vat_on_commission;
            
            double commission = commissionRate * grossValue;
            if (commission < minimumCommission)
                commission = minimumCommission;
            double commissionAfterTax = commission * (1.0 + commissionVatRate);

            return commissionAfterTax;
        }

        protected double CalculatePseFee(double grossValue)
        {
            double pseFeeRate = config.pse_fee;
            double pseFee = grossValue * pseFeeRate;

            return pseFee;
        }

        protected double CalculateSccpFee(double grossValue)
        {
            double sccpFeeRate = config.sccp_fee;
            double sccpFee = grossValue * sccpFeeRate;

            return sccpFee;
        }

        protected double CalculateSalesTax(double grossValue)
        {
            double salesTaxRate = config.sales_tax;
            double salesTax = grossValue * salesTaxRate;

            return salesTax;
        }
    }
}