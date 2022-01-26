using Newtonsoft.Json.Linq;
using DesignPatterns.DecoratorPattern.MultiDecoratedStockGrabber.Models;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace DesignPatterns.DecoratorPattern.MultiDecoratedStockGrabber
{
    public class AlphaVantageClient : IAlphaVantageClient
    {

        private string _apiKey = "ZYVHAG3MBHY6QVMS";
        private string _apiUrl = "https://www.alphavantage.co/query?";
        private Tuple<TodayStockValue, StockMeta> _stockData;

        public TodayStockValue CurrentStockValue { get; set; } = new TodayStockValue();
        public StockMeta StockMetaInfo { get; set; } = new StockMeta();


        public async Task<Tuple<TodayStockValue, StockMeta>> GetLatestStockData(string symbol)
        {
            var rawStockData = await GetStockPricesAsync(symbol);

            dynamic stockDataJSONObj = JObject.Parse(rawStockData);

            //string today = GetEasternDate();
            string today = DateTime.Now.AddDays(-7).ToString("2022-01-21");

            var stockMetaInfo = stockDataJSONObj["Meta Data"];
            var stockLatestData = stockDataJSONObj["Time Series (Daily)"][today];

            Mapper(stockMetaInfo, stockLatestData);

            _stockData = new Tuple<TodayStockValue, StockMeta>(CurrentStockValue, StockMetaInfo);

            return _stockData;
        }


        private void Mapper(dynamic stockMetaInfo, dynamic stockLatestData)
        {
            if (stockMetaInfo == null || stockLatestData == null)
            {
                throw new Exception("Stock info is empty, please check raw JSON output string.");
            }

            try
            {
                StockMetaInfo.Information = stockMetaInfo["1. Information"];
                StockMetaInfo.Symbol = stockMetaInfo["2. Symbol"];
                StockMetaInfo.LastRefreshed = stockMetaInfo["3. Last Refreshed"];
                StockMetaInfo.OutputSize = stockMetaInfo["4. Output Size"];
                StockMetaInfo.TimeZone = stockMetaInfo["5. Time Zone"];

                CurrentStockValue.Open = stockLatestData["1. open"];
                CurrentStockValue.High = stockLatestData["2. high"]; 
                CurrentStockValue.Low = stockLatestData["3. low"];
                CurrentStockValue.Close = stockLatestData["4. close"];
                CurrentStockValue.Volume = stockLatestData["5. volume"];
            }
            catch (Exception e)
            {
                ;
                throw;
            }

        }

        private async Task<string> GetStockPricesAsync(string symbol)
        {

            var client = new HttpClient();
            using (client)
            {

                var requestUriBuilder = new UriBuilder(_apiUrl);
                requestUriBuilder.Query = $"function=TIME_SERIES_DAILY&symbol={symbol}&outputsize=compact&apikey={_apiKey}";

                var request = requestUriBuilder.Uri;

                var response = await client.GetStringAsync(request);

                return response;
            }         

        }

        private static string GetEasternDate()
        {
            var timeUtc = DateTime.UtcNow;
            TimeZoneInfo easternZone = TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time");
            DateTime easternTime = TimeZoneInfo.ConvertTimeFromUtc(timeUtc, easternZone);

            var today = string.Empty;

            var isSunday = easternTime.DayOfWeek == DayOfWeek.Sunday;
            var isSaturday = easternTime.DayOfWeek == DayOfWeek.Saturday;
            var isMonday = easternTime.DayOfWeek == DayOfWeek.Monday;

            if (easternTime.Hour > 12 && !isSaturday && !isSunday)  //this makes sense for M-F... 
            {
                today = easternTime.ToString("yyyy-MM-dd"); //and after 12pm
            }
            else if (!isSaturday && !isSunday) //only for M-F
            {
                if (isMonday)
                {
                    today = easternTime.AddDays(-3).ToString("yyyy-MM-dd");
                }
                else
                {
                    today = easternTime.AddDays(-1).ToString("yyyy-MM-dd");
                }

            }
            else if (isSaturday)
            {
                //Date must be Saturday or Sunday
                //use Friday for stock data

                today = easternTime.AddDays(-1).ToString("yyyy-MM-dd");

            }
            else if (isSunday)
            {
                //Date must be Saturday or Sunday
                //use Friday for stock data

                today = easternTime.AddDays(-2).ToString("yyyy-MM-dd");

            }

            return today;
        }

    }
}
