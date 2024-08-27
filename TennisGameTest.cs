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
            GetScoreResult("Love All");
        }

        [Test]
        public void T02_FifteenLove()
        {
            _tennisGame.FirstPlayerScoreTimes();
            GetScoreResult("Fifteen Love");
        }

        private void GetScoreResult(string expect)
        {
            var actual = _tennisGame.GetScoreResult();
            actual.Should().Be(expect);
        }
    }
}