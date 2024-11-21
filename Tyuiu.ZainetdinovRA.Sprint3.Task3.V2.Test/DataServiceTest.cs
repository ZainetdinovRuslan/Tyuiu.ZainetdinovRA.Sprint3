using Tyuiu.ZainetdinovRA.Sprint3.Task3.V2.Lib;
namespace Tyuiu.ZainetdinovRA.Sprint3.Task3.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ExpressionValid()
        {
            DataService ds = new DataService();
            string value = "zzzzzz";
            char c = 'z';
            int wait = 6;
            int result = ds.GetMaxCharCount(value, c);
            Assert.AreEqual(wait, result);
        }
    }
}
