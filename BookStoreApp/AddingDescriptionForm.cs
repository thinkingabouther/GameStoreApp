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
    public partial class AddingDescriptionForm : Form
    {
        public string Description
        {
            get
            {
                return descriptionTextBox.Text;
            }
            set
            {
                descriptionTextBox.Text = value;
            }
        }
        public AddingDescriptionForm(FormTypes formType)
        {
            InitializeComponent();
            if (formType == FormTypes.genre)
                labelTextBox.Text = $"Добавьте описание для жанра";
            else labelTextBox.Text = $"Добавьте описание для типа";
            descriptionTextBox.Focus();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (descriptionTextBox.Text != String.Empty)
                DialogResult = DialogResult.OK;
            else
            {
                MessageBox.Show("Ввдите описание!");
            }
        }
    }
}
