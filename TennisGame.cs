

namespace HomeWorkTennis
{
    public class TennisGame
    {
        private int _firstPlayerScoreTimes;

        public TennisGame()
        {
        }

        public string GetScoreResult()
        {
            if(_firstPlayerScoreTimes == 1)
            {
                return "Fifteen Love";
            }
            return "Love All";
        }

        public void FirstPlayerScoreTimes()
        {
            _firstPlayerScoreTimes++;
        }
    }
}