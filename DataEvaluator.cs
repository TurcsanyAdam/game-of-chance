using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;

namespace BestGame
{
    class DataEvaluator
    {
        public HistoricalDataSet dataSet;
        ILogger logger;
        public DataEvaluator(HistoricalDataSet dataSet, ILogger logger)
        {
            this.dataSet = dataSet;
            this.logger = logger;
            EvaluateData(dataSet);
        }
        public void EvaluateData(HistoricalDataSet dataSet)
        {
            int count = 0;
            string finalWinner = "";

            foreach(HistoricalDataPoint game in dataSet.DataPoints)
            {

                int gameCount = dataSet.DataPoints.Count(s => s.Winner == game.Winner);
                if(gameCount >= count)
                {
                    count = gameCount;
                    finalWinner = game.Winner;
                }
            }
            double chanceOfWinning = dataSet.Size / count;

            logger.Winner($"You should bet on {finalWinner} as the GOTY of 2019 as it won {chanceOfWinning} % of times!");

        }
    }
}
