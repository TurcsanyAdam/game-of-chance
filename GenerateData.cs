using System;
using System.Collections.Generic;
using System.Text;

namespace BestGame
{
    class GenerateData
    {
        public static List<Game> GetGames()
        {
            List<Game> gamesList = new List<Game>();

            Game residentEvil2 = new Game("Resident Evil", 2019, "Survival horror", "Capcom", 91);
            Game sekiro = new Game("Sekiro: Shadows die twice", 2019, "Action adventure", "Activision", 90);
            Game discoElysium = new Game("Disco Elysium", 2019, "RPG", "ZA/UM", 91);
            Game devilMayCry5 = new Game("Devil May Cry 5", 2019, "Hack and slash", "Capcom", 89);
            Game starWarsJedi = new Game("Star Wars Jedi: Fallen Order", 2019, "Action adventure", "EA", 81);
            Game remnant = new Game("Remnant: From the Ashes", 2019, "TPS soulslike", "Perfect World Entertainment", 81);
            Game borderland3 = new Game("Borderlands 3", 2019, "Looter shooter", "2K", 82);
            Game deathStranding = new Game("Death Stranding", 2019, "Strand game", "Kojima productions", 82);
            Game control = new Game("Control", 2019, "TPS", "505 Games", 82);
            Game crashRacer = new Game("Crash Team Racing: Nitro-Fueled", 2019, "Arcade racing", "Activision", 83);
            Game apexLegends = new Game("Apex Legends", 2019, "Battle Royal", "EA games", 89);
            Game mortalKombat11 = new Game("Mortal Kombat", 2019, "Fighter", "Warner Bros.", 82);
            Game outerWorlds = new Game("The Outer Worlds", 2019, "RPG", "Obsidian", 86);
            Game plagueTale = new Game("A Plague Tale: Innocence", 2019, "Action adventure", "Focus Home Interactive", 81);
            Game metroExodus = new Game("Metro Exodus", 2019, "FPS", "Deep silver", 82);
            Game wowClassic = new Game("World of Warcraft Classic", 2019, "MMORPG", "Blizzard", 81);

            gamesList.Add(residentEvil2);
            gamesList.Add(sekiro);
            gamesList.Add(discoElysium);
            gamesList.Add(devilMayCry5);
            gamesList.Add(starWarsJedi);
            gamesList.Add(remnant);
            gamesList.Add(borderland3);
            gamesList.Add(deathStranding);
            gamesList.Add(control);
            gamesList.Add(crashRacer);
            gamesList.Add(apexLegends);
            gamesList.Add(mortalKombat11);
            gamesList.Add(outerWorlds);
            gamesList.Add(plagueTale);
            gamesList.Add(metroExodus);
            gamesList.Add(wowClassic);

            return gamesList;
        } 
        
        public static string GenerateWinner()
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
