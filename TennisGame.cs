


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

        public TennisGame()
        {
        }

        public TennisGame(string firstPlayerName)
        {
            _firstPlayerName = firstPlayerName;
        }

        public string GetScoreResult()
        {
            if (_firstPlayerScoreTimes != _secondPlayerScoreTimes)
            {
                if(_firstPlayerScoreTimes >= 3)
                {
                    if(_firstPlayerScoreTimes - _secondPlayerScoreTimes == 1)
                    {
                        return $"{_firstPlayerName} Adv.";
                    }
                    
                }
                return $"{_scoreLookup[_firstPlayerScoreTimes]} {_scoreLookup[_secondPlayerScoreTimes]}";
            }

            if(_firstPlayerScoreTimes >= 3)
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