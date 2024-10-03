using Tyuiu.StepanyukMV.Sprint1.Task2.V25.Lib;
namespace Tyuiu.StepanyukMV.Sprint1.Task2.V25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int x;
            Console.WriteLine("Введите значение X");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("jopa " + ds.ConvertRadsToDegrees(x)/100);

            Console.ReadLine();
        }
    }
}
