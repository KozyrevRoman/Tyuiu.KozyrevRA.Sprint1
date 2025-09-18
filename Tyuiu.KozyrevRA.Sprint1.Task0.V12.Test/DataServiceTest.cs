using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KozyrevRA.Sprint1.Task0.V12.Lib;
namespace Tyuiu.KozyrevRA.Sprint1.Task0.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.Calculate(); 
            Assert.AreEqual(6, res); 
        }
    }
}
