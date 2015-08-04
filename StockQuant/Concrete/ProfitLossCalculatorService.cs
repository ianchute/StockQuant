using System;
using StockQuant.Config;
using StockQuant.Models;

namespace StockQuant.Concrete
{
    public class ProfitLossCalculatorService : IProfitLossCalculatorService
    {
        private readonly IFeeCalculatorService feeCalc;
        private readonly IMathConfig config;

        public ProfitLossCalculatorService(IFeeCalculatorService feeCalc, IMathConfig config)
        {
            this.feeCalc = feeCalc;
            this.config = config;
        }

        public ProfitLoss CalculateProfitLoss(Buy buy, Sell sell)
        {
            double buyPrice = buy.Price * buy.Volume;
            double sellPrice = sell.Price * sell.Volume;
            double buyFees = feeCalc.CalculateFees(buy).Total;
            double sellFees = feeCalc.CalculateFees(sell).Total;
            double buyNet = buyPrice + buyFees;
            double sellNet = sellPrice - sellFees;

            ProfitLoss result = new ProfitLoss()
            {
                Amount = sellNet - buyNet,
                Ratio = (sellNet / buyNet) - 1.0
            };

            return result;
        }

        public Sell GetSellActionForTargetProfitPercentage(Buy buy, double targetProfit)
        {
            Sell sell = new Sell()
            {
                Price = buy.Price * (1 + targetProfit),
                Volume = buy.Volume
            };

            for (int i = 0; i < int.MaxValue; ++i )
            {
                ProfitLoss pl = CalculateProfitLoss(buy, sell);
                if (Math.Abs(pl.Ratio - targetProfit) < config.epsilon)
                    break;
                if (targetProfit < pl.Ratio)
                    sell.Price -= config.epsilon;
                else
                    sell.Price += config.epsilon;
            }

            return sell;
        }

        public Sell GetSellActionForTargetProfit(Buy buy, double targetProfit)
        {
            Sell sell = new Sell()
            {
                Price = buy.Price + targetProfit,
                Volume = buy.Volume
            };

            for (int i = 0; i < int.MaxValue; ++i)
            {
                ProfitLoss pl = CalculateProfitLoss(buy, sell);
                if (Math.Abs(pl.Amount - targetProfit) < config.epsilon)
                    break;
                if (targetProfit < pl.Ratio)
                    sell.Price -= config.epsilon;
                else
                    sell.Price += config.epsilon;
            }

            return sell;
        }
    }
}