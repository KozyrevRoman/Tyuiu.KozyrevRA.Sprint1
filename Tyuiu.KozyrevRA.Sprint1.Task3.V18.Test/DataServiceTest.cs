using Tyuiu.KozyrevRA.Sprint1.Task3.V18.Lib;

namespace Tyuiu.KozyrevRA.Sprint1.Task3.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidHowManySquares()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 3;
            double wait = 1.5;
            double z = 2;
            var res = ds.HowManySquares(x, y, z);
            Assert.AreEqual(wait,res); 
        }
    }
}
