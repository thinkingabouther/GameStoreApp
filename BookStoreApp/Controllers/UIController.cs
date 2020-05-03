using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BookStoreApp.DBController;

namespace BookStoreApp
{
    public static class UIController
    {
        public static List<Tuple<string, decimal>> currentOrderGames = new List<Tuple<string, decimal>>();
        public static GameToDisplay PrepareGameToDisplay(GameParams gameParams)
        {
            var gameToDisplay = new GameToDisplay();
            gameToDisplay.Name = gameParams.Name;
            gameToDisplay.Image = gameParams.Image != null? (Image)gameParams.Image.Clone() : null;
            gameToDisplay.Duration = $"{gameParams.minDuration}-{gameParams.maxDuration}";
            gameToDisplay.Players = $"{gameParams.minPlayers}-{gameParams.maxPlayers}";
            gameToDisplay.Price = gameParams.Price.ToString() + "₽";
            gameToDisplay.Description = gameParams.Description;
            gameToDisplay.Quantity = gameParams.Quantity;
            gameToDisplay.Type = gameParams.Type;
            gameToDisplay.Genre = gameParams.Genre;
            gameToDisplay.Author = gameParams.Author;
            gameToDisplay.Difficulty = gameParams.Difficulty;
            gameToDisplay.GenreDescription = gameParams.GenreDescription;
            gameToDisplay.TypeDescription = gameParams.TypeDescription;
            return gameToDisplay;
        }

        public static List<OrderToReport> PrepareOrdersToReport(DateTime dateFrom, DateTime dateTo)
        {
            var ordersToReport = new List<OrderToReport>();
            var orders = DBController.GetOrdersParams(dateFrom, dateTo);
            foreach(var order in orders)
            {
                ordersToReport.Add(new OrderToReport(order));
            }
            return ordersToReport;
        }

        public static List<GameToReport> PrepareGamesToReport(DateTime dateFrom, DateTime dateTo)
        {
            var gamesToReport = new List<GameToReport>();
            var games = new List<GameParams>();
            var orders = DBController.GetOrdersParams(dateFrom, dateTo);
            foreach(var order in orders)
            {
                foreach(var game in order.games)
                {
                    games.Add(game);
                }
            }
            var groupedGames = from game in games group games by game.Name;
            foreach(var game in groupedGames)
            {
                gamesToReport.Add(new GameToReport()
                {
                    Name = game.Key,
                    Quantity = game.Count(),
                    Price = game.First().First().Price,
                    Total = game.First().First().Price * game.Count()
                }) ;
            }
            return gamesToReport;
        }
    }

    public class GameToDisplay
    {
        public string Name;
        public Image Image;
        public string Duration;
        public string Players;
        public string Price;
        public string Description;
        public string Author;
        public string Type;
        public string TypeDescription;
        public string Genre;
        public string GenreDescription;
        public int Difficulty;
        public int Quantity;
    }

    public class OrderToDB
    {
        public string ClientName;
        public string ClientMail;
        public List<Tuple<string, int>> games;
        public DateTime Date;
    }

    public class OrderToReport
    {
        public int ID;
        public DateTime Date;
        public int Quantity;
        public decimal Sum;

        public OrderToReport(OrderParams order)
        {
            ID = order.ID;
            Date = order.Date;
            Sum = (from game in order.games
                   select game.Price).Sum();
            Quantity = (from game in order.games
                        select game).Count();
        }
    }
    
    public class GameToReport
    {
        public string Name;
        public int Quantity;
        public decimal Price;
        public decimal Total;
    }
}
