namespace GameStoreApp.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Orders_Games
    {
        public int ID { get; set; }

        public int Game_ID { get; set; }

        public int Order_ID { get; set; }

        public int Games_number { get; set; }

        public virtual Game Game { get; set; }

        public virtual Order Order { get; set; }
    }
}
