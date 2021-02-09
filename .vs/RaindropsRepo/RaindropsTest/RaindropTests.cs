using NUnit.Framework;
using RaindropClassLibrary;

namespace Tests
{
    public class RaindropTests
    {

        [TestCase(3)]
        [TestCase(6)]
        [TestCase(9)]
        public void GivenAFactorOfThree_WhenIEnterThatNumberIntoRaindropMethod_PlingWillBeReturned(int number)
        {
            Assert.That(Raindrop.Raindrops(number), Is.EqualTo("Pling"));
        }

        [TestCase(5)]
        [TestCase(10)]
        [TestCase(20)]
        public void GivenAFactorOfFive_WhenIEnterThatNumberIntoRaindropMethod_PlangWillBeReturned(int number)
        {
            Assert.That(Raindrop.Raindrops(number), Is.EqualTo("Plang"));
        }

        [TestCase(7)]
        [TestCase(14)]
        [TestCase(28)]
        public void GivenAFactorOfSeven_WhenIEnterThatNumberIntoRaindropMethod_PlongWillBeReturned(int number)
        {
            Assert.That(Raindrop.Raindrops(number), Is.EqualTo("Plong"));
        }

        [TestCase(30)]
        public void GivenAFactorOfThreeAndFive_WhenIEnterThatNumberIntoRaindropMethod_PlingPlangWillBeReturned(int number)
        {
            Assert.That(Raindrop.Raindrops(number), Is.EqualTo("PlingPlang"));
        }

        [TestCase(21)]
        public void GivenAFactorOfThreeAndSeven_WhenIEnterThatNumberIntoRaindropMethod_PlingPlongWillBeReturned(int number)
        {
            Assert.That(Raindrop.Raindrops(number), Is.EqualTo("PlingPlong"));
        }

        [TestCase(35)]
        public void GivenAFactorOfFiveAndSeven_WhenIEnterThatNumberIntoRaindropMethod_PlangPlongWillBeReturned(int number)
        {
            Assert.That(Raindrop.Raindrops(number), Is.EqualTo("PlangPlong"));
        }

        [TestCase(105)]
        [TestCase(0)]
        public void GivenAFactorOfThreeFiveAndSeven_WhenIEnterThatNumberIntoRaindropMethod_PlingPlangPlongWillBeReturned(int number)
        {
            Assert.That(Raindrop.Raindrops(number), Is.EqualTo("PlingPlangPlong"));
        }

        [TestCase(-105, "PlingPlangPlong")]
        [TestCase(-35, "PlangPlong")]
        [TestCase(-3, "Pling")]
        [TestCase(-4, "-4")]
        [TestCase(-30, "PlingPlang")]
        public void GivenIHaveNegativeNumbers_WhenIEnterThemNumbersIntoRaindropMethod_TheCorrectStringWillBeReturned(int number, string solution)
        {
            Assert.That(Raindrop.Raindrops(number), Is.EqualTo(solution));
        }

        [TestCase(4)]
        [TestCase(103)]
        [TestCase(13)]
        public void GivenIHaveANumberThatIsntAFactorOfThreeFiveOrSeven_WhenIEnterThatNumberIntoRaindropMethod_TheNumberWillBeReturned(int number)
        {
            Assert.That(Raindrop.Raindrops(number), Is.EqualTo(number.ToString()));
        }


    }
}