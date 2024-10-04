using Tyuiu.StepanyukMV.Sprint1.Task4.V1.Lib;
namespace Tyuiu.StepanyukMV.Sprint1.Task4.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2;
            double result = 0.125;
            var res = ds.Calculate(x);
            Assert.AreEqual(result, res);
        }
    }
}