using System;
using System.Collections.Generic;
using System.Text;

namespace BestGame
{
    class Game
    {
        public string title { get; private set; }
        public int releaseYear { get; private set; }
        public string genre { get; private set; }
        public string publisher { get; private set; }
        public int metacriticScore { get; private set; }

        public Game(string aTitle,int aReleaseYear,string aGenre,string aPublisher,int aMetacriticscore)
        {
            title = aTitle;
            releaseYear = aReleaseYear;
            genre = aGenre;
            publisher = aPublisher;
            metacriticScore = aMetacriticscore;
        }

        public override string ToString()
        {
            
            return title;
        }
    }
}
