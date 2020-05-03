using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStoreApp
{
    public partial class LoginWindow : Form
    {
        string saltValue = "abcd";
        Dictionary<string, string> users_hash = new Dictionary<string, string>
        {
            { "Администратор", "73N4Hv/Fd0EA+H/i9DekNQ==" }, // 1234
            { "Владелец", "oEc0O/S6Zf1MTvlZbJKWDA==" } // 12345
        };

        string user;
        public LoginWindow(string user)
        {
            InitializeComponent();
            this.user = user;
            userTextBox.Text = $"Введите ключ доступа для пользователя \"{user}\"";
            passwordTextBox.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string currentHash = GetHash(passwordTextBox.Text, saltValue);
            if (users_hash[user] == currentHash) DialogResult = DialogResult.OK;
            else
            {
                MessageBox.Show("Неверный пароль! Попробуйте снова");
            };
        }

        static string GetHash(string password, string salt)
        {
            MD5 md5 = new MD5CryptoServiceProvider(); 
            byte[] digest = md5.ComputeHash(Encoding.UTF8.GetBytes(password + salt));
            string base64digest = Convert.ToBase64String(digest, 0, digest.Length); 
            return base64digest;
        }

    }
}
