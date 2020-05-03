using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStoreApp
{
    public partial class GameInfoForm : Form
    {
        public GameInfoForm()
        {
            InitializeComponent();
        }

        public GameInfoForm(GameToDisplay game)
        {
            InitializeComponent();
            ShowGameInfo(game);
        }

        private void ShowGameInfo(GameToDisplay game)
        {
            pictureBox1.Image = game.Image;
            NameTextBox.Text = game.Name;
            DescriptionTextBox.Text = game.Description;
            difficultyRating1.Value = game.Difficulty;
            genreTextBox.Text = game.Genre;
            var genreToolTip = new ToolTip();
            genreToolTip.SetToolTip(genreTextBox, game.GenreDescription);
            TypeTextBox.Text = game.Type;
            var typeToolTip = new ToolTip();
            typeToolTip.SetToolTip(TypeTextBox, game.TypeDescription);
            priceTextBox.Text = game.Price;
            PlayersTextBox.Text = game.Players;
            durationTextBox.Text = game.Duration;
            authorTextBox.Text = game.Author;
            QuantityLabel.Text = $"На складе: {game.Quantity.ToString()}";
        }

        private void BuyButton_Click(object sender, EventArgs e)
        {
            OnItemBought();
        }

        public delegate void ItemBoughtDelegate(object sender, string name, decimal price);
        public event ItemBoughtDelegate GameBoughtEvent;
        private void OnItemBought()
        {
            GameBoughtEvent?.Invoke(this, NameTextBox.Text, decimal.Parse(priceTextBox.Text.Replace("₽", "")));
        }
    }
}
