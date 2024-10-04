using Tyuiu.StepanyukMV.Sprint1.Task3.V2.Lib;
namespace Tyuiu.StepanyukMV.Sprint1.Task3.V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Степанюк М.В. | РППб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Операторы составного присваивания                                 *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #2                                                              *");
            Console.WriteLine("* Выполнил: Степанюк М.В. | РППб-24-1                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
            Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.             *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            double priceNotebook;
            double pricePencil;
            int amountNotebook;
            int amountPencil;

           
            Console.WriteLine("Введите значения стоимости тетрадей:");
            priceNotebook = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значения количества тетрадей:");
            amountNotebook = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Введите значения стоимости карандашей:");
            pricePencil = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значения количества карандашей:");
            amountPencil = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.PurchaseAmount(priceNotebook, amountNotebook, pricePencil, amountPencil));
            
            Console.ReadLine();

        }
    }
}
