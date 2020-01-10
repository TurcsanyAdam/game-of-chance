using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace BestGame
{
    class HistoricalDataSet
    {
        public int Size { get; private set; }
        ILogger logger = new ConsoleLogger();
        private List<HistoricalDataPoint> dataPoints = new List<HistoricalDataPoint>();
        public IReadOnlyList<HistoricalDataPoint> DataPoints { get { return dataPoints; } }
        public HistoricalDataSet(ILogger logger)
        {

        }

        public void Generate()
        {
            HistoricalDataPoint winner = new HistoricalDataPoint();
            dataPoints.Add(winner);
            Size++;

            File.AppendAllText(@"..\\..\\..\\history.csv", winner.Winner+"\n");
        }

        public void Load()
        {
            using (var reader = new StreamReader(@"..\\..\\..\\history.csv"))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    HistoricalDataPoint dataPoint = new HistoricalDataPoint(line);
                    Size++;
                    dataPoints.Add(dataPoint);

                }

            }
            
        }
    }
}
