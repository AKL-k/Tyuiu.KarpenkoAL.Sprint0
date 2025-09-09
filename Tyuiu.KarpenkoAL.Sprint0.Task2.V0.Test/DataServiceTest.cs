using Tyuiu.KarpenkoAL.Sprint0.Task2.V0.Lib;
namespace Tyuiu.KarpenkoAL.Sprint0.Task2.V0.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            // Область создания методов тестирования, методов из библиотеки
            var name = "Артём";
            var res = DataService.GetMessage(name);

            // Вызываем класс Assert и метод AreEqual
            Assert.AreEqual("Привет..., Артём", res);
        }
    }
}
