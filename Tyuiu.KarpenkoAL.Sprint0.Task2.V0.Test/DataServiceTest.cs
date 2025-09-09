using Tyuiu.KarpenkoAL.Sprint0.Task2.V0.Lib;
namespace Tyuiu.KarpenkoAL.Sprint0.Task2.V0.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            
            var name = "Артём";
            var res = DataService.GetMessage(name);

 
            Assert.AreEqual("Привет..., Артём", res);
        }
    }
}
