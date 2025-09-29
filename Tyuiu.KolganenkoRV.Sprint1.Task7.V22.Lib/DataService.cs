using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KolganenkoRV.Sprint1.Task7.V22.Lib
{
    public class DataService : ISprint1Task7V22
    {
        public double Calculate(double x, double y)
        {
            double part1 = Math.Pow(1 - Math.Tan(x), 1 / Math.Tan(x));
            double part2 = Math.Cos(x - y);
            return Math.Round(part1 + part2, 3);
        }
    }
}
