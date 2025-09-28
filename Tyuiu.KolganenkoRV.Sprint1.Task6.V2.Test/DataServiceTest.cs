using System.Net.Security;
using Tyuiu.KolganenkoRV.Sprint1.Task6.V2.Lib;

namespace Tyuiu.KolganenkoRV.Sprint1.Task6.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            string x = "Hello, world";
            var res = ds.CheckHello(x);
            Assert.AreEqual(true, res);
        }
    }
}
