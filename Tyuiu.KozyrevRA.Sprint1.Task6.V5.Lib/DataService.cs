using System.Linq;
using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.KozyrevRA.Sprint1.Task6.V5.Lib
{
    public class DataService : ISprint1Task6V5
    {
        public string CheckSymmetricalWords(string value)
        {
            string rev = new string(value.Reverse().ToArray());
            bool w = value == rev;
            if (w == true)
            {
                return rev;
            }
            else
            {
                return "";
            }
                
        }
    }
}
