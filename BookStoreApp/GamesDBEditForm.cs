using BookStoreApp.DB;
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
    public partial class GamesDBEditForm1 : Form
    {
        private Dictionary<int, string> columnNames = new Dictionary<int, string>()
        {
            { 1, "Name"},
            { 2, "Description"},
            { 3, "Price"},
            { 4, "Quantity"},
            { 5, "Author"},
            { 6, "minDuration"},
            { 7, "maxDuration"},
            { 8, "Genre"},
            { 9, "minPlayers"},
            { 10, "maxPlayers"},
            { 11, "Type"}
        };
        public GamesDBEditForm1()
        {
            InitializeComponent();
            DisplayGamesInfo();
        }

        void DisplayGamesInfo()
        {
            dataGridView1.Rows.Clear();
            var games = DBController.GetGamesParams();
            foreach(var game in games)
            {
                dataGridView1.Rows.Add(game.ID, game.Name, game.Description, game.Price,
                                       game.Quantity, game.Author, game.minDuration, game.maxDuration,
                                       game.Genre, game.minPlayers, game.maxPlayers, game.Type, game.Image != null? "Да" : "Нет");
            }
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            switch (e.ColumnIndex)
            {
                case 1: // name
                    break;
                case 2: // description
                    break;
                case 3: // price
                    bool flag = decimal.TryParse((string)dataGridView1[e.ColumnIndex, e.RowIndex].Value, out var newPrice);
                    if (!flag)
                    {
                        MessageBox.Show("Цена должна быть числом");
                        dataGridView1[e.ColumnIndex, e.RowIndex].Value = DBController.GetPropertyValue((int)dataGridView1[0, e.RowIndex].Value, columnNames[e.ColumnIndex]);
                        return;
                    };
                    break;
                case 4: // quantity
                    if (!CheckIntInput((string)dataGridView1[e.ColumnIndex, e.RowIndex].Value, "Количество"))
                    {
                        dataGridView1[e.ColumnIndex, e.RowIndex].Value = DBController.GetPropertyValue((int)dataGridView1[0, e.RowIndex].Value, columnNames[e.ColumnIndex]);
                        return;
                    }
                    break;
                case 5: // author
                    DBController.ChangeGameAuthor((int)dataGridView1[0, e.RowIndex].Value, (string)dataGridView1[e.ColumnIndex, e.RowIndex].Value);
                    DisplayGamesInfo();
                    return;
                case 6: // min duration
                    if (!CheckIntInput((string)dataGridView1[e.ColumnIndex, e.RowIndex].Value, "Длительность"))
                    {
                        dataGridView1[e.ColumnIndex, e.RowIndex].Value = DBController.GetPropertyValue((int)dataGridView1[0, e.RowIndex].Value, columnNames[e.ColumnIndex]);
                        return;
                    }
                    break;
                case 7: // max duration
                    if (!CheckIntInput((string)dataGridView1[e.ColumnIndex, e.RowIndex].Value, "Длительность"))
                    {
                        dataGridView1[e.ColumnIndex, e.RowIndex].Value = DBController.GetPropertyValue((int)dataGridView1[0, e.RowIndex].Value, columnNames[e.ColumnIndex]);
                        return;
                    }
                    break;
                case 8: // genre
                    string genreDescription = "";
                    var addGenreDescriptionForm = new AddingDescriptionForm(FormTypes.genre);
                    addGenreDescriptionForm.Description = DBController.GetGenreDescription((int)dataGridView1[0, e.RowIndex].Value);
                    if (addGenreDescriptionForm.ShowDialog() != DialogResult.OK)
                    {
                        dataGridView1[e.ColumnIndex, e.RowIndex].Value = DBController.GetPropertyValue((int)dataGridView1[0, e.RowIndex].Value, columnNames[e.ColumnIndex]);
                        return;
                    }
                    genreDescription = addGenreDescriptionForm.Description; 
                    DBController.ChangeGameGenre((int)dataGridView1[0, e.RowIndex].Value, (string)dataGridView1[e.ColumnIndex, e.RowIndex].Value, genreDescription);
                    break;
                case 9: // min players
                    if (!CheckIntInput((string)dataGridView1[e.ColumnIndex, e.RowIndex].Value, "Количество игроков"))
                    {
                        dataGridView1[e.ColumnIndex, e.RowIndex].Value = DBController.GetPropertyValue((int)dataGridView1[0, e.RowIndex].Value, columnNames[e.ColumnIndex]);
                        return;
                    }
                    break;
                case 10: // max players
                    if (!CheckIntInput((string)dataGridView1[e.ColumnIndex, e.RowIndex].Value, "Количество игроков"))
                    {
                        dataGridView1[e.ColumnIndex, e.RowIndex].Value = DBController.GetPropertyValue((int)dataGridView1[0, e.RowIndex].Value, columnNames[e.ColumnIndex]);
                        return;
                    }
                    break;
                case 11: // type
                    string typeDescription = "";
                    var addTypeDescriptionForm = new AddingDescriptionForm(FormTypes.type);
                    addTypeDescriptionForm.Description = DBController.GetTypeDescription((int)dataGridView1[0, e.RowIndex].Value);
                    if (addTypeDescriptionForm.ShowDialog() != DialogResult.OK)
                    {
                        dataGridView1[e.ColumnIndex, e.RowIndex].Value = DBController.GetPropertyValue((int)dataGridView1[0, e.RowIndex].Value, columnNames[e.ColumnIndex]);
                        return;
                    }
                    typeDescription = addTypeDescriptionForm.Description;
                    DBController.ChangeGameType((int)dataGridView1[0, e.RowIndex].Value, (string)dataGridView1[e.ColumnIndex, e.RowIndex].Value, typeDescription);
                    break;
            }
            var result = DBController.ChangeGameProperty(
                                    (int)dataGridView1[0, e.RowIndex].Value,
                                    columnNames[e.ColumnIndex], 
                                    (string)dataGridView1[e.ColumnIndex, e.RowIndex].Value);
            if (!result)
            {
                MessageBox.Show("Данное название уже есть в базе. Попробуйте другое");
                dataGridView1[e.ColumnIndex, e.RowIndex].Value = DBController.GetPropertyValue((int)dataGridView1[0, e.RowIndex].Value, columnNames[e.ColumnIndex]);
            }
            DisplayGamesInfo();
        }
        private bool CheckIntInput(string value, string propertyName)
        {
            if (!int.TryParse(value, out int result))
            {
                MessageBox.Show($"Проверьте данные. {propertyName} - целое число");
                return false;
            }
            return true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var addingGameForm = new AddingGameForm();
            if (addingGameForm.ShowDialog() == DialogResult.OK)
            {
                DisplayGamesInfo();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            int id = (int)dataGridView1[0, dataGridView1.SelectedCells[0].RowIndex].Value;
            DBController.RemoveGameByID(id);
            DisplayGamesInfo();
        }

        private void AddImageButton_Click(object sender, EventArgs e)
        {
            int id = (int)dataGridView1[0, dataGridView1.SelectedCells[0].RowIndex].Value;
            var fileDialog = new OpenFileDialog();
            fileDialog.Filter = @"Изображения (*.png; *.jpg)| *.png; *.jpg | Все файлы(*.*) | *.*";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                var filePath = fileDialog.FileName;
                ImageConverter converter = new ImageConverter();
                var image = (byte[])converter.ConvertTo(Bitmap.FromFile(filePath), typeof(byte[]));
                DBController.AddImageToGameByID(id, image);
                MessageBox.Show($"Изображение {filePath} добавлено!");
                DisplayGamesInfo();
            }
            
        }
    }
}
