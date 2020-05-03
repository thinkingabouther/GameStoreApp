namespace BookStoreApp
{
    partial class GamesDBEditForm1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.AddGameButton = new System.Windows.Forms.Button();
            this.DeleteGameButton = new System.Windows.Forms.Button();
            this.AddImageButton = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GameName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minDuration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxDuration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minPlayers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxPlayers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Image = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gameBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(527, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Состояние склада";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.GameName,
            this.Description,
            this.Price,
            this.Quantity,
            this.Author,
            this.minDuration,
            this.maxDuration,
            this.Genre,
            this.minPlayers,
            this.maxPlayers,
            this.Type,
            this.Image});
            this.dataGridView1.Location = new System.Drawing.Point(-3, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(1280, 546);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            // 
            // AddGameButton
            // 
            this.AddGameButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddGameButton.Location = new System.Drawing.Point(472, 691);
            this.AddGameButton.Name = "AddGameButton";
            this.AddGameButton.Size = new System.Drawing.Size(320, 97);
            this.AddGameButton.TabIndex = 2;
            this.AddGameButton.Text = "Добавить игру";
            this.AddGameButton.UseVisualStyleBackColor = true;
            this.AddGameButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // DeleteGameButton
            // 
            this.DeleteGameButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteGameButton.Location = new System.Drawing.Point(854, 691);
            this.DeleteGameButton.Name = "DeleteGameButton";
            this.DeleteGameButton.Size = new System.Drawing.Size(320, 97);
            this.DeleteGameButton.TabIndex = 3;
            this.DeleteGameButton.Text = "Удалить игру";
            this.DeleteGameButton.UseVisualStyleBackColor = true;
            this.DeleteGameButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // AddImageButton
            // 
            this.AddImageButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddImageButton.Location = new System.Drawing.Point(94, 691);
            this.AddImageButton.Name = "AddImageButton";
            this.AddImageButton.Size = new System.Drawing.Size(320, 97);
            this.AddImageButton.TabIndex = 4;
            this.AddImageButton.Text = "Добавить изображение";
            this.AddImageButton.UseVisualStyleBackColor = true;
            this.AddImageButton.Click += new System.EventHandler(this.AddImageButton_Click);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 10;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 50;
            // 
            // GameName
            // 
            this.GameName.HeaderText = "Название";
            this.GameName.MinimumWidth = 10;
            this.GameName.Name = "GameName";
            this.GameName.Width = 200;
            // 
            // Description
            // 
            this.Description.HeaderText = "Описание";
            this.Description.MinimumWidth = 10;
            this.Description.Name = "Description";
            this.Description.Width = 200;
            // 
            // Price
            // 
            this.Price.HeaderText = "Цена";
            this.Price.MinimumWidth = 10;
            this.Price.Name = "Price";
            this.Price.Width = 200;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Количество";
            this.Quantity.MinimumWidth = 10;
            this.Quantity.Name = "Quantity";
            this.Quantity.Width = 200;
            // 
            // Author
            // 
            this.Author.HeaderText = "Издатель";
            this.Author.MinimumWidth = 10;
            this.Author.Name = "Author";
            this.Author.Width = 200;
            // 
            // minDuration
            // 
            this.minDuration.HeaderText = "Мин. длит.";
            this.minDuration.MinimumWidth = 10;
            this.minDuration.Name = "minDuration";
            this.minDuration.Width = 200;
            // 
            // maxDuration
            // 
            this.maxDuration.HeaderText = "Макс. длит.";
            this.maxDuration.MinimumWidth = 10;
            this.maxDuration.Name = "maxDuration";
            this.maxDuration.Width = 200;
            // 
            // Genre
            // 
            this.Genre.HeaderText = "Жанр";
            this.Genre.MinimumWidth = 10;
            this.Genre.Name = "Genre";
            this.Genre.Width = 200;
            // 
            // minPlayers
            // 
            this.minPlayers.HeaderText = "Мин. игроки";
            this.minPlayers.MinimumWidth = 10;
            this.minPlayers.Name = "minPlayers";
            this.minPlayers.Width = 200;
            // 
            // maxPlayers
            // 
            this.maxPlayers.HeaderText = "Макс. игроки";
            this.maxPlayers.MinimumWidth = 10;
            this.maxPlayers.Name = "maxPlayers";
            this.maxPlayers.Width = 200;
            // 
            // Type
            // 
            this.Type.HeaderText = "Тип";
            this.Type.MinimumWidth = 10;
            this.Type.Name = "Type";
            this.Type.Width = 200;
            // 
            // Image
            // 
            this.Image.HeaderText = "Изображение";
            this.Image.MinimumWidth = 10;
            this.Image.Name = "Image";
            this.Image.ReadOnly = true;
            this.Image.Width = 200;
            // 
            // gameBindingSource
            // 
            this.gameBindingSource.DataSource = typeof(BookStoreApp.DB.Game);
            // 
            // GamesDBEditForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 842);
            this.Controls.Add(this.AddImageButton);
            this.Controls.Add(this.DeleteGameButton);
            this.Controls.Add(this.AddGameButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GamesDBEditForm1";
            this.Text = "GamesDBEditForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource gameBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button AddGameButton;
        private System.Windows.Forms.Button DeleteGameButton;
        private System.Windows.Forms.Button AddImageButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn GameName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Author;
        private System.Windows.Forms.DataGridViewTextBoxColumn minDuration;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxDuration;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genre;
        private System.Windows.Forms.DataGridViewTextBoxColumn minPlayers;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxPlayers;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Image;
    }
}