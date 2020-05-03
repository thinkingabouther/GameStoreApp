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
    public partial class AddingGenreOrTypeForm : Form
    {
        public FormTypes FormType;

        public string NewName
        {
            get
            {
                return nameBox.Text;
            }
        }

        public string Description
        {
            get
            {
                return descriptionBox.Text;
            }
        }
        public AddingGenreOrTypeForm(FormTypes formType)
        {
            InitializeComponent();
            if (formType == FormTypes.genre)
                label1.Text = $"Введите информацию о новом жанре";
            else label1.Text = $"Введите информацию о новом типе";
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (nameBox.Text != String.Empty && descriptionBox.Text != String.Empty) 
            {
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Введите описание!");
            }
        }
    }
    public enum FormTypes
    {
        genre,
        type
    }
}
