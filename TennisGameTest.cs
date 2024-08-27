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

        [Test]
        public void T04_FortyLove()
        {
            GetFirstPlayerScoreTimes(3);
            ScoreResultShoulBe("Forty Love");
        }

        [Test]
        public void T05_LoveFifteen()
        {
            GetSecondPlayerScoreTimes(1);
            ScoreResultShoulBe("Love Fifteen");
        }

        [Test]
        public void T06_LoveThirty()
        {
            GetSecondPlayerScoreTimes(2);
            ScoreResultShoulBe("Love Thirty");
        }

        [Test]
        public void T07_LoveForty()
        {
            GetSecondPlayerScoreTimes(3);
            ScoreResultShoulBe("Love Forty");
        }

        [Test]
        public void T08_FifteenAll()
        {
            GetFirstPlayerScoreTimes(1);
            GetSecondPlayerScoreTimes(1);
            ScoreResultShoulBe("Fifteen All");
        }

        [Test]
        public void T09_ThirtyAll()
        {
            GetFirstPlayerScoreTimes(2);
            GetSecondPlayerScoreTimes(2);
            ScoreResultShoulBe("Thirty All");
        }

        private void GetSecondPlayerScoreTimes(int times)
        {
            for (int i = 0; i < times; i++)
            {
                _tennisGame.SecondPlayerScoreTimes();
            }
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