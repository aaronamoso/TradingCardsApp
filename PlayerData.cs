using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradingCardsApp
{
    public static class PlayerData
    {
        public static List<Player> Players { get; set; } = new List<Player>
    {
        // Team Lakers
    new Player { Name = "LeBron James", Team = "Lakers", PhotoPath = "images/lebron.png", Stat1 = 27, Stat2 = 7, Stat3 = 7, Stat4 = 1 },
    new Player { Name = "Anthony Davis", Team = "Lakers", PhotoPath = "images/ad.jpg", Stat1 = 25, Stat2 = 3, Stat3 = 12, Stat4 = 2 },
    new Player { Name = "Austin Reaves", Team = "Lakers", PhotoPath = "images/reaves.jpg", Stat1 = 17, Stat2 = 5, Stat3 = 4, Stat4 = 1 },

    // Team Warriors
    new Player { Name = "Stephen Curry", Team = "Warriors", PhotoPath = "images/curry.png", Stat1 = 30, Stat2 = 6, Stat3 = 5, Stat4 = 2 },
    new Player { Name = "Klay Thompson", Team = "Warriors", PhotoPath = "images/klay.png", Stat1 = 21, Stat2 = 2, Stat3 = 4, Stat4 = 1 },
    new Player { Name = "Draymond Green", Team = "Warriors", PhotoPath = "images/draymond.jpg", Stat1 = 8, Stat2 = 7, Stat3 = 7, Stat4 = 1 },

    // Team Bucks
    new Player { Name = "Giannis Antetokounmpo", Team = "Bucks", PhotoPath = "images/giannis.png", Stat1 = 31, Stat2 = 5, Stat3 = 12, Stat4 = 2 },
    new Player { Name = "Khris Middleton", Team = "Bucks", PhotoPath = "images/middleton.png", Stat1 = 19, Stat2 = 4, Stat3 = 5, Stat4 = 1 },
    new Player { Name = "Brook Lopez", Team = "Bucks", PhotoPath = "images/lopez.jpg", Stat1 = 16, Stat2 = 2, Stat3 = 7, Stat4 = 3 },
    new Player { Name = "Jrue Holiday", Team = "Bucks", PhotoPath = "images/holiday.jpg", Stat1 = 19, Stat2 = 7, Stat3 = 5, Stat4 = 2 }
    };
        public static void AddPlayer(Player player) => Players.Add(player);
        public static void RemovePlayer(Player player) => Players.Remove(player);
    }
}
