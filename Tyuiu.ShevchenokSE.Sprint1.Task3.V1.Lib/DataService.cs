using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.ShevchenokSE.Sprint1.Task3.V1.Lib
{
    public class DataService : ISprint1Task3V1
    {
        public double CylinderVolume(double r, double h)
        {
            double volume = Math.PI * r * r * h;
            return Math.Round(volume, 3);
        }
    }
}