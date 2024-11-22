using Tyuiu.ZainetdinovRA.Sprint3.Task5.V20.Lib;
namespace Tyuiu.ZainetdinovRA.Sprint3.Task5.V20.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ExpressionValid()
        {
            DataService ds = new DataService();
            int x = 5;
            int stVal1 = 1;
            int stopVal1 = 3;
            int stVal2 = 1;
            int stopVal2 = 6;
            double wait = 50584.322;
            double result = ds.GetSumSumSeries(x, stVal1, stVal2, stopVal1, stopVal2);
            Assert.AreEqual(wait, result);
        }
    }
}
