using StockQuant.Models;

namespace StockQuant
{
    public interface IProfitLossCalculatorService
    {
        ProfitLoss CalculateProfitLoss(Buy buy, Sell sell);

        Sell GetSellActionForTargetProfitPercentage(Buy buy, double targetProfit);

        Sell GetSellActionForTargetProfit(Buy buy, double targetProfit);
    }
}
