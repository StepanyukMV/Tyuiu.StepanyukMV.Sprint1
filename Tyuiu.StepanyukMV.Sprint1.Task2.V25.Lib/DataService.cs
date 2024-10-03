using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;
using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.StepanyukMV.Sprint1.Task2.V25.Lib
{
    public class DataService// : //ISprint1Task2V25
    {
        public double ConvertRadsToDegrees(double value)
        {
            
            return Math.Round (value * 180 / Double.Pi, 3);


        }
    }
}
