using Tyuiu.ZainetdinovRA.Sprint3.Task0.V8.Lib;
namespace Tyuiu.ZainetdinovRA.Sprint3.Task0.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();
            double a = 0.25;
            double wait = 0.019;
            double result = ds.GetMultiplySeries(a, 1, 10);
            Assert.AreEqual(wait, result);
        }
    }
}
