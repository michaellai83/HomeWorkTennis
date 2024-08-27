﻿

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
            if(_firstPlayerScoreTimes > 0)
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