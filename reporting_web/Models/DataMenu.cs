namespace reporting_web.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DataMenu : DbContext
    {
        public DataMenu()
            : base("name=SqlDBDRC")
        {
        }

        public virtual DbSet<Menu> Menus { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {            
            modelBuilder.Entity<Menu>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<Menu>()
                .Property(e => e.UrlMenu)
                .IsUnicode(false);
            
        }
    }
}
