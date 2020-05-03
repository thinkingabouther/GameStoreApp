namespace BookStoreApp
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainLayout = new System.Windows.Forms.TableLayoutPanel();
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.GenreComboBox = new System.Windows.Forms.ComboBox();
            this.GenreLabel = new System.Windows.Forms.Label();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.TypeComboBox = new System.Windows.Forms.ComboBox();
            this.refreshFiltersButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CartButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.обновлениеСкладаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчётыПоПродажамToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.startsWithTextBox = new System.Windows.Forms.TextBox();
            this.applyFiltersButton = new System.Windows.Forms.Button();
            this.DurationFilter = new BookStoreApp.Controls.FilterWithSlider();
            this.DifficultyFilter = new BookStoreApp.Controls.FilterWithSlider();
            this.PlayersNumberFilter = new BookStoreApp.Controls.FilterWithSlider();
            this.PriceFilter = new BookStoreApp.Controls.FilterWithSlider();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainLayout
            // 
            this.MainLayout.AutoScroll = true;
            this.MainLayout.AutoSize = true;
            this.MainLayout.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.MainLayout.ColumnCount = 2;
            this.MainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MainLayout.Location = new System.Drawing.Point(439, 154);
            this.MainLayout.MaximumSize = new System.Drawing.Size(0, 800);
            this.MainLayout.MinimumSize = new System.Drawing.Size(884, 0);
            this.MainLayout.Name = "MainLayout";
            this.MainLayout.RowCount = 1;
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 115F));
            this.MainLayout.Size = new System.Drawing.Size(884, 116);
            this.MainLayout.TabIndex = 1;
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // GenreComboBox
            // 
            this.GenreComboBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GenreComboBox.FormattingEnabled = true;
            this.GenreComboBox.Location = new System.Drawing.Point(45, 765);
            this.GenreComboBox.Name = "GenreComboBox";
            this.GenreComboBox.Size = new System.Drawing.Size(322, 44);
            this.GenreComboBox.TabIndex = 6;
            // 
            // GenreLabel
            // 
            this.GenreLabel.AutoSize = true;
            this.GenreLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GenreLabel.Location = new System.Drawing.Point(150, 723);
            this.GenreLabel.Name = "GenreLabel";
            this.GenreLabel.Size = new System.Drawing.Size(97, 36);
            this.GenreLabel.TabIndex = 7;
            this.GenreLabel.Text = "Жанр";
            // 
            // TypeLabel
            // 
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TypeLabel.Location = new System.Drawing.Point(121, 829);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(147, 36);
            this.TypeLabel.TabIndex = 9;
            this.TypeLabel.Text = "Тип игры";
            // 
            // TypeComboBox
            // 
            this.TypeComboBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TypeComboBox.FormattingEnabled = true;
            this.TypeComboBox.Location = new System.Drawing.Point(45, 871);
            this.TypeComboBox.Name = "TypeComboBox";
            this.TypeComboBox.Size = new System.Drawing.Size(322, 44);
            this.TypeComboBox.TabIndex = 8;
            // 
            // refreshFiltersButton
            // 
            this.refreshFiltersButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshFiltersButton.Location = new System.Drawing.Point(102, 1034);
            this.refreshFiltersButton.Name = "refreshFiltersButton";
            this.refreshFiltersButton.Size = new System.Drawing.Size(197, 60);
            this.refreshFiltersButton.TabIndex = 13;
            this.refreshFiltersButton.Text = "Очистить";
            this.refreshFiltersButton.UseVisualStyleBackColor = true;
            this.refreshFiltersButton.Click += new System.EventHandler(this.refreshFiltersButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(157, 667);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 24);
            this.label1.TabIndex = 15;
            this.label1.Text = "Минут";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(154, 284);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 24);
            this.label2.TabIndex = 16;
            this.label2.Text = "Рублей";
            // 
            // CartButton
            // 
            this.CartButton.Enabled = false;
            this.CartButton.Font = new System.Drawing.Font("Arial", 16F);
            this.CartButton.Location = new System.Drawing.Point(968, 22);
            this.CartButton.Name = "CartButton";
            this.CartButton.Size = new System.Drawing.Size(355, 88);
            this.CartButton.TabIndex = 18;
            this.CartButton.Text = "Корзина";
            this.CartButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CartButton.UseVisualStyleBackColor = true;
            this.CartButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(978, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.обновлениеСкладаToolStripMenuItem,
            this.отчётыПоПродажамToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1416, 40);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // обновлениеСкладаToolStripMenuItem
            // 
            this.обновлениеСкладаToolStripMenuItem.Name = "обновлениеСкладаToolStripMenuItem";
            this.обновлениеСкладаToolStripMenuItem.Size = new System.Drawing.Size(255, 36);
            this.обновлениеСкладаToolStripMenuItem.Text = "Обновление склада";
            this.обновлениеСкладаToolStripMenuItem.Click += new System.EventHandler(this.обновлениеСкладаToolStripMenuItem_Click);
            // 
            // отчётыПоПродажамToolStripMenuItem
            // 
            this.отчётыПоПродажамToolStripMenuItem.Name = "отчётыПоПродажамToolStripMenuItem";
            this.отчётыПоПродажамToolStripMenuItem.Size = new System.Drawing.Size(273, 36);
            this.отчётыПоПродажамToolStripMenuItem.Text = "Отчёты по продажам";
            this.отчётыПоПродажамToolStripMenuItem.Click += new System.EventHandler(this.отчётыПоПродажамToolStripMenuItem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(92, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 36);
            this.label3.TabIndex = 21;
            this.label3.Text = "По названию";
            // 
            // startsWithTextBox
            // 
            this.startsWithTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startsWithTextBox.Location = new System.Drawing.Point(63, 128);
            this.startsWithTextBox.Name = "startsWithTextBox";
            this.startsWithTextBox.Size = new System.Drawing.Size(266, 44);
            this.startsWithTextBox.TabIndex = 22;
            this.startsWithTextBox.TextChanged += new System.EventHandler(this.FilterChanged);
            // 
            // applyFiltersButton
            // 
            this.applyFiltersButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.applyFiltersButton.Location = new System.Drawing.Point(102, 954);
            this.applyFiltersButton.Name = "applyFiltersButton";
            this.applyFiltersButton.Size = new System.Drawing.Size(197, 60);
            this.applyFiltersButton.TabIndex = 23;
            this.applyFiltersButton.Text = "Применить";
            this.applyFiltersButton.UseVisualStyleBackColor = true;
            this.applyFiltersButton.Click += new System.EventHandler(this.FilterChanged);
            // 
            // DurationFilter
            // 
            this.DurationFilter.FilterLabel = "Длительность";
            this.DurationFilter.Location = new System.Drawing.Point(12, 579);
            this.DurationFilter.MaxValue = 180;
            this.DurationFilter.MinValue = 15;
            this.DurationFilter.Name = "DurationFilter";
            this.DurationFilter.Size = new System.Drawing.Size(382, 130);
            this.DurationFilter.TabIndex = 14;
            // 
            // DifficultyFilter
            // 
            this.DifficultyFilter.FilterLabel = "Сложность игры";
            this.DifficultyFilter.Location = new System.Drawing.Point(12, 457);
            this.DifficultyFilter.MaxValue = 5;
            this.DifficultyFilter.MinValue = 1;
            this.DifficultyFilter.Name = "DifficultyFilter";
            this.DifficultyFilter.Size = new System.Drawing.Size(382, 130);
            this.DifficultyFilter.TabIndex = 12;
            // 
            // PlayersNumberFilter
            // 
            this.PlayersNumberFilter.FilterLabel = "Количество игроков";
            this.PlayersNumberFilter.Location = new System.Drawing.Point(12, 332);
            this.PlayersNumberFilter.MaxValue = 20;
            this.PlayersNumberFilter.MinValue = 1;
            this.PlayersNumberFilter.Name = "PlayersNumberFilter";
            this.PlayersNumberFilter.Size = new System.Drawing.Size(382, 130);
            this.PlayersNumberFilter.TabIndex = 11;
            // 
            // PriceFilter
            // 
            this.PriceFilter.FilterLabel = "Цена";
            this.PriceFilter.Location = new System.Drawing.Point(12, 196);
            this.PriceFilter.MaxValue = 1000;
            this.PriceFilter.MinValue = 500;
            this.PriceFilter.Name = "PriceFilter";
            this.PriceFilter.Size = new System.Drawing.Size(382, 130);
            this.PriceFilter.TabIndex = 10;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1416, 1129);
            this.Controls.Add(this.applyFiltersButton);
            this.Controls.Add(this.startsWithTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CartButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DurationFilter);
            this.Controls.Add(this.refreshFiltersButton);
            this.Controls.Add(this.DifficultyFilter);
            this.Controls.Add(this.PlayersNumberFilter);
            this.Controls.Add(this.PriceFilter);
            this.Controls.Add(this.TypeLabel);
            this.Controls.Add(this.TypeComboBox);
            this.Controls.Add(this.GenreLabel);
            this.Controls.Add(this.GenreComboBox);
            this.Controls.Add(this.MainLayout);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "GameStoreApp";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainLayout;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
        private System.Windows.Forms.ComboBox GenreComboBox;
        private System.Windows.Forms.Label GenreLabel;
        private System.Windows.Forms.Label TypeLabel;
        private System.Windows.Forms.ComboBox TypeComboBox;
        private Controls.FilterWithSlider PriceFilter;
        private Controls.FilterWithSlider PlayersNumberFilter;
        private Controls.FilterWithSlider DifficultyFilter;
        private System.Windows.Forms.Button refreshFiltersButton;
        private Controls.FilterWithSlider DurationFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CartButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem обновлениеСкладаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчётыПоПродажамToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox startsWithTextBox;
        private System.Windows.Forms.Button applyFiltersButton;
    }
}

