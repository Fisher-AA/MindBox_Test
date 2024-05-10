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
            Assert.IsNotNull(result, "��������� ������ �� ������ ���� Null");
            Assert.IsTrue(result.Success, "�������� ������������� ���������");
            Assert.AreEqual(result.AreaValue, 314.15926535897933, "�������� �� �������");
        }

        [TestMethod]
        public void AreaTestNegative()
        {
            AreaResult result = Area.GetFigureArea(new Circle(0));
            Assert.IsNotNull(result, "��������� ������ �� ������ ���� Null");
            Assert.IsFalse(result.Success, "�������� ������������� ���������");
        }
    }
}