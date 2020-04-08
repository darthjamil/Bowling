using NUnit.Framework;
using Bowling.App;

namespace Bowling.UnitTests
{
    public class TestGame
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CanCreateGame()
        {
            new Game();
        }
    }
}