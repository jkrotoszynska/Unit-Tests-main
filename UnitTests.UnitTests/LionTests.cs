using NUnit.Framework;
using Unit_Tests;

namespace UnitTests.UnitTests
{
    [TestFixture]
    class LionTest
    {
        private Lion _lion;
        [SetUp]
        public void SetUp()
        {
            _lion = new Lion();
        }

        [Test]
        public void animalNoise_WhenCalled_ShouldReturnNoise()
        {
            var result = _lion.animalNoise();
            Assert.That(result, Is.EqualTo("Roar"));
        }
        [Test]
        public void Hibernate_WhenCalled_ShouldReturnDoesHibernate()
        {
            var result = _lion.Hibernate();
            Assert.IsFalse(result);
        }
        [Test]
        public void Hunt_WhenCalled_ShouldReturnHunts()
        {
            var result = _lion.Hunt();
            Assert.That(result, Is.EqualTo("The lion hunts"));
        }
    }
}
