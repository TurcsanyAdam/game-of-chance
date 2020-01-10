using System;
using System.IO;

namespace BestGame
{
    class Program
    {
        static void Main(string[] args)
        {
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
                    logger.Error($"Not appropriate type - {e}");
                }
                catch(FileNotFoundException e)
                {
                    logger.Error($"File not found! - {e}");

                }
                catch(DivideByZeroException e)
                {
                    logger.Error("History file empty! Generate some rounds first!");

                }
                catch(IOException e)
                {
                    logger.Error($"Close the history.csv file! - {e}");

                }

            }
        }
    }
}
