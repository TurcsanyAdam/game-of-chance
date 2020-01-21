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
            EvaluateData();
        }
        public void EvaluateData()
        {
            float count = 0;
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
            float chanceOfWinning = count/(dataSet.Size-1)*100;

            if(chanceOfWinning <= 0)
            {
                throw new FileLoadException("Error");
            }

            logger.Winner($"You should bet on {finalWinner} as the GOTY of 2019 as it won {Math.Round(chanceOfWinning, 2)} % of times!");

        }
    }
}
