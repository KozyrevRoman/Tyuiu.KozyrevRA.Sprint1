using Tyuiu.KozyrevRA.Sprint1.Task4.V8.Lib;
namespace Tyuiu.KozyrevRA.Sprint1.Task4.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 10;
            double y = 1;
            double wait =2.538;
            var res =ds.Calculate(x,y); 
            Assert.AreEqual(wait,res);
        }
    }
}
