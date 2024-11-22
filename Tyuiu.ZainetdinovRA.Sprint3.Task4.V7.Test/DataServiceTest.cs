using Tyuiu.ZainetdinovRA.Sprint3.Task4.V7.Lib;
namespace Tyuiu.ZainetdinovRA.Sprint3.Task4.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ExpressionValid()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 4;
            double wait = 1231.499;
            double res = ds.Calculate(startValue, stopValue);
            Assert.AreEqual(wait, res);
        }
    }
}
