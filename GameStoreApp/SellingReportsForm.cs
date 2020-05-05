using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameStoreApp
{
    public partial class SellingReportsForm : Form
    {
        public ReportType ReportType;
        public SellingReportsForm()
        {
            InitializeComponent();
            ShowOrderReport();
            reportChart.LegendLocation = LegendLocation.Right;
            dateTimePickerTo.MaxDate = DateTime.Today;
            dateTimePickerFrom.MaxDate = DateTime.Today;
        }

        void ShowOrderReport()
        {
            var orders = UIController.PrepareOrdersToReport(dateTimePickerFrom.Value, dateTimePickerTo.Value);
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            var column1 = new DataGridViewTextBoxColumn();
            column1.HeaderText = "ID заказа";
            column1.Width = 100;
            dataGridView1.Columns.Add(column1);
            var column2 = new DataGridViewTextBoxColumn();
            column2.HeaderText = "Время заказа";
            column2.Width = 200;
            dataGridView1.Columns.Add(column2);
            var column3 = new DataGridViewTextBoxColumn();
            column3.HeaderText = "Количество игр";
            column3.Width = 100;
            dataGridView1.Columns.Add(column3);
            var column4 = new DataGridViewTextBoxColumn();
            column4.HeaderText = "Сумма (рублей)";
            column4.Width = 200;
            dataGridView1.Columns.Add(column4);
            foreach (var order in orders)
            {
                dataGridView1.Rows.Add(order.ID, order.Date, order.Quantity, order.Sum);
            }
            var total = (from order in orders select order.Sum).Sum();
            totalLabel.Text = $"Общая выручка: {total}₽";
            dataGridView1.Refresh();
            ShowOrdersOnChart(orders);
        }

        void ShowOrdersOnChart(List<OrderToReport> orders)
        {
            SeriesCollection series = new SeriesCollection();
            foreach (var order in orders)
            {
                series.Add(new PieSeries
                {
                    Title = $"Заказ {order.ID}",
                    Values = new ChartValues<decimal> { order.Sum },
                    DataLabels = false,
                    LabelPoint = label
                }) ;
            }
            reportChart.Series = series;
        }

        Func<ChartPoint, string> label = chartPoint => 
        string.Format("{0}₽ ({1:P})", chartPoint.Y, chartPoint.Participation);

        void ShowGameReport()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();
            var column1 = new DataGridViewTextBoxColumn();
            column1.HeaderText = "Название игры";
            column1.Width = 200;
            dataGridView1.Columns.Add(column1);
            var column2 = new DataGridViewTextBoxColumn();
            column2.HeaderText = "Количество проданных";
            column2.Width = 100;
            dataGridView1.Columns.Add(column2);
            var column3 = new DataGridViewTextBoxColumn();
            column3.HeaderText = "Цена (рублей)";
            column3.Width = 100;
            dataGridView1.Columns.Add(column3);
            var column4 = new DataGridViewTextBoxColumn();
            column4.HeaderText = "Итог (рублей)";
            column3.Width = 100;
            dataGridView1.Columns.Add(column4);
            var games = UIController.PrepareGamesToReport(dateTimePickerFrom.Value, dateTimePickerTo.Value);
            foreach(var game in games)
            {
                dataGridView1.Rows.Add(game.Name, game.Quantity, game.Price, game.Total);
            }
            dataGridView1.Refresh();
            ShowGamesOnChart(games);
        }

        void ShowGamesOnChart(List<GameToReport> games)
        {
            SeriesCollection series = new SeriesCollection();
            foreach (var game in games)
            {
                series.Add(new PieSeries
                {
                    Title = $"{game.Name}",
                    Values = new ChartValues<decimal> { game.Total },
                    DataLabels = false,
                    LabelPoint = label
                });
            }
            reportChart.Series = series;
        }

        private void refreshReports(object sender, EventArgs e)
        {
            if (gamesReportButton.Checked)
            {
                ReportType = ReportType.Games;
                ShowGameReport();
            }
            else
            {
                ReportType = ReportType.Orders;
                ShowOrderReport();
            }
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            ReportExportController.CreateTableOrders(dataGridView1);
        }
    }
    public enum ReportType
    {
        Orders,
        Games
    }
}
