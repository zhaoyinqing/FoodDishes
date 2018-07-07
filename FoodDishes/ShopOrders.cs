namespace Food
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;


    public partial class ShopOrders : DbContext
    {
        public ShopOrders()
            : base("name=ShopOrders")
        {
        }

        public virtual DbSet<Food> Foods { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Size> Sizes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Food>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Order>()
                .Property(e => e.Username)
                .IsUnicode(false);

            modelBuilder.Entity<Order>()
                .Property(e => e.FoodName)
                .IsUnicode(false);

            modelBuilder.Entity<Order>()
                .Property(e => e.Size)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Order>()
                .Property(e => e.Chilli)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Order>()
                .Property(e => e.MoreSalt)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Order>()
                .Property(e => e.Pepper)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Size>()
                .Property(e => e.Description)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}
