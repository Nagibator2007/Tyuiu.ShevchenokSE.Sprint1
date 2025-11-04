using Tyuiu.ShevchenokSE.Sprint1.Task2.V21.Lib;
namespace Tyuiu.ShevchenokSE.Sprint1.Task2.V21.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 2;
            int y = 3;
            var res = ds.CalculateRectangleSquare(x, y);
            Assert.AreEqual(6, res);
        }
    }
}
