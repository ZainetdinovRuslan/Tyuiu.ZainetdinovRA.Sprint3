using Tyuiu.ZainetdinovRA.Sprint3.Task2.V18.Lib;
namespace Tyuiu.ZainetdinovRA.Sprint3.Task2.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ExpressionValid()
        {
            DataService ds = new DataService();
            int x = 1;
            double wait = 287.18;
            double result = ds.GetMultiplySeries(x, 1, 14);
            Assert.AreEqual(wait, result);
        }
    }
}
