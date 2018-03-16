using NUnit.Framework;

namespace TestingAssignment.Tests
{
    // sut --> Software Under Testing
    [TestFixture]
    public class TestClass
    {
        [Test]
        public void TTF()
        {
            var sut = new Program();

            var result = sut.CalcPremium(20, "female");

            Assert.That(result, Is.EqualTo(5));
        }

        [Test]
        public void TFTT()
        {
            var sut = new Program();

            var result = sut.CalcPremium(51, "female");

            Assert.That(result, Is.EqualTo(1.75));
        }

        [Test]
        public void TFFF()
        {
            var sut = new Program();

            var result = sut.CalcPremium(0, "female");

            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void FTTF()
        {
            var sut = new Program();

            var result = sut.CalcPremium(20, "male");

            Assert.That(result, Is.EqualTo(6));
        }

        [Test]
        public void FTFTT()
        {
            var sut = new Program();

            var result = sut.CalcPremium(51, "male");

            Assert.That(result, Is.EqualTo(2.5));
        }

        [Test]
        public void FTFFF()
        {
            var sut = new Program();

            var result = sut.CalcPremium(0, "male");

            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void FFF()
        {
            var sut = new Program();

            var result = sut.CalcPremium(20, "other");

            Assert.That(result, Is.EqualTo(0));
        }
    }
}
