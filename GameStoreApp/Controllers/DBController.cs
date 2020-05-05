using GameStoreApp.DB;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStoreApp
{
    public class DBController
    {
        public static List<GameParams> GetGamesParams()
        {
            var games = new List<GameParams>();
            using (var db = new GameStoreDBContext())
            {
                foreach (var game in db.Game)
                {
                    var currentGame = ExtractGameParams(game);
                    games.Add(currentGame);
                }
            }
            return games;
        }

        private static GameParams ExtractGameParams(Game game)
        {
            var currentGame = new GameParams();
            using (var db = new GameStoreDBContext())
            {
                currentGame.ID = game.ID;
                currentGame.Name = game.Name;
                var imageConverter = new ImageConverter();
                currentGame.Image = game.Image != null ? (Image)imageConverter.ConvertFrom(game.Image) : null;
                currentGame.minDuration = game.Min_Duration;
                currentGame.maxDuration = game.Max_Duration;

                currentGame.minPlayers = game.Min_Players;
                currentGame.maxPlayers = game.Max_Players;
                currentGame.Price = Math.Round(game.Price, 2);
                currentGame.Description = game.Description;
                currentGame.Genre = (from genre in db.Genre
                                     where game.Genre_ID == genre.ID
                                     select genre.Name).First();
                currentGame.Type = (from type in db.Type
                                    where game.Type_ID == type.ID
                                    select type.Name).First();
                currentGame.Quantity = game.Quantity;
                currentGame.Author = (from author in db.Author
                                      where game.Author_ID == author.ID
                                      select author.Manufacturer).First();
                currentGame.Difficulty = game.Difficulty;
                currentGame.GenreDescription = (from genre in db.Genre
                                                where game.Genre_ID == genre.ID
                                                select genre.Description).First();
                currentGame.TypeDescription = (from type in db.Type
                                               where type.ID == game.Type_ID
                                               select type.Description).First();
            }
            return currentGame;
        }
        public static List<GameParams> GetGamesParamsWithFilter(string startsWith,
                                                                int minPrice, int maxPrice,
                                                                int minDuration, int maxDuration,
                                                                int minDifficulty, int maxDifficulty,
                                                                int minPlayers, int maxPlayers,
                                                                string genre, string type)
        {
            var games = new List<GameParams>();
            using (var db = new GameStoreDBContext())
            {
                var selectedGames = from game in db.Game
                                    where
                                    maxPrice >= game.Price &&
                                    minPrice <= game.Price &&
                                    minDuration <= game.Min_Duration &&
                                    maxDuration >= game.Max_Duration &&
                                    minDifficulty <= game.Difficulty &&
                                    maxDifficulty >= game.Difficulty &&
                                    minPlayers <= game.Min_Players &&
                                    maxPlayers >= game.Max_Players
                                    select game;
                if (genre != "Не указано")
                {
                    selectedGames = from game in selectedGames
                                    where game.Genre == (from currentGenre in db.Genre where currentGenre.ID == game.Genre_ID select currentGenre).FirstOrDefault()
                                    select game;
                }
                if (type != "Не указано")
                {
                    selectedGames = from game in selectedGames
                                    where game.Type == (from currentType in db.Type where currentType.ID == game.Type_ID select currentType).FirstOrDefault()
                                    select game;
                }
                if (startsWith != string.Empty)
                {
                    selectedGames = from game in selectedGames
                                    where game.Name.StartsWith(startsWith)
                                    select game;
                }
                foreach (var selectedGame in selectedGames)
                {
                    var currentGame = ExtractGameParams(selectedGame);
                    games.Add(currentGame);
                }
            }
            return games;
        }

        public static GameParams GetGameByName(string name)
        {
            using (var db = new GameStoreDBContext())
            {
                var currentGame = (from game in db.Game
                                   where game.Name == name
                                   select game).First();
                return ExtractGameParams(currentGame);
            }
        }

        public static int GetGameIDByName(string name)
        {
            using (var db = new GameStoreDBContext())
            {
                var id = (from game in db.Game
                          where game.Name == name
                          select game.ID).First();
                return id;
            }
        }
        public static OrderParams AddOrderToDB(OrderToDB order)
        {
            using (var db = new GameStoreDBContext())
            {
                var gameIDs_Count = new List<Tuple<int, int>>();
                foreach (var game in order.games)
                {
                    gameIDs_Count.Add(new Tuple<int, int>(GetGameIDByName(game.Item1), game.Item2));
                }
                var currentClient = new Client()
                {
                    Email = order.ClientMail,
                    Name = order.ClientName
                };
                db.Client.Add(currentClient);
                var currentOrder = new Order
                {
                    Client_ID = currentClient.ID,
                    Date = order.Date
                };
                db.Order.Add(currentOrder);
                foreach (var gameID in gameIDs_Count)
                {
                    var currentConnection = new Orders_Games()
                    {
                        Game_ID = gameID.Item1,
                        Order_ID = currentOrder.ID,
                        Games_number = gameID.Item2
                    };
                    db.Orders_Games.Add(currentConnection);
                    var gameToReduceQuantity = (from game in db.Game
                                                where game.ID == gameID.Item1
                                                select game).First();
                    gameToReduceQuantity.Quantity -= gameID.Item2;
                }
                db.SaveChanges();
                var orderParams = new OrderParams()
                {
                    Date = currentOrder.Date,
                    ID = currentOrder.ID,
                    games = ExtractGamesFromOrder(currentOrder)
                };
                return orderParams;
            }
        }
        public static bool RemoveGameByID(int id)
        {
            using (var db = new GameStoreDBContext())
            {
                var gamesToDelete = (from game in db.Game
                                     where game.ID == id
                                     select game);
                if (gamesToDelete.Count() != 1) return false;
                var gameToDelete = gamesToDelete.First();
                db.Game.Remove(gameToDelete);
                db.SaveChanges();
                return true;
            }
        }
        public static GameParams GetGameByID(int id)
        {
            using (var db = new GameStoreDBContext())
            {
                var currentGame = (from game in db.Game
                                   where game.ID == id
                                   select game).First();
                return ExtractGameParams(currentGame);
            }
        }

        public static bool IsGenreInDB(string genreName)
        {
            using (var db = new GameStoreDBContext())
            {
                return (from genre in db.Genre
                        where genre.Name == genreName
                        select genre).Count() > 0;
            }
        }

        public static bool IsTypeInDB(string typeName)
        {
            using (var db = new GameStoreDBContext())
            {
                return (from type in db.Type
                        where type.Name == typeName
                        select type).Count() > 0;
            }
        }
        public static bool ChangeGameProperty(int gameID, string propertyName, string propertyValue)
        {
            using (var db = new GameStoreDBContext())
            {
                var currentGame = (from game in db.Game
                                   where game.ID == gameID
                                   select game).First();
                switch (propertyName)
                {
                    case "Name":
                        var gameNames = (from game in db.Game
                                         where game.ID != gameID
                                         select game.Name);
                        if (gameNames.Contains(propertyValue)) return false;
                        currentGame.Name = propertyValue;
                        break;
                    case "Description":
                        currentGame.Description = propertyValue;
                        break;
                    case "Price":
                        currentGame.Price = decimal.Parse(propertyValue);
                        break;
                    case "Quantity":
                        currentGame.Quantity = int.Parse(propertyValue);
                        break;
                    case "Author":
                        break;
                    case "minDuration":
                        currentGame.Min_Duration = int.Parse(propertyValue);
                        break;
                    case "maxDuration":
                        currentGame.Max_Duration = int.Parse(propertyValue);
                        break;
                    case "Genre":
                        break;
                    case "minPlayers":
                        currentGame.Min_Players = int.Parse(propertyValue);
                        break;
                    case "maxPlayers":
                        currentGame.Max_Players = int.Parse(propertyValue);
                        break;
                    case "Type":
                        break;
                }
                db.SaveChanges();
                return true;
            }
        }

        public static string GetPropertyValue(int gameID, string propertyName)
        {
            using (var db = new GameStoreDBContext())
            {
                var currentGame = (from game in db.Game
                                   where game.ID == gameID
                                   select game).First();
                switch (propertyName)
                {
                    case "Name":
                        return currentGame.Name;
                    case "Description":
                        return currentGame.Description;
                    case "Price":
                        return (Math.Round(currentGame.Price, 2)).ToString();
                    case "Quantity":
                        return currentGame.Quantity.ToString();
                    case "Author":
                        return (from author in db.Author
                                where author.ID == currentGame.Author_ID
                                select author).First().Manufacturer;
                    case "minDuration":
                        return currentGame.Min_Duration.ToString();
                    case "maxDuration":
                        return currentGame.Max_Duration.ToString();
                    case "Difficulty":
                        return currentGame.Difficulty.ToString();
                    case "minPlayers":
                        return currentGame.Min_Players.ToString();
                    case "maxPlayers":
                        return currentGame.Max_Players.ToString();
                    case "Genre":
                        return (from genre in db.Genre
                                where genre.ID == currentGame.Genre_ID
                                select genre).First().Name;
                    case "Type":
                        return (from type in db.Type
                                where type.ID == currentGame.Type_ID
                                select type).First().Name;
                    default:
                        return "Невозможно получить данные";
                }
            }
        }
        public static void ChangeGameGenre(int gameID, string genreName, string description)
        {
            using (var db = new GameStoreDBContext())
            {
                var currentGameGenre = (from genre in db.Genre
                                        where genre.ID == (from game in db.Game
                                                           where game.ID == gameID
                                                           select game).FirstOrDefault().Genre_ID
                                        select genre).First();
                currentGameGenre.Name = genreName;
                currentGameGenre.Description = description;
                db.SaveChanges();
            }
        }

        public static void ChangeGameType(int gameID, string gameType, string description)
        {
            using (var db = new GameStoreDBContext())
            {
                var currentGameType = (from type in db.Type
                                       where type.ID == (from game in db.Game
                                                         where game.ID == gameID
                                                         select game).FirstOrDefault().Type_ID
                                       select type).First();
                currentGameType.Name = gameType;
                currentGameType.Description = description;
                db.SaveChanges();
            }
        }

        public static void ChangeGameAuthor(int gameID, string newAuthorName)
        {
            using (var db = new GameStoreDBContext())
            {
                var currentAuthor = (from author in db.Author
                                     where author.ID == (from game in db.Game
                                                         where game.ID == gameID
                                                         select game).FirstOrDefault().Author_ID
                                     select author).First();
                currentAuthor.Manufacturer = newAuthorName;
                db.SaveChanges();
            }
        }

        public static string GetTypeDescription(int gameID)
        {
            using (var db = new GameStoreDBContext())
            {
                var currentType = (from type in db.Type
                                   where type.ID == (from game in db.Game
                                                     where game.ID == gameID
                                                     select game).FirstOrDefault().Type_ID
                                   select type).First();
                return currentType.Description;
            }
        }

        public static string GetGenreDescription(int gameID)
        {
            using (var db = new GameStoreDBContext())
            {
                var currentGenre = (from genre in db.Genre
                                    where genre.ID == (from game in db.Game
                                                       where game.ID == gameID
                                                       select game).FirstOrDefault().Genre_ID
                                    select genre).First();
                return currentGenre.Description;
            }
        }

        public static int AddGameTypeToDB(string gameType, string description)
        {
            var newType = new DB.Type { Name = gameType, Description = description };
            using (var db = new GameStoreDBContext())
            {
                if ((from currentType in db.Type where currentType.Name == gameType select currentType).Count() > 0) return -1;
                db.Type.Add(newType);
                db.SaveChanges();
                return newType.ID;
            }
        }
        public static int AddGenreToDB(string genre, string description)
        {
            var newGenre = new Genre { Name = genre, Description = description };
            using (var db = new GameStoreDBContext())
            {
                if ((from currentGenre in db.Genre where currentGenre.Name == genre select currentGenre).Count() > 0) return -1;
                db.Genre.Add(newGenre);
                db.SaveChanges();
                return newGenre.ID;
            }
        }
        public static int AddAuthorToDB(string author)
        {
            var newAuthor = new Author { Manufacturer = author };
            using (var db = new GameStoreDBContext())
            {
                db.Author.Add(newAuthor);
                db.SaveChanges();
                return newAuthor.ID;
            }
        }
        public static bool AddGameToDB(GameParams game)
        {
            using (var db = new GameStoreDBContext())
            {

                var currentGenreIds = (from genre in db.Genre
                                       where genre.Name == game.Genre
                                       select genre.ID);
                if (currentGenreIds.Count() < 1) return false;
                var currentGenreID = currentGenreIds.First();

                var currentTypeIds = (from type in db.Type
                                      where type.Name == game.Type
                                      select type.ID);
                if (currentTypeIds.Count() < 1) return false;
                var currentTypeID = currentTypeIds.First();

                var currentAuthorIds = (from author in db.Author
                                        where author.Manufacturer == game.Author
                                        select author.ID);
                if (currentAuthorIds.Count() < 1) return false;
                var currentAuthorID = currentAuthorIds.First();
                var currentGame = new Game
                {
                    Name = game.Name,
                    Max_Duration = game.maxDuration,
                    Min_Duration = game.minDuration,
                    Max_Players = game.maxPlayers,
                    Min_Players = game.minPlayers,
                    Genre_ID = currentGenreID,
                    Type_ID = currentTypeID,
                    Price = game.Price,
                    Description = game.Description,
                    Quantity = game.Quantity,
                    Author_ID = currentAuthorID,
                    Difficulty = game.Difficulty
                };
                db.Game.Add(currentGame);
                db.SaveChanges();
                return true;
            }
        }
        public static void AddImageToGameByID(int id, byte[] image)
        {
            using (var db = new GameStoreDBContext())
            {
                var selectedGame = (from game in db.Game
                                    where game.ID == id
                                    select game).First();
                selectedGame.Image = image;
                db.SaveChanges();
            }
        }
        public static List<OrderParams> GetOrdersParams(DateTime dateFrom, DateTime dateTo)
        {
            var orders = new List<OrderParams>();
            var actualDateTo = dateTo.AddDays(1);
            Console.WriteLine(actualDateTo);
            using (var db = new GameStoreDBContext())
            {
                var currentOrders = from order in db.Order
                                    where order.Date >= dateFrom &&
                                          order.Date <= actualDateTo
                                    select order;
                foreach (var order in currentOrders)
                {
                    var currentOrder = new OrderParams()
                    {
                        Date = order.Date,
                        ID = order.ID,
                        games = ExtractGamesFromOrder(order)
                    };
                    orders.Add(currentOrder);
                }
            }
            return orders;
        }
        public static List<GameParams> ExtractGamesFromOrder(Order order)
        {
            var games = new List<GameParams>();
            using (var db = new GameStoreDBContext())
            {
                var gamesConnections = from gameConnection in db.Orders_Games
                                       where gameConnection.Order_ID == order.ID
                                       select gameConnection;
                foreach (var game in gamesConnections)
                {
                    for (int i = 0; i < game.Games_number; i++)
                        games.Add(GetGameByID(game.Game_ID));
                }
            };
            return games;
        }
        public static Client GetClientByOrderID(int orderID)
        {
            using (var db = new GameStoreDBContext())
            {
                return (from client in db.Client
                        where client.ID == (from order in db.Order
                                            where order.ID == orderID
                                            select order.Client_ID).FirstOrDefault()
                        select client).First();
            }
        }
        public static OrderParams GetOrderParamsByID(int orderID)
        {
            using (var db = new GameStoreDBContext())
            {
                var currentOrder = (from order in db.Order
                                    where order.ID == orderID
                                    select order).First();
                var connections = (from connection in db.Orders_Games
                                   where connection.Order_ID == orderID
                                   select connection);
                var orderParams = new OrderParams();
                orderParams.Date = currentOrder.Date;
                orderParams.ID = currentOrder.ID;
                orderParams.games = new List<GameParams>();
                foreach(var connection in connections)
                {
                    var currentGame = ExtractGameParams((from game in db.Game
                                       where game.ID == connection.Game_ID
                                       select game).First());
                    currentGame.Quantity = connection.Games_number;
                    orderParams.games.Add(currentGame);
                }
                return orderParams;
            }
        }
        public class GameParams
        {
            public int ID;
            public string Name;
            public Image Image;
            public int minDuration;
            public int maxDuration;
            public int maxPlayers;
            public int minPlayers;
            public string Genre;
            public string GenreDescription;
            public string Type;
            public string TypeDescription;
            public decimal Price;
            public string Description;
            public int Quantity;
            public string Author;
            public int Difficulty;
        }
        public class OrderParams
        {
            public int ID;
            public DateTime Date;
            public List<GameParams> games;
        }
    }
}
