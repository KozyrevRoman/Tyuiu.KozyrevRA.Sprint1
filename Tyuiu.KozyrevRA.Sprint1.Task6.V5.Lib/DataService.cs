using System.Linq;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.KozyrevRA.Sprint1.Task6.V5.Lib
{
    public class DataService : ISprint1Task6V5
    {
        public string CheckSymmetricalWords(string value)
        {
            string[] words = Regex.Split(value.ToLower(), " ");
            string s = "";
            foreach (string word in words)
            {
                string rev = new string(word.Reverse().ToArray());  
                int y = 0;
                bool w = word == rev;
                if (w == true)
                {
                    s +=rev;
                }
                else
                {
                    y+=1;
                }
            }
            return s; 
        }
    }
}
