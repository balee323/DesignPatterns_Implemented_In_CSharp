using DesignPatterns.DecoratorPattern.StockGrabber;
using NUnit.Framework;
using System.Threading.Tasks;

namespace DesignPatterns.StockGrabber.Tests
{
    [TestFixture]
    class AlphaVantageTests
    {

        AlphaVantageClient _client;
        

        [SetUp]
        public void Setup()
        {
            _client = new AlphaVantageClient();
        }

        [Test]
        public async Task Get_AmdStockPrice_NotNull()
        {
            var stockdata = await _client.GetLatestStockData("AMD");

            Assert.IsNotNull(stockdata);
        }


        [Test]
        public async Task Get_AmdStockPrice_StockPrice_and_AMD_NotNull()
        {
            var stockdata = await _client.GetLatestStockData("AMD");


            Assert.IsTrue(stockdata.Item2.Symbol == "AMD");
            Assert.IsNotNull(stockdata.Item1.High);

        }


    }
}
