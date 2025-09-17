namespace reporting_web.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DataBranchUser : DbContext
    {
        public DataBranchUser()
            : base("name=SqlDBDRC")
        {
        }

        public virtual DbSet<vUserBranch> vUserBranches { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<vUserBranch>()
                .Property(e => e.UserId);

            modelBuilder.Entity<vUserBranch>()
                .Property(e => e.Branch)
                .IsUnicode(false);

            modelBuilder.Entity<vUserBranch>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<vUserBranch>()
                .Property(e => e.Token)
                .IsUnicode(false);
        }
    }
}
