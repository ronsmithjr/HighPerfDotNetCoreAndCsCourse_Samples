using System;
using System.Diagnostics;
using System.Linq;
using System.Threading;

namespace _02_03_Demo1_PerfTips
{
    /// <summary>
    /// Sample application for the Visual Studio PerfTips demo.
    /// We measure the difference between the 
    /// hpr.GetHistoricalQuotes("MSFT") call and the 
    /// Rsi.CalculateRsi(historicalData, 14, CancellationToken.None) call with PerfTips
    /// </summary>
    class Program
    {
        static void Main()
        {
            try
            {
                HistoricalPriceReader hpr = new HistoricalPriceReader();
                var historicalData = hpr.GetHistoricalQuotes("MSFT");
            
                var data = Rsi.CalculateRsi(historicalData, 14, CancellationToken.None);
                Console.WriteLine($"Number of RSI Values: {data.Count()}");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
