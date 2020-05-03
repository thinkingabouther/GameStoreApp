namespace Controls
{
    partial class Game
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
            this.components = new System.ComponentModel.Container();
            this.gameImage = new System.Windows.Forms.PictureBox();
            this.gameLabel = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gameImage)).BeginInit();
            this.SuspendLayout();
            // 
            // gameImage
            // 
            this.gameImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gameImage.Location = new System.Drawing.Point(66, 40);
            this.gameImage.Name = "gameImage";
            this.gameImage.Size = new System.Drawing.Size(266, 246);
            this.gameImage.TabIndex = 0;
            this.gameImage.TabStop = false;
            // 
            // gameLabel
            // 
            this.gameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gameLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gameLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gameLabel.Location = new System.Drawing.Point(42, 312);
            this.gameLabel.Name = "gameLabel";
            this.gameLabel.ReadOnly = true;
            this.gameLabel.Size = new System.Drawing.Size(312, 37);
            this.gameLabel.TabIndex = 2;
            this.gameLabel.Text = "Here goes your name";
            this.gameLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gameLabel);
            this.Controls.Add(this.gameImage);
            this.Name = "Game";
            this.Size = new System.Drawing.Size(396, 376);
            ((System.ComponentModel.ISupportInitialize)(this.gameImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox gameImage;
        private System.Windows.Forms.TextBox gameLabel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}
