using NUnit.Framework;
using CalculatorApi;

namespace NunitDemo
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void AdditionTest()
        {
            int res;
            res=Operations.AddFn(5, 6);
            Assert.That(res, Is.EqualTo(11));
        }
        [Test]
        public void SubTest()
        {
            int res;
            res = Operations.SubFn(6, 5);
            Assert.That(res, Is.EqualTo(1));
        }
        [Test]
        [TestCase(5,6,11)]
        [TestCase(4,7,11)]
        [TestCase(6,6,13)]
        public void AdditionTest(int x, int y, int expected)
        {
            int res;
            res = Operations.AddFn(x, y);
            Assert.AreEqual(expected, res);
        }
    }
}