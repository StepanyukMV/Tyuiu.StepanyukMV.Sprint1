using Tyuiu.StepanyukMV.Sprint1.Task3.V2.Lib;
namespace Tyuiu.StepanyukMV.Sprint1.Task3.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double priceNotebook = 2;
            int amountNotebook = 3;
            double pricePencil = 4;
            int amountPencil = 5;
            double wait = 26;

            var res = ds.PurchaseAmount(priceNotebook, amountNotebook, pricePencil, amountPencil);
            Assert.AreEqual(wait, res);
        }
    }
}