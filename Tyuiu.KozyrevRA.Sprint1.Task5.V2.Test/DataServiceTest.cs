using Tyuiu.KozyrevRA.Sprint1.Task5.V2.Lib;
namespace Tyuiu.KozyrevRA.Sprint1.Task5.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 100.0;
            double res = ds.FahrenheitToСelsius(x);
            int result = Convert.ToInt32(res);
            int wait = 38;
            Assert.AreEqual(wait, result);
        }
    }
}
