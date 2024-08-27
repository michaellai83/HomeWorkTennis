using FluentAssertions;

namespace HomeWorkTennis
{
    public class TennisGameTest
    {
        private TennisGame _tennisGame;

        [SetUp]
        public void Setup()
        {
            _tennisGame = new TennisGame();
        }

        [Test]
        public void T01_LoveAll()
        {
            var actual = _tennisGame.GetScoreResult();
            actual.Should().Be("Love All");
        }

        [Test]
        public void T02_FifteenLove()
        {
            _tennisGame.FirstPlayerScoreTimes();
            var actual = _tennisGame.GetScoreResult();
            actual.Should().Be("Fifteen Love");
        }
    }
}