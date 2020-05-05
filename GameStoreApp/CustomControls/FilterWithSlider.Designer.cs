namespace GameStoreApp.Controls
{
    partial class FilterWithSlider
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.minText = new System.Windows.Forms.TextBox();
            this.maxText = new System.Windows.Forms.TextBox();
            this.Label = new System.Windows.Forms.TextBox();
            this.selectionRangeSlider1 = new GameStoreApp.SelectionRangeSlider();
            this.SuspendLayout();
            // 
            // minText
            // 
            this.minText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.minText.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minText.Location = new System.Drawing.Point(3, 88);
            this.minText.Name = "minText";
            this.minText.ReadOnly = true;
            this.minText.Size = new System.Drawing.Size(110, 28);
            this.minText.TabIndex = 1;
            this.minText.Text = "Lowest";
            this.minText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // maxText
            // 
            this.maxText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maxText.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maxText.Location = new System.Drawing.Point(241, 86);
            this.maxText.Name = "maxText";
            this.maxText.ReadOnly = true;
            this.maxText.Size = new System.Drawing.Size(110, 28);
            this.maxText.TabIndex = 2;
            this.maxText.Text = "Highest";
            this.maxText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label
            // 
            this.Label.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Label.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label.Location = new System.Drawing.Point(27, 7);
            this.Label.Name = "Label";
            this.Label.ReadOnly = true;
            this.Label.Size = new System.Drawing.Size(322, 37);
            this.Label.TabIndex = 3;
            this.Label.Text = "Here goes your label";
            this.Label.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // selectionRangeSlider1
            // 
            this.selectionRangeSlider1.Location = new System.Drawing.Point(54, 50);
            this.selectionRangeSlider1.Max = 100;
            this.selectionRangeSlider1.Min = 0;
            this.selectionRangeSlider1.Name = "selectionRangeSlider1";
            this.selectionRangeSlider1.SelectedMax = 100;
            this.selectionRangeSlider1.SelectedMin = 0;
            this.selectionRangeSlider1.Size = new System.Drawing.Size(258, 28);
            this.selectionRangeSlider1.TabIndex = 0;
            this.selectionRangeSlider1.Value = 50;
            this.selectionRangeSlider1.SelectionChanged += new System.EventHandler(this.selectionRangeSlider1_SelectionChanged);
            // 
            // FilterWithSlider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Label);
            this.Controls.Add(this.maxText);
            this.Controls.Add(this.minText);
            this.Controls.Add(this.selectionRangeSlider1);
            this.Name = "FilterWithSlider";
            this.Size = new System.Drawing.Size(352, 130);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SelectionRangeSlider selectionRangeSlider1;
        private System.Windows.Forms.TextBox minText;
        private System.Windows.Forms.TextBox maxText;
        private System.Windows.Forms.TextBox Label;
    }
}
