using System;
using System.IO;

namespace BestGame
{
    class Program
    {
        static void Main(string[] args)
        {
            GenerateData.GetGames();
            GenerateHistoricalDataSet(args);

            static void GenerateHistoricalDataSet(string[] args)
            {
                ILogger logger = new ConsoleLogger();
                HistoricalDataSet dataSet = new HistoricalDataSet(logger);
                try
                {
                    
                    if (args.Length >= 1)
                    {
                        
                        for (int i = 0; i < int.Parse(args[0]); i++)
                        {
                            dataSet.Generate();
                            dataSet.Load();
                        }
                        
                    }
                    else
                    {

                        dataSet.Load();
                    }
                    DataEvaluator dataEvaluator = new DataEvaluator (dataSet, logger);
                }
                catch(FormatException e)
                {
                    logger.Error($"Not appropriate input - {e}");
                }
                catch(FileNotFoundException e)
                {
                    logger.Error($"File not found! - {e}");

                }
                catch(FileLoadException e)
                {
                    logger.Error($"History file empty! Generate some rounds first! - {e}");

                }
                catch(IOException e)
                {
                    logger.Error($"Close the history.csv file! - {e}");

                }

            }
        }
    }
}
