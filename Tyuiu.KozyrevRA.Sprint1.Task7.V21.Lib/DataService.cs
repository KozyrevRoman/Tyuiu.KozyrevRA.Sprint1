using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.KozyrevRA.Sprint1.Task7.V21.Lib
{
    public class DataService : ISprint1Task7V21
    {
        public double Calculate(double x, double y)
        {
            double z = ((Math.Tan(x * y) * ((Math.Sin(x * x) + Math.Cos(y)))) / (Math.Cos(x) - Math.Sin(y)))+((Math.Pow(x,y)/(Math.Cos(x)-(x/3))));
            return Math.Round(z,3); 
        }
    }
}
        