


namespace HomeWorkTennis
{
    public class TennisGame
    {
        private int _firstPlayerScoreTimes;
        private Dictionary<int, string> _scoreLookup = new Dictionary<int, string>
        {
            {0,"Love" },
            {1,"Fifteen" },
            {2,"Thirty" },
            {3,"Forty" }
        };
        private int _secondPlayerScoreTimes;
        private string _firstPlayerName;
        private string _secondPlayerName;

        public TennisGame()
        {
        }

        public TennisGame(string firstPlayerName, string secondPlayerName)
        {
            _firstPlayerName = firstPlayerName;
            _secondPlayerName = secondPlayerName;
        }

        public string GetScoreResult()
        {
            if (IsDifferentScore())
            {
                if (IsReadyGamePoint())
                {
                    return IsAdv() ?
                        $"{GetLeadingPlayerName()} Adv." :
                        $"{GetLeadingPlayerName()} Win.";
                }
                return GetLookupResult();
            }

            return IsGameDeuce() ? GetDeuce() : GameSameScore();
        }

        private string GetLookupResult()
        {
            return $"{_scoreLookup[_firstPlayerScoreTimes]} {_scoreLookup[_secondPlayerScoreTimes]}";
        }

        private static string GetDeuce()
        {
            return "Deuce";
        }

        private bool IsAdv()
        {
            return Math.Abs(_firstPlayerScoreTimes - _secondPlayerScoreTimes) == 1;
        }

        private string GetLeadingPlayerName()
        {
            return _firstPlayerScoreTimes > _secondPlayerScoreTimes ? _firstPlayerName : _secondPlayerName;
        }

        private bool IsReadyGamePoint()
        {
            return _firstPlayerScoreTimes > 3 || _secondPlayerScoreTimes > 3;
        }

        private bool IsDifferentScore()
        {
            return _firstPlayerScoreTimes != _secondPlayerScoreTimes;
        }

        private string GameSameScore()
        {
            return $"{_scoreLookup[_firstPlayerScoreTimes]} All";
        }

        private bool IsGameDeuce()
        {
            return _firstPlayerScoreTimes == _secondPlayerScoreTimes
                && _firstPlayerScoreTimes >= 3;
        }

        public void FirstPlayerScoreTimes()
        {
            _firstPlayerScoreTimes++;
        }

        internal void SecondPlayerScoreTimes()
        {
            _secondPlayerScoreTimes++;
        }
    }
}