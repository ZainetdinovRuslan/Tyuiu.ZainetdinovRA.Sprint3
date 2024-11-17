using Tyuiu.ZainetdinovRA.Sprint3.Task1.V15.Lib;
namespace Tyuiu.ZainetdinovRA.Sprint3.Task1.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ExpressionValid()
        {
            DataService ds = new DataService();
            int x = 2;
            int wait = 208845;
            double result = ds.GetMultiplySeries(x, 1, 5);
            Assert.AreEqual(wait, result);
        }
    }
}
