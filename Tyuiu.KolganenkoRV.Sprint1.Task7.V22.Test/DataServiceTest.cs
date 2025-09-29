using Tyuiu.KolganenkoRV.Sprint1.Task7.V22.Lib;

namespace Tyuiu.KolganenkoRV.Sprint1.Task7.V22.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void Validexpression()
        {
            DataService ds = new DataService();
            double x = 0.5;
            double y = 0.3;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(1.215, res);
        }
    }
}
