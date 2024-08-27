


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
            if (_firstPlayerScoreTimes != _secondPlayerScoreTimes)
            {
                if (_firstPlayerScoreTimes > 3 || _secondPlayerScoreTimes > 3)
                {
                    if (Math.Abs(_firstPlayerScoreTimes - _secondPlayerScoreTimes) == 1)
                    {
                        var leadingPlayerName = _firstPlayerName;
                        if (_secondPlayerScoreTimes > _firstPlayerScoreTimes)
                        {
                            leadingPlayerName = _secondPlayerName;
                        }
                        return $"{leadingPlayerName} Adv.";
                    }
                    else
                    {
                        var leadingPlayerName = _firstPlayerName;
                        if (_secondPlayerScoreTimes > _firstPlayerScoreTimes)
                        {
                            leadingPlayerName = _secondPlayerName;
                        }
                        return $"{leadingPlayerName} Win.";
                    }

                }
                return $"{_scoreLookup[_firstPlayerScoreTimes]} {_scoreLookup[_secondPlayerScoreTimes]}";
            }

            if (_firstPlayerScoreTimes >= 3)
            {
                return "Deuce";
            }

            return $"{_scoreLookup[_firstPlayerScoreTimes]} All";
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