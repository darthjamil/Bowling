using NUnit.Framework;
using Bowling.App;

namespace Bowling.UnitTests
{
    public class TestGame
    {
        private Game Game;

        [SetUp]
        public void Setup()
        {
            Game = new Game();
        }

        [Test]
        public void GutterGame()
        {
            RollMany(20, 0);
            Assert.That(Game.GetScore(), Is.EqualTo(0));
        }

        [Test]
        public void AllOnes()
        {
            RollMany(20, 1);
            Assert.That(Game.GetScore(), Is.EqualTo(20));
        }

        [Test]
        public void AllTwos()
        {
            RollMany(20, 2);
            Assert.That(Game.GetScore(), Is.EqualTo(40));
        }

        [Test]
        public void OneSpare()
        {
            RollSpare();
            RollMany(18, 1);
            Assert.That(Game.GetScore(), Is.EqualTo(29));
        }

        [Test]
        public void OneStrike()
        {
            RollStrike();
            RollMany(18, 1);
            Assert.That(Game.GetScore(), Is.EqualTo(30));
        }

        [Test]
        public void OneStrikeInMiddle()
        {
            RollMany(2, 1);
            RollStrike();
            RollMany(16, 1);
            Assert.That(Game.GetScore(), Is.EqualTo(30));
        }

        [Test]
        public void OneSpareInMiddle()
        {
            RollMany(2, 1);
            RollSpare();
            RollMany(16, 1);
            Assert.That(Game.GetScore(), Is.EqualTo(29));
        }

        [Test]
        public void PerfectGame()
        {
            RollMany(12, 10);
            Assert.That(Game.GetScore(), Is.EqualTo(300));
        }

        private void RollStrike()
        {
            Game.Roll(10);
        }

        private void RollSpare()
        {
            Game.Roll(5);
            Game.Roll(5);
        }

        private void RollMany(int rolls, int pins)
        {
            for (int i = 0; i < rolls; i++)
            {
                Game.Roll(pins);
            }
        }
    }
}