using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStoreApp.Controls
{
    public partial class DifficultyRating : UserControl
    {
        private int value;

        public int Value
        {
            get
            {
                return value;
            }
            set
            {
                if (value > 5 || value < 0) return;
                this.value = value;
                Invalidate();
            }
        }
        public DifficultyRating()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            int elementWidth = Width / 7;
            int currentStartingPoint = elementWidth * 2 / 5;
            for (int i = 0; i < 5; i++)
            {
                var currentRectangle = new Rectangle(currentStartingPoint, 0, elementWidth, Height-1);
                e.Graphics.DrawRectangle(new Pen(Color.Black, 1), currentRectangle);
                if (i <= Value - 1)
                {
                    e.Graphics.FillRectangle(new Pen(Color.Red, 1).Brush, currentRectangle);
                }
                currentStartingPoint += elementWidth * 7 / 5;
            }
        }
    }
}
