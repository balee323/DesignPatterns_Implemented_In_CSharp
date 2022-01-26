using DesignPatterns.DecoratorPattern.MultiDecoratedStockGrabber.Models;
using NLog;
using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace DesignPatterns.DecoratorPattern.MultiDecoratedStockGrabber
{
    public class AlphaVantageLoggingDecorator : IAlphaVantageClient
    {

        private IAlphaVantageClient _innerAlphaVantageClient;
        private Logger _log = LogManager.GetCurrentClassLogger();


        public AlphaVantageLoggingDecorator(IAlphaVantageClient alphaVantageClient)
        {
            _innerAlphaVantageClient = alphaVantageClient;
        }

        public async Task<Tuple<TodayStockValue, StockMeta>> GetLatestStockData(string symbol)
        {
            Tuple<TodayStockValue, StockMeta> results = null;
            Stopwatch sp = new Stopwatch();
            try
            {
                sp.Start();
                results = await _innerAlphaVantageClient.GetLatestStockData(symbol);
                sp.Stop();
            }
            catch(Exception ex)
            {
                _log.Error(ex);
            }
            finally
            {
                _log.Debug($"Time for call to GetLatestStockData milliseconds: {sp.ElapsedMilliseconds}");
            }

            return results;
        }
    }
}
