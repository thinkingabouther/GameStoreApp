using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BookStoreApp.DBController;

namespace BookStoreApp
{
    public partial class OrderInfoForm : Form
    {
        public OrderInfoForm(Point location, List<Tuple<string, decimal>> games)
        {
            InitializeComponent();
            location.X -= Width / 2;
            this.Location = location;
            ShowGames(games);
        }

        void ShowGames(List<Tuple<string, decimal>> games)
        {
            var groupedGames = from game in games group game by game.Item1;
            var sum = (from game in games select game.Item2).Sum();
            foreach(var game in groupedGames)
            {
                dataGridView1.Rows.Add(game.Key, $"{game.First().Item2}₽", game.Count());
            }
            TotalLabel.Text = $"Итог: {sum}₽";
        }

        private void OrderInfoForm_Deactivate(object sender, EventArgs e)
        {
            Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UIController.currentOrderGames.Clear();
            OnCartClear();
            Dispose();
        }

        public event EventHandler CartClearEvent;

        public void OnCartClear()
        {
            CartClearEvent?.Invoke(this, EventArgs.Empty);
        }

        private void OrderButton_Click(object sender, EventArgs e)
        {

            var currentOrderGameParams = new List<GameParams>();
            var groupedGames = from game in UIController.currentOrderGames group game by game.Item1;
            foreach(var game in groupedGames)
            {
                var currentGame = DBController.GetGameByName(game.Key);
                currentGame.Quantity = game.Count();
                currentOrderGameParams.Add(currentGame);
            }
            var orderConfirmationForm = new OrderConfirmationForm(currentOrderGameParams);
            Hide();
            if (orderConfirmationForm.ShowDialog() == DialogResult.OK)
            {
                OnCartClear();
            }
            Dispose();
        }
    }



}
