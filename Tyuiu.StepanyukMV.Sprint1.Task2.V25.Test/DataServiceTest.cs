using Tyuiu.StepanyukMV.Sprint1.Task2.V25.Lib;
namespace Tyuiu.StepanyukMV.Sprint1.Task2.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2;
            var res = ds.ConvertRadsToDegrees(x);
            Assert.AreEqual(%3, res);
        }
    }
}