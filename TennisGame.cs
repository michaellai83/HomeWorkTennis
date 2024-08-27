

namespace HomeWorkTennis
{
    public class TennisGame
    {
        private int _firstPlayerScoreTimes;
        private Dictionary<int, string> _scoreLookup = new Dictionary<int, string>
        {
            {1,"Fifteen" },
            {2,"Thirty" },
            {3,"Forty" }
        };

        public TennisGame()
        {
        }

        public string GetScoreResult()
        {
            if(_firstPlayerScoreTimes == 1 || _firstPlayerScoreTimes == 2 || _firstPlayerScoreTimes == 3)
            {
                return $"{_scoreLookup[_firstPlayerScoreTimes]} Love";
            }

            return "Love All";
        }

        public void FirstPlayerScoreTimes()
        {
            _firstPlayerScoreTimes++;
        }
    }
}