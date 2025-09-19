using Tyuiu.KozyrevRA.Sprint1.Task6.V5.Lib;
namespace Tyuiu.KozyrevRA.Sprint1.Task6.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string strTest = "казак шалаш гкдд";
            string res = ds.CheckSymmetricalWords(strTest);
            string wait = "казак шалаш гкдд";
            Assert.AreEqual(wait, res);
        }
    }
}
