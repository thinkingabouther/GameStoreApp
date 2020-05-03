namespace DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Game")]
    public partial class Game
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Game()
        {
            Orders_Games = new HashSet<Orders_Games>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(200)]
        public string Description { get; set; }

        public int Author_ID { get; set; }

        public int Genre_ID { get; set; }

        public int Difficulty { get; set; }

        public int Type_ID { get; set; }

        public int Duration_ID { get; set; }

        public int Player_number_ID { get; set; }

        [Column(TypeName = "money")]
        public decimal Price { get; set; }

        public int Quantity { get; set; }

        [StringLength(50)]
        public string ImageID { get; set; }

        [StringLength(50)]

        public string Something { get; set; }

        public virtual Author Author { get; set; }

        public virtual Duration Duration { get; set; }

        public virtual Genre Genre { get; set; }

        public virtual Players_number Players_number { get; set; }

        public virtual Type Type { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Orders_Games> Orders_Games { get; set; }
    }
}
