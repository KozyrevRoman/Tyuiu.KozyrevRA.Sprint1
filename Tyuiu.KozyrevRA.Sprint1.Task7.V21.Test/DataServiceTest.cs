using Tyuiu.KozyrevRA.Sprint1.Task7.V21.Lib;
namespace Tyuiu.KozyrevRA.Sprint1.Task7.V21.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 1;
            double wait = -2.314;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
