namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodArea()
        {
            Rectangle r = new(10, 10);
            Assert.AreEqual(r.Area, 100);
        }
        [TestMethod]
        public void TestMethodPerimeter()
        {
            Rectangle r = new(10, 10);
            Assert.AreEqual(r.Perimeter, 40);
        }
        [TestMethod]
        public void TestMethodPerimeter2()
        {
            double side1 = 10;
            double side2 = 15;
            Rectangle rec1 = new Rectangle(side1, side2);
            Assert.AreEqual(rec1.Perimeter, 50);
        }
        [TestMethod]
        public void TestMethodPerimeter3()
        {
            Point point1 = new Point(0, 0);
            Point point2 = new Point(4, 0);
            Point point3 = new Point(4, 3);
            Figure f1 = new Figure(point1, point2, point3);
            Assert.AreEqual(f1.PerimeterCalc(), 12);
        }
    }
}