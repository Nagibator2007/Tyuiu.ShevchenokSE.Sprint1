using Tyuiu.ShevchenokSE.Sprint1.Task5.V1.Lib;
namespace Tyuiu.ShevchenokSE.Sprint1.Task5.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            double x1 = 15;
            double y1 = 5;
            double x2 = 6;
            double y2 = 10;
            DataService ds = new DataService();
            double res = ds.DistanceBetweenDots(x1, y1, x2, y2);
            int result = Convert.ToInt32(res);
            int wait = 10;
            Assert.AreEqual(wait, result);
        }
    }
}