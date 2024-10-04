using Tyuiu.StepanyukMV.Sprint1.Task6.V1.Lib;
namespace Tyuiu.StepanyukMV.Sprint1.Task6.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Valid()
        {
            DataService ds = new DataService();
            string x = "G";
            string res = ds.SymbolCode(x);
            string wait = "71";
            Assert.AreEqual(wait, res);
        }
    }
}