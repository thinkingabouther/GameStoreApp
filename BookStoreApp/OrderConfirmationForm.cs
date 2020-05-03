using BookStoreApp.Controls;
using BookStoreApp.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BookStoreApp.DBController;

namespace BookStoreApp
{
    public partial class OrderConfirmationForm : Form
    {
        public OrderConfirmationForm(List<GameParams> games)
        {
            InitializeComponent();
            ShowOrder(games);
        }

        void ShowOrder(List<GameParams> games)
        {
            gamesInOrderLayout.Controls.Clear();
            gamesInOrderLayout.RowStyles.Clear();
            gamesInOrderLayout.ColumnStyles.Clear();
            gamesInOrderLayout.ColumnCount = 1;
            gamesInOrderLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, new GameOrderControl().Size.Width));
            gamesInOrderLayout.RowCount = games.Count();
            int rowCounter = 0;
            foreach(var game in games)
            {
                var newControl = new GameOrderControl(UIController.PrepareGameToDisplay(game));
                gamesInOrderLayout.Controls.Add(newControl, 0, rowCounter++);               
            }
            totalLabel.Text = $"Итог: {(from game in games select game.Quantity*game.Price).Sum()}₽";
        }

        private void OrderButton_Click(object sender, EventArgs e)
        {
            if (CheckInputData())
            {
                var currentOrder = new OrderToDB()
                {
                    ClientName = nameTextBox.Text,
                    ClientMail = mailTextBox.Text,
                    Date = DateTime.Now,
                    games = new List<Tuple<string, int>>()
                };
                foreach (var game in (from game in UIController.currentOrderGames group game by game.Item1))
                {
                    currentOrder.games.Add(new Tuple<string, int>(game.Key, game.Count()));
                }
                var order = DBController.AddOrderToDB(currentOrder);
                MessageBox.Show($"Ваш заказ №{order.ID} успешно оформлен");
                UIController.currentOrderGames.Clear();
                var currentOrderToReport = DBController.GetOrderParamsByID(order.ID);
                ReportExportController.CreateReceipt(currentOrderToReport);
                DialogResult = DialogResult.OK;
                
            }
        }

        bool CheckInputData()
        {
            if (Regex.IsMatch(mailTextBox.Text, @"(\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*)"))
                return true;
            MessageBox.Show("Некорректный ввод. Попробуйте исправить адрес электронной почты");
            return false;
        }
    }
}
