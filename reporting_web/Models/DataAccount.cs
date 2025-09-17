namespace reporting_web.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DataAccount : DbContext
    {
        public DataAccount()
            : base("name=SqlDBDRC")
        {
        }

        public virtual DbSet<Account> Accounts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>()
                .Property(e => e.Account1)
                .IsUnicode(false);

            modelBuilder.Entity<Account>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Account>()
                .Property(e => e.Parent)
                .IsUnicode(false);

            modelBuilder.Entity<Account>()
                .Property(e => e.Type)
                .IsUnicode(false);

            modelBuilder.Entity<Account>()
                .Property(e => e.Description1)
                .IsUnicode(false);

            modelBuilder.Entity<Account>()
                .Property(e => e.Last_Opr)
                .IsUnicode(false);

            modelBuilder.Entity<Account>()
                .Property(e => e.AccGroup)
                .IsUnicode(false);
        }
    }
}
