using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BookStoreApp.DBController;

namespace BookStoreApp
{
    class ReportExportController
    {
        public static void CreateTableOrders(DataGridView dataGridView)
        {
            if (dataGridView.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Excel.Application xcelApp = new Microsoft.Office.Interop.Excel.Application();
                xcelApp.Application.Workbooks.Add(Type.Missing);

                for (int i = 1; i < dataGridView.Columns.Count + 1; i++)
                {
                    xcelApp.Cells[1, i] = dataGridView.Columns[i - 1].HeaderText;
                }

                for (int i = 0; i < dataGridView.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView.Columns.Count; j++)
                    {
                        xcelApp.Cells[i + 2, j + 1] = dataGridView.Rows[i].Cells[j].Value;
                    }
                }
                xcelApp.Columns.AutoFit();
                xcelApp.Visible = true;
            }
        }

        public static void CreateReceipt(OrderParams order)
        {
            var currentClient = DBController.GetClientByOrderID(order.ID);
            var wordApp = new Microsoft.Office.Interop.Word.Application();
            Microsoft.Office.Interop.Word.Document doc = wordApp.Documents.Add();
            doc.Content.Text = $"Клиент: {currentClient.Name}\nАдрес электронной почты: {currentClient.Email}\n\nЗаказ:\n";
            decimal sum = 0;
            foreach(var game in order.games)
            {
                var currentSum = game.Quantity * game.Price;
                doc.Content.Text += $"{game.Name}, цена - {game.Price}₽, количество - {game.Quantity}, Итог - {currentSum}₽\n";
                sum += currentSum;
            }
            doc.Content.Text += $"\nОбщий итог - {sum}₽, ID заказа - {order.ID}";
            wordApp.Visible = true;
        }
    }
}
