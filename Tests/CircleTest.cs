using AreaOfFigures;
using AreaOfFigures.Figures;

namespace Tests
{
    [TestClass]
    public class CircleTest
    {
        [TestMethod]
        public void AreaTestPositive()
        {
            AreaResult result = Area.GetFigureArea(new Circle(10));
            Assert.IsNotNull(result, "Результат метода не должен быть Null");
            Assert.IsTrue(result.Success, "Ожидался положительный результат");
            Assert.AreEqual(result.AreaValue, 314.15926535897933, "Значение не совпало");
        }

        [TestMethod]
        public void AreaTestNegative()
        {
            AreaResult result = Area.GetFigureArea(new Circle(0));
            Assert.IsNotNull(result, "Результат метода не должен быть Null");
            Assert.IsFalse(result.Success, "Ожидался отрицательный результат");
        }
    }
}