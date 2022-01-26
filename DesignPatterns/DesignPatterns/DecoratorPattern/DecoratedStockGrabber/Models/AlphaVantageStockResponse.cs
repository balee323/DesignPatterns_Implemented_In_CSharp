namespace DesignPatterns.DecoratorPattern.DecoratedStockGrabber.Models
{

    public class TodayStockValue
    {
        public string Open { get; set; }
        public string High { get; set; }
        public string Low { get; set; }
        public string Close { get; set; }
        public string Volume { get; set; }
    }


    //public class StockMetaInfo

    public class StockMeta
    {
        public string Information { get; set; }
        public string Symbol { get; set; }
        public string LastRefreshed { get; set; }
        public string OutputSize { get; set; }
        public string TimeZone { get; set; }
    }

}