using Tyuiu.StepanyukMV.Sprint1.Task7.V22.Lib;
namespace Tyuiu.StepanyukMV.Sprint1.Task7.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidInvalid()
        {
            DataService ds = new DataService();
            double x = 5;
            double y = 7;

            double res = ds.Calculate(x, y);
            Assert.AreEqual(0.23, res);
        }
    }
}
