namespace BookStoreApp
{
    partial class GameCatalogControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameCatalogControl));
            this.GameTextBox = new System.Windows.Forms.TextBox();
            this.DurationTextBox = new System.Windows.Forms.TextBox();
            this.PlayersNumberTextBox = new System.Windows.Forms.TextBox();
            this.DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.BuyButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DurationPictureBox = new System.Windows.Forms.PictureBox();
            this.PlayersPictureBox = new System.Windows.Forms.PictureBox();
            this.GameImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DurationPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayersPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GameImage)).BeginInit();
            this.SuspendLayout();
            // 
            // GameTextBox
            // 
            this.GameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GameTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GameTextBox.Location = new System.Drawing.Point(20, 380);
            this.GameTextBox.Name = "GameTextBox";
            this.GameTextBox.ReadOnly = true;
            this.GameTextBox.Size = new System.Drawing.Size(376, 37);
            this.GameTextBox.TabIndex = 0;
            this.GameTextBox.Text = "Here goes your name";
            this.GameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DurationTextBox
            // 
            this.DurationTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DurationTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DurationTextBox.Location = new System.Drawing.Point(79, 423);
            this.DurationTextBox.Name = "DurationTextBox";
            this.DurationTextBox.ReadOnly = true;
            this.DurationTextBox.Size = new System.Drawing.Size(124, 37);
            this.DurationTextBox.TabIndex = 1;
            this.DurationTextBox.Text = "15-20";
            this.DurationTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DurationTextBox.Visible = false;
            // 
            // PlayersNumberTextBox
            // 
            this.PlayersNumberTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PlayersNumberTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlayersNumberTextBox.Location = new System.Drawing.Point(262, 423);
            this.PlayersNumberTextBox.Name = "PlayersNumberTextBox";
            this.PlayersNumberTextBox.ReadOnly = true;
            this.PlayersNumberTextBox.Size = new System.Drawing.Size(93, 37);
            this.PlayersNumberTextBox.TabIndex = 2;
            this.PlayersNumberTextBox.Text = "3-5";
            this.PlayersNumberTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PlayersNumberTextBox.Visible = false;
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DescriptionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DescriptionTextBox.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DescriptionTextBox.ForeColor = System.Drawing.Color.Silver;
            this.DescriptionTextBox.Location = new System.Drawing.Point(20, 416);
            this.DescriptionTextBox.Multiline = true;
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.ReadOnly = true;
            this.DescriptionTextBox.Size = new System.Drawing.Size(376, 59);
            this.DescriptionTextBox.TabIndex = 5;
            this.DescriptionTextBox.Text = "Here goes your description";
            this.DescriptionTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BuyButton
            // 
            this.BuyButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BuyButton.Location = new System.Drawing.Point(60, 481);
            this.BuyButton.Name = "BuyButton";
            this.BuyButton.Size = new System.Drawing.Size(286, 70);
            this.BuyButton.TabIndex = 6;
            this.BuyButton.Text = "Price";
            this.BuyButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BuyButton.UseVisualStyleBackColor = true;
            this.BuyButton.Click += new System.EventHandler(this.BuyButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(68, 488);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // DurationPictureBox
            // 
            this.DurationPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("DurationPictureBox.Image")));
            this.DurationPictureBox.Location = new System.Drawing.Point(24, 416);
            this.DurationPictureBox.Name = "DurationPictureBox";
            this.DurationPictureBox.Size = new System.Drawing.Size(50, 50);
            this.DurationPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DurationPictureBox.TabIndex = 4;
            this.DurationPictureBox.TabStop = false;
            this.DurationPictureBox.Visible = false;
            // 
            // PlayersPictureBox
            // 
            this.PlayersPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("PlayersPictureBox.Image")));
            this.PlayersPictureBox.Location = new System.Drawing.Point(210, 416);
            this.PlayersPictureBox.Name = "PlayersPictureBox";
            this.PlayersPictureBox.Size = new System.Drawing.Size(50, 50);
            this.PlayersPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PlayersPictureBox.TabIndex = 3;
            this.PlayersPictureBox.TabStop = false;
            this.PlayersPictureBox.Visible = false;
            // 
            // GameImage
            // 
            this.GameImage.Image = global::BookStoreApp.Properties.Resources.Bang;
            this.GameImage.Location = new System.Drawing.Point(20, 13);
            this.GameImage.Name = "GameImage";
            this.GameImage.Size = new System.Drawing.Size(376, 354);
            this.GameImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GameImage.TabIndex = 0;
            this.GameImage.TabStop = false;
            // 
            // GameCatalogControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DescriptionTextBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BuyButton);
            this.Controls.Add(this.DurationPictureBox);
            this.Controls.Add(this.PlayersPictureBox);
            this.Controls.Add(this.PlayersNumberTextBox);
            this.Controls.Add(this.DurationTextBox);
            this.Controls.Add(this.GameImage);
            this.Controls.Add(this.GameTextBox);
            this.Name = "GameCatalogControl";
            this.Size = new System.Drawing.Size(422, 572);
            this.Click += new System.EventHandler(this.GameCatalogControl_Click);
            this.MouseEnter += new System.EventHandler(this.GameControl_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.GameControl_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DurationPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayersPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GameImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox GameTextBox;
        private System.Windows.Forms.PictureBox GameImage;
        private System.Windows.Forms.TextBox DurationTextBox;
        private System.Windows.Forms.TextBox PlayersNumberTextBox;
        private System.Windows.Forms.PictureBox PlayersPictureBox;
        private System.Windows.Forms.PictureBox DurationPictureBox;
        private System.Windows.Forms.TextBox DescriptionTextBox;
        private System.Windows.Forms.Button BuyButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
