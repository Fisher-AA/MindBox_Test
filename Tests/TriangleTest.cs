
using AreaOfFigures;
using AreaOfFigures.Figures;

namespace Tests
{
    [TestClass]
    public class TriangleTest
    {
        [TestMethod]
        public void AreaTestPositive()
        {
            AreaResult result = Area.GetFigureArea(new Triangle(3,5,7));
            Assert.IsNotNull(result, "Результат метода не должен быть Null");
            Assert.IsTrue(result.Success, "Ожидался положительный результат");
            Assert.AreEqual(result.AreaValue, 6.49519052838329, "Значение не совпало");
        }

        [TestMethod]
        public void AreaTestNegativeFirst()
        {
            AreaResult result = Area.GetFigureArea(new Triangle(0, 5, 8));
            Assert.IsNotNull(result, "Результат метода не должен быть Null");
            Assert.IsFalse(result.Success, "Ожидался отрицательный результат");
        }

        [TestMethod]
        public void AreaTestNegativeSecond()
        {
            AreaResult result = Area.GetFigureArea(new Triangle(4, -1, 8));
            Assert.IsNotNull(result, "Результат метода не должен быть Null");
            Assert.IsFalse(result.Success, "Ожидался отрицательный результат");
        }
        [TestMethod]
        public void AreaTestNegativeThird()
        {
            AreaResult result = Area.GetFigureArea(new Triangle(9, 5, 0));
            Assert.IsNotNull(result, "Результат метода не должен быть Null");
            Assert.IsFalse(result.Success, "Ожидался отрицательный результат");
        }

        [TestMethod]
        public void AreaTestNegativeSize()
        {
            AreaResult result = Area.GetFigureArea(new Triangle(3, 5, 10));
            Assert.IsNotNull(result, "Результат метода не должен быть Null");
            Assert.IsFalse(result.Success, "Ожидался отрицательный результат");
        }
    }
}
