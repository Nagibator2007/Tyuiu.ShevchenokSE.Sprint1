using Tyuiu.ShevchenokSE.Sprint1.Task4.V30.Lib;
namespace Tyuiu.ShevchenokSE.Sprint1.Task4.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void VolidEspression()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 3;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(76, 112, res);
        }
    }
}