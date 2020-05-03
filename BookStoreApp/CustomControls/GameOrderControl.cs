using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStoreApp.Controls
{
    public partial class GameOrderControl : UserControl
    {
        public GameOrderControl()
        {
            InitializeComponent();
        }
        public GameOrderControl(GameToDisplay game)
        {
            InitializeComponent();
            NameTextBox.Text = game.Name;
            GenreTextBox.Text = game.Genre;
            TypeTextBox.Text = game.Type;
            priceTextBox.Text = game.Price;
            DurationTextBox.Text = game.Duration;
            playersTextBox.Text = game.Players;
            AuthorTextBox.Text = game.Author;
            pictureBox1.Image = game.Image;
            QuantityTextBox.Text = $"Количество в коризе: {game.Quantity}";
            TotalTextBox.Text = (game.Quantity * decimal.Parse(game.Price.Substring(0, game.Price.Length - 1))).ToString() + "₽";
        }
    }
}
