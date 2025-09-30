using Tyuiu.KozyrevRA.Sprint1.Task6.V5.Lib;
namespace Tyuiu.KozyrevRA.Sprint1.Task6.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckSymmetricalWords()
        {
            DataService ds = new DataService();
            string strTest = "Хороший шалаш";
            string res = ds.CheckSymmetricalWords(strTest);
            string wait = "шалаш";
            Assert.AreEqual(wait, res);
        }
    }
}
