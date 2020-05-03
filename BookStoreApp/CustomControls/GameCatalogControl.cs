using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStoreApp
{
    public partial class GameCatalogControl : UserControl
    {
        public Image Image
        {
            get
            {
                return GameImage.Image;
            }
            set
            {
                GameImage.Image = value;
            }
        }

        public new string Name
        {
            get
            {
                return GameTextBox.Text;
            }
            set
            {
                GameTextBox.Text = value;
            }
        }

        public string Players
        {
            get
            {
                return PlayersNumberTextBox.Text;
            }
            set
            {
                PlayersNumberTextBox.Text = value;
            }
        }

        public string Duration
        {
            get
            {
                return DurationTextBox.Text;
            }
            set
            {
                DurationTextBox.Text = value;
            }
        }

        public string Price
        {
            get
            {
                return BuyButton.Text;
            }
            set
            {
                BuyButton.Text = value;
            }
        }

        public string Description
        {
            get
            {
                return DescriptionTextBox.Text;
            }
            set
            {
                DescriptionTextBox.Text = value;
            }
        }
        public GameCatalogControl()
        {
            InitializeComponent();
        }

        public GameCatalogControl(GameToDisplay game)
        {
            InitializeComponent();
            foreach (Control control in this.Controls)
            {
                if (control != BuyButton)
                    control.Click += GameCatalogControl_Click;
            }
            ShowGameDetails(game);
        }

        private void ShowGameDetails(GameToDisplay game)
        {
            Name = game.Name;
            Image = game.Image;
            Players = game.Players;
            Duration = game.Duration;
            Description = game.Description;
            Price = game.Price;
            if (game.Quantity < 1)
            {
                BuyButton.Enabled = false;
                BuyButton.TextAlign = ContentAlignment.MiddleCenter;
                BuyButton.Text = "Нет в наличии";
                pictureBox1.Hide();
            }
        }

        public delegate void GameBoughtDelegate(object sender, string itemName, decimal price);

        public event GameBoughtDelegate GameBoughtEvent;

        public void OnGameBought()
        {
            GameBoughtEvent?.Invoke(this, Name, decimal.Parse(Price.Replace("₽", "")));
        }

        private void ShowDetails()
        {
            DescriptionTextBox.Visible = false;
            DurationPictureBox.Visible = true;
            DurationTextBox.Visible = true;
            PlayersNumberTextBox.Visible = true;
            PlayersPictureBox.Visible = true;

        }

        private void HideDetails()
        {
            DescriptionTextBox.Visible = true;
            DurationPictureBox.Visible = false;
            DurationTextBox.Visible = false;
            PlayersNumberTextBox.Visible = false;
            PlayersPictureBox.Visible = false;
        }

        private void GameControl_MouseEnter(object sender, EventArgs e)
        {
            ShowDetails();
        }

        private void GameControl_MouseLeave(object sender, EventArgs e)
        {
            int x1 = PointToScreen(Point.Empty).X;
            int y1 = PointToScreen(Point.Empty).Y;
            int x2 = PointToScreen(Point.Empty).X + Width;
            int y2 = PointToScreen(Point.Empty).Y + Height;
            if (Cursor.Position.X > x2 || Cursor.Position.X < x1 || Cursor.Position.Y > y2 || Cursor.Position.Y < y1)
                HideDetails();
        }

        private void BuyButton_Click(object sender, EventArgs e)
        {
            OnGameBought();
        }

        public delegate void GameClickedDelegate(string name);
        
        public event GameClickedDelegate GameClickedEvent;

        private void OnGameClicked()
        {
            GameClickedEvent?.Invoke(Name);
        }
        private void GameCatalogControl_Click(object sender, EventArgs e)
        {
            OnGameClicked();
        }
    }
}
