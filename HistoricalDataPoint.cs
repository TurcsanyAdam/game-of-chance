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
            GenerateData generateData = new GenerateData();
            Winner = generateData.GenerateWinner();

        }

        public HistoricalDataPoint(string Winner)
        {
            this.Winner = Winner;
        }
    }
}
