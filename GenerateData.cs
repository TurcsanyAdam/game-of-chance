using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace BestGame
{
    class GenerateData
    {
        public static List<Game> GetGames()
        {
            List<Game> gamesList = new List<Game>();

            using (var reader = new StreamReader(@"..\\..\\..\\Games.csv"))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(",");
                    Game game = new Game(values[0], int.Parse(values[1]), values[2], values[3], int.Parse(values[4]));
                    gamesList.Add(game);

                }

            }
            return gamesList;
        } 
        
        public string GenerateWinner()
        {
            List<Game> nominees = GenerateData.GetGames();

            int finalVote = 0;
            ILogger logger = new ConsoleLogger();

            while (nominees.Count != 1)
            {
                for (int i = 0; i < nominees.Count; i++)
                {
                    Random rand = new Random();

                    int a = rand.Next(1, 100000);
                    int b = rand.Next(1, 100000);

                    if (a >= b)
                    {
                        logger.Info($"In a battle between {nominees[i]} and {nominees[i + 1]} the winner is :{nominees[i]} with {a} votes!");
                        nominees.RemoveAt(i + 1);
                    }
                    else
                    {
                        logger.Info($"In a battle between {nominees[i]} and {nominees[i + 1]} the winner is :{nominees[i + 1]} with {b} votes!");
                        nominees.RemoveAt(i);
                    }

                    if (nominees.Count == 1)
                    {
                        if (a > b)
                        {
                            finalVote = a;
                        }
                        else
                        {
                            finalVote = b;
                        }
                    }
                }
            }
            logger.Winner($"The GOTY is {nominees[0]} with {finalVote} votes in the final!");
            string winner = nominees[0].title;
            return winner;
        }

        
    }
}
