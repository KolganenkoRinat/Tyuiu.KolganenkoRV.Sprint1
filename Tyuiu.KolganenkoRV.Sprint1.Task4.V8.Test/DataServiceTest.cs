using Tyuiu.KolganenkoRV.Sprint1.Task4.V8.Lib;

namespace Tyuiu.KolganenkoRV.Sprint1.Task4.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 5;
            double y = 1;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(2.125, res);
        }
    }
}
