using StockQuant.Models;

namespace StockQuant
{
    public interface IFeeCalculatorService
    {
        Fees CalculateFees(StockAction action);
    }
}