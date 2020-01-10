using System;
using System.Collections.Generic;
using System.Text;

namespace BestGame
{
    class HistoricalDataPoint
    {
        public List<Game> GameList = GenerateData.GetGames();
        public string Winner { get; private set; }
        public HistoricalDataPoint()
        {
            Winner = GenerateData.GenerateWinner();
        }

        public HistoricalDataPoint(string Winner)
        {
            this.Winner = Winner;
        }
    }
}
