using Tyuiu.KolganenkoRV.Sprint1.Task3.V7.Lib;

namespace Tyuiu.KolganenkoRV.Sprint1.Task3.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2;
            var res = ds.VerstsToKilometers(x);
            Assert.AreEqual(2.134, res);
        }
    }
}
