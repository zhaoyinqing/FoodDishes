namespace Food
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Order
    {
        public int OrderID { get; set; }

        [StringLength(12)]
        public string Username { get; set; }

        public int FoodID { get; set; }

        [StringLength(20)]
        public string FoodName { get; set; }

        [StringLength(1)]
        public string Size { get; set; }

        [StringLength(1)]
        public string Chilli { get; set; }

        [StringLength(1)]
        public string MoreSalt { get; set; }

        [StringLength(1)]
        public string Pepper { get; set; }
    }
}
