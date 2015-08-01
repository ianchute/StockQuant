using SimpleInjector;
using StockQuant.Concrete;
using StockQuant.Config;

namespace StockQuant.WinForm.Config
{
    public static class DependencyConfig
    {
        public static void Configure(Container _)
        {
            IBoardLotConfig[] lotConfigs = new IBoardLotConfig[]
            {
                GetBoardLotConfig('A'),
                GetBoardLotConfig('B'),
                GetBoardLotConfig('C'),
                GetBoardLotConfig('D'),
                GetBoardLotConfig('E'),
                GetBoardLotConfig('F'),
                GetBoardLotConfig('G'),
                GetBoardLotConfig('H'),
                GetBoardLotConfig('I'),
                GetBoardLotConfig('J'),
                GetBoardLotConfig('K'),
                GetBoardLotConfig('L'),
                GetBoardLotConfig('M'),
                GetBoardLotConfig('N'),
                GetBoardLotConfig('O')
            };
            _.RegisterSingle<IBoardLotConfig[]>(lotConfigs);

            IFeesConfig feesConfig = Configurator.Configurator.Configure<FeesConfig>("sell"); // TODO: Contextual injection.
            _.RegisterSingle<IFeesConfig>(feesConfig);

            IMathConfig mathConfig = Configurator.Configurator.Configure<MathConfig>("math");
            _.RegisterSingle<IMathConfig>(mathConfig);

            _.RegisterSingle<IBoardLotCalculatorService, BoardLotCalculatorService>();
            _.RegisterSingle<IFeeCalculatorService, FeeCalculatorService>();
            _.RegisterSingle<IProfitLossCalculatorService, ProfitLossCalculatorService>();
        }

        private static IBoardLotConfig GetBoardLotConfig(char lotSymbol)
        {
            return Configurator.Configurator.Configure<BoardLotConfig>("lot" + lotSymbol);
        }
    }
}
