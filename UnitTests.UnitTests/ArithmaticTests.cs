using NUnit.Framework;
using System;
using Unit_Tests;

namespace UnitTests.UnitTests
{
    [TestFixture]
    class ArithmaticTests
    {
        private Arithmatic _arit;

        [SetUp]
        public void SetUp()
        {
            _arit = new Arithmatic();
        }

        [Test]
        [TestCase(1, 3)]
        [TestCase(2, 2)]
        [TestCase(3, 1)]
        public void AddNumber_WhenCalled_ShouldReturnGoodResult(int num1, int num2)
        {
            var result = _arit.AddNumber(num1, num2);
            Assert.That(result, Is.EqualTo(4));
        }

        [Test]
        [TestCase(-5, -1)]
        [TestCase(-3, 5)]
        [TestCase(-10, 0)]
        public void AddNumber_WhenCalled_ShouldThorwArgumentException(int num1, int num2)
        {
            Assert.That(() => _arit.AddNumber(num1, num2), Throws.Exception.TypeOf<ArgumentException>());
        }

        [Test]
        public void MultNumber_WhenCalled_ShouldReturnGoodResult()
        {
            var result = _arit.MultNumber(2, 3);
            Assert.That(result, Is.EqualTo(6));
        }

        [Test]
        public void MultNumber_WhenCalled_ShouldThorwArgumentException()
        {
            Assert.That(() => _arit.MultNumber(-1, -3), Throws.Exception.TypeOf<ArgumentException>());
        }

        [Test]
        public void NumberToList_WhenCalled_ShouldAddToList()
        {
            Arithmatic _arit = new Arithmatic();

            _arit.NumList.Add(_arit.MultNumber(3, 6));
            _arit.NumList.Add(_arit.MultNumber(2, 1));
            _arit.NumList.Add(_arit.AddNumber(4, 8));

            Assert.That(3, Is.EqualTo(_arit.NumList.Count));
        }
    }
}
