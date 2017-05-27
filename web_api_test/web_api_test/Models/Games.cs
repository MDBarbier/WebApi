using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace web_api_test.Models
{
    public class Games
    {
        public string Name { get; set; }
        public int Rating { get; set; }
        public Genre GameGenre { get; set; }
        public int ID { get; set; }

        public Games()
        {

        }

        public Games(int id, string name, int rating, Genre genre)
        {
            this.ID = id;
            this.Name = name;
            this.Rating = rating;
            this.GameGenre = genre;
        }
    }

    public enum Genre
    {
        RPG, RTS, FourX, GrandStrategy, FPS, Roguelike
    }
}