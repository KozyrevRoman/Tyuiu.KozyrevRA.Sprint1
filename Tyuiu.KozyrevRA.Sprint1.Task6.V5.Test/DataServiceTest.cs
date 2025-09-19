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
            string strTest = "казак";
            string res = ds.CheckSymmetricalWords( strTest );
            string wait = "Казак";
            Assert.AreEqual(wait, res);
        }
    }
}
