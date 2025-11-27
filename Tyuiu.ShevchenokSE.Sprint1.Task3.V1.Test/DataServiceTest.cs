using Tyuiu.ShevchenokSE.Sprint1.Task3.V1.Lib;
namespace Tyuiu.ShevchenokSE.Sprint1.Task3.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExspression()
        {
            DataService ds = new DataService();
            double r = 5;
            double h = 11;
            double wait = 863.5;
            var res = ds.CylinderVolume(r, h);
            Assert.AreEqual(wait, res);
        }
    }
}