namespace BookStoreApp.DB
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class GameStoreDBContext : DbContext
    {
        public GameStoreDBContext()
            : base("name=GameStoreDBContext")
        {
        }

        public virtual DbSet<Author> Author { get; set; }
        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<Duration> Duration { get; set; }
        public virtual DbSet<Game> Game { get; set; }
        public virtual DbSet<Genre> Genre { get; set; }
        public virtual DbSet<Order> Order { get; set; }
        public virtual DbSet<Orders_Games> Orders_Games { get; set; }
        public virtual DbSet<Players_number> Players_number { get; set; }
        public virtual DbSet<Type> Type { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>()
                .HasMany(e => e.Game)
                .WithRequired(e => e.Author)
                .HasForeignKey(e => e.Author_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Client>()
                .HasMany(e => e.Order)
                .WithRequired(e => e.Client)
                .HasForeignKey(e => e.Client_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Duration>()
                .HasMany(e => e.Game)
                .WithRequired(e => e.Duration)
                .HasForeignKey(e => e.Duration_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Game>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Game>()
                .HasMany(e => e.Orders_Games)
                .WithRequired(e => e.Game)
                .HasForeignKey(e => e.Game_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Genre>()
                .HasMany(e => e.Game)
                .WithRequired(e => e.Genre)
                .HasForeignKey(e => e.Genre_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Order>()
                .HasMany(e => e.Orders_Games)
                .WithRequired(e => e.Order)
                .HasForeignKey(e => e.Order_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Players_number>()
                .HasMany(e => e.Game)
                .WithRequired(e => e.Players_number)
                .HasForeignKey(e => e.Player_number_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Type>()
                .HasMany(e => e.Game)
                .WithRequired(e => e.Type)
                .HasForeignKey(e => e.Type_ID)
                .WillCascadeOnDelete(false);
        }
    }
}
