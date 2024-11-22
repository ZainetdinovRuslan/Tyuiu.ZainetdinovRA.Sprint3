using Tyuiu.ZainetdinovRA.Sprint3.Task6.V12.Lib;
namespace Tyuiu.ZainetdinovRA.Sprint3.Task6.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ExpressionValid()
        {
            DataService ds = new DataService();
            int startValue = 9;
            int stopValue = 18;
            int wait = 221;
            int result = ds.GetSumTheDivisors(startValue, stopValue);
            Assert.AreEqual(wait, result);
        }
    }
}
