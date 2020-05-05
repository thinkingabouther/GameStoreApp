using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameStoreApp.Controls
{
    public partial class FilterWithSlider : UserControl
    {

        public string FilterLabel
        {
            get
            {
                return Label.Text;
            }
            set
            {
                Label.Text = value;
            }
        }

        public int SelectedMaxValue
        {
            get
            {
                return selectionRangeSlider1.SelectedMax;
            }
        }

        public int SelectedMinValue
        {
            get
            {
                return selectionRangeSlider1.SelectedMin;
            }
        }
        public int MaxValue
        {
            get
            {
                return selectionRangeSlider1.Max;
            }
            set
            {
                selectionRangeSlider1.Max = value;
                selectionRangeSlider1.SelectedMax = value;
            }
        }

        public int MinValue
        {
            get
            {
                return selectionRangeSlider1.Min;
            }
            set
            {
                selectionRangeSlider1.Min = value;
                selectionRangeSlider1.SelectedMin = value;
            }
        }
        public FilterWithSlider()
        {
            InitializeComponent();
            maxText.Text = selectionRangeSlider1.SelectedMax.ToString();
            minText.Text = selectionRangeSlider1.SelectedMin.ToString();
        }

        private void selectionRangeSlider1_SelectionChanged(object sender, EventArgs e)
        {
            maxText.Text = selectionRangeSlider1.SelectedMax.ToString();
            minText.Text = selectionRangeSlider1.SelectedMin.ToString();
            OnSelectionChanged(this, FilterLabel);

        }

        public delegate void SelectionChanged(object sender, string categoryName);

        public event SelectionChanged SelectionChangedEvent;

        public void OnSelectionChanged(object sender, string categoryName)
        {
            SelectionChangedEvent?.Invoke(sender, categoryName);
        }
    }
}
