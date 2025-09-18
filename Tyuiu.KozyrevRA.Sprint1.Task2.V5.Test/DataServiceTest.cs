using System.Net.Http.Headers;
using Tyuiu.KozyrevRA.Sprint1.Task2.V5.Lib;
namespace Tyuiu.KozyrevRA.Sprint1.Task2.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 6;
            var res = ds.CalculateSideSquare(x); 
            Assert.AreEqual(216, res);
        }
    }
}
