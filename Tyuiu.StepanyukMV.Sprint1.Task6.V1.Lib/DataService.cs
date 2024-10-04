using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.StepanyukMV.Sprint1.Task6.V1.Lib
{
    public class DataService : ISprint1Task6V1
    {
        public string SymbolCode(string value)
        {
            char x = Convert.ToChar(value);
            string res = Convert.ToString((int)x);
            return res;
        }
    }
}
