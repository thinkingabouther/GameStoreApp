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
    public partial class AddingGameForm : Form
    {
        public GameParams Game = new GameParams();

        public AddingGameForm()
        {
            InitializeComponent();
            FillComboBoxes();
        }

        private void addGenreButton_Click(object sender, EventArgs e)
        {
            var addGenreForm = new AddingGenreOrTypeForm(FormTypes.genre);
            if (addGenreForm.ShowDialog() == DialogResult.OK)
            {
                DBController.AddGenreToDB(addGenreForm.NewName, addGenreForm.Description);
                genreBox.Items.Add(addGenreForm.NewName);
            }
        }

        private void addTypeButton_Click(object sender, EventArgs e)
        {
            var addTypeForm = new AddingGenreOrTypeForm(FormTypes.type);
            if (addTypeForm.ShowDialog() == DialogResult.OK)
            {
                DBController.AddGameTypeToDB(addTypeForm.NewName, addTypeForm.Description);
                typeBox.Items.Add(addTypeForm.NewName);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text == string.Empty)
            {
                MessageBox.Show("Введите название!");
                return;
            }
            if (descriptionTextBox.Text == string.Empty)
            {
                MessageBox.Show("Введите описание!");
                return;
            }
            if (authorBox.Text == string.Empty)
            {
                MessageBox.Show("Введите издательство!");
                return;
            }
            if (playersMinBox.Value > playersMaxBox.Value)
            {
                MessageBox.Show("Минимальное количество игроков должно быть меньше максимального!");
                return;
            }
            if (durationMinBox.Value > durationMaxBox.Value)
            {
                MessageBox.Show("Минимальная длительность должна быть меньше максимальной!");
                return;
            }
            Game.Name = nameTextBox.Text;
            Game.Description = descriptionTextBox.Text;
            Game.Price = priceBox.Value;
            Game.Difficulty = (int)difficultyBox.Value;
            Game.Quantity = (int)quantityBox.Value;
            Game.Author = authorBox.SelectedItem.ToString();
            Game.minPlayers = (int)playersMinBox.Value;
            Game.maxPlayers = (int)playersMaxBox.Value;
            Game.maxDuration = (int)durationMinBox.Value;
            Game.minDuration = (int)durationMaxBox.Value;
            Game.Genre = genreBox.SelectedItem.ToString();
            Game.Type = typeBox.SelectedItem.ToString();
            if (DBController.AddGameToDB(Game))
                DialogResult = DialogResult.OK;
            else
            {
                MessageBox.Show("Игра с таким именем уже есть в базе данных");
                return;
            }
        }

        private void addAuthorButton_Click(object sender, EventArgs e)
        {
            var addingAuthorForm = new AddingAuthorForm();
            if (addingAuthorForm.ShowDialog() == DialogResult.OK)
            {
                DBController.AddAuthorToDB(addingAuthorForm.Author);
                authorBox.Items.Add(addingAuthorForm.Author);
            }
        }

        void FillComboBoxes()
        {
            typeBox.Items.Clear();
            genreBox.Items.Clear();
            authorBox.Items.Clear();
            var games = DBController.GetGamesParams();
            var genres = (from game in games
                          select game.Genre).Distinct();
            foreach(var genre in genres)
            {
                genreBox.Items.Add(genre);
            }
            genreBox.SelectedIndex = 0;
            var types = (from game in games
                         select game.Type).Distinct();
            foreach(var type in types)
            {
                typeBox.Items.Add(type);
            }
            typeBox.SelectedIndex = 1;
            var authors = (from game in games
                           select game.Author).Distinct();
            foreach(var author in authors)
            {
                authorBox.Items.Add(author);
            }
            authorBox.SelectedIndex = 1;

        }
    }
}
