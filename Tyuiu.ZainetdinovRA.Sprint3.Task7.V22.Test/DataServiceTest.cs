using Tyuiu.ZainetdinovRA.Sprint3.Task7.V22.Lib;
namespace Tyuiu.ZainetdinovRA.Sprint3.Task7.V22.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ExpressionValid()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;

            double[] result = ds.GetMassFunction(startValue, stopValue);

            double[] wait = { 8.04, 6.68, 4.84, 1.76, 0.45, 0.5, -0.87, -2.42, -3.88, -6.83, -8.88 };
            CollectionAssert.AreEqual(wait, result);
        }
    }
}
