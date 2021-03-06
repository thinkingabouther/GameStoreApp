﻿using System;
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
    public partial class AddingAuthorForm : Form
    {
        public string Author
        {
            get
            {
                return authorTextBox.Text;
            }
        }
        public AddingAuthorForm()
        {
            InitializeComponent();
        }

        private void AddAuthorButton_Click(object sender, EventArgs e)
        {
            if (authorTextBox.Text == string.Empty)
            {
                MessageBox.Show("Ввдите название издательства!");
                return;
            }
            DialogResult = DialogResult.OK;
        }
    }
}
