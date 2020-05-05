using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static GameStoreApp.DBController;

namespace GameStoreApp
{
    public partial class MainForm : Form
    {
        private OrderInfoForm infoForm;
        public MainForm()
        {
            InitializeComponent();
            CreateGamesLayout();
        }

        void CreateGamesLayout()
        {
            var games = DBController.GetGamesParams();
            InitializeFilter(games);
            ShowGames(games);
        }

        void ShowGames(List<GameParams> games)
        {
            if (games.Count == 0)
            {
                MessageBox.Show("Поиск не дал результатов. Попробуйте изменить параметры фильтрации");
                CreateGamesLayout();
                return;
            }
            MainLayout.Controls.Clear();
            MainLayout.RowStyles.Clear();
            MainLayout.ColumnStyles.Clear();
            MainLayout.ColumnCount = 2;
            MainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, new GameCatalogControl().Size.Width));
            MainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, new GameCatalogControl().Size.Width));
            var numberOfGames = games.Count();
            MainLayout.RowCount = (numberOfGames / MainLayout.ColumnCount);
            int columnCounter = 0;
            int rowCounter = -1;
            foreach (var game in games)
            {
                columnCounter %= MainLayout.ColumnCount;
                if (columnCounter == 0)
                {
                    MainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, new GameCatalogControl().Size.Height));
                    rowCounter++;
                }
                var newControl = new GameCatalogControl(UIController.PrepareGameToDisplay(game));
                newControl.GameBoughtEvent += GameBought;
                newControl.GameClickedEvent += OpenGameInfo;
                MainLayout.Controls.Add(newControl, columnCounter, rowCounter);
                columnCounter++;
            }
        }

        void OpenGameInfo(string name)
        {
            var gameToDisplay = UIController.PrepareGameToDisplay(DBController.GetGameByName(name));
            var gameInfoForm = new GameInfoForm(gameToDisplay);
            gameInfoForm.GameBoughtEvent += GameBought;
            gameInfoForm.Show();
        }
        void GameBought(object sender, string name, decimal price)
        {
            if (!CheckAvailability(name))
            {
                MessageBox.Show("Невозможно добавить игру в заказ, недостаточно игр на складе");
                return;
            }
            UIController.currentOrderGames.Add(new Tuple<string, decimal>(name, price));
            if (UIController.currentOrderGames.Count > 0) CartButton.Enabled = true;
            CartButton.Text = $"Корзина({UIController.currentOrderGames.Count()})";
        }

        bool CheckAvailability(string name)
        {
            var currentGameCount = (from game in UIController.currentOrderGames
                                    where game.Item1 == name
                                    select game).Count();
            var availableGames = DBController.GetGameByName(name).Quantity;
            return availableGames > currentGameCount;
        }
        void InitializeFilter(List<GameParams> games)
        {
            var prices = from game in games select game.Price;
            PriceFilter.MaxValue = (int)prices.Max() + 1;
            PriceFilter.MinValue = (int)prices.Min();
            PlayersNumberFilter.MinValue = (from game in games select game.minPlayers).Min();
            PlayersNumberFilter.MaxValue = (from game in games select game.maxPlayers).Max();
            DifficultyFilter.MaxValue = 5;
            DifficultyFilter.MinValue = 1;
            DurationFilter.MinValue = (from game in games select game.minDuration).Min();
            DurationFilter.MaxValue = (from game in games select game.maxDuration).Max();
            var genres = (from game in games select game.Genre).Distinct();
            int i = 1;
            GenreComboBox.Items.Clear();
            GenreComboBox.Items.Insert(0, "Не указано");
            GenreComboBox.SelectedIndex = 0;
            foreach(var genre in genres)
            {
                GenreComboBox.Items.Insert(i++, genre);
            }
            i = 1;
            var types = (from game in games select game.Type).Distinct();
            TypeComboBox.Items.Clear();
            TypeComboBox.Items.Insert(0, "Не указано");
            TypeComboBox.SelectedIndex = 0;
            foreach (var type in types)
            {
                TypeComboBox.Items.Insert(i++, type);
            }
            startsWithTextBox.Text = string.Empty;
        }
        void refreshFiltersButton_Click(object sender, EventArgs e)
        {
            CreateGamesLayout();
        }

        void FilterChanged(object sender, EventArgs e)
        {
            int minDuration = DurationFilter.SelectedMinValue;
            int maxDuration = DurationFilter.SelectedMaxValue;
            int minPlayers = PlayersNumberFilter.SelectedMinValue;
            int maxPlayers = PlayersNumberFilter.SelectedMaxValue;
            int minPrice = PriceFilter.SelectedMinValue;
            int maxPrice = PriceFilter.SelectedMaxValue;
            int minDifficulty = DifficultyFilter.SelectedMinValue;
            int maxDifficulty = DifficultyFilter.SelectedMaxValue;
            string genre = GenreComboBox.SelectedItem != null? GenreComboBox.SelectedItem.ToString() : "";
            string type = TypeComboBox.SelectedItem != null ? TypeComboBox.SelectedItem.ToString() : "";
            string startsWith = startsWithTextBox.Text;
            ShowGames(DBController.GetGamesParamsWithFilter(startsWith, minPrice, maxPrice, minDuration, maxDuration, minDifficulty, maxDifficulty, minPlayers, maxPlayers, genre, type));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var location = PointToScreen(CartButton.Location);
            location.Y += CartButton.Height;
            location.X += CartButton.Width / 2;
            infoForm = new OrderInfoForm(location, UIController.currentOrderGames);
            infoForm.CartClearEvent += ClearCart;
            infoForm.Show();
        }

        private void ClearCart(object sender, EventArgs eventArgs)
        {
            CartButton.Text = "Корзина";
            CartButton.Enabled = false;
            CreateGamesLayout();
        }

        private void обновлениеСкладаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var loginWindow = new LoginWindow("Администратор");
            if (loginWindow.ShowDialog() == DialogResult.OK)
            {
                var gameEditForm = new GamesDBEditForm1();
                gameEditForm.FormClosing += GameEditForm_FormClosing;
                gameEditForm.Show();
            }
        }

        private void GameEditForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CreateGamesLayout();
        }

        private void отчётыПоПродажамToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var loginWindow = new LoginWindow("Владелец");
            var reportsForm = new SellingReportsForm();
            if (loginWindow.ShowDialog() == DialogResult.OK)
            {
                reportsForm.Show();
                Console.WriteLine("логин!");
            }
        }

    }
}
