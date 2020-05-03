using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controls
{
    public partial class Game: UserControl
    {
        public Image Image
        {
            get
            {
                return gameImage.Image;
            }
            set
            {
                this.gameImage.Image = value;
            }
        }

        public string GameName
        {
            get
            {
                return gameLabel.Text;
            }
            set
            {
                gameLabel.Text = value;
            }
        }
        public Game()
        {
            InitializeComponent();
        }
    }
}
