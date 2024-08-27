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
            ScoreResultShoulBe("Love All");
        }

        [Test]
        public void T02_FifteenLove()
        {
            GetFirstPlayerScoreTimes(1);
            ScoreResultShoulBe("Fifteen Love");
        }

        [Test]
        public void T03_ThirtyLove()
        {
            GetFirstPlayerScoreTimes(2);
            ScoreResultShoulBe("Thirty Love");
        }

        private void GetFirstPlayerScoreTimes(int times)
        {
            for(int i = 0; i < times; i++)
            {
                _tennisGame.FirstPlayerScoreTimes();
            }          
        }

        private void ScoreResultShoulBe(string expect)
        {
            var actual = _tennisGame.GetScoreResult();
            actual.Should().Be(expect);
        }
    }
}