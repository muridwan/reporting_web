namespace reporting_web.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DatasysInfo : DbContext
    {
        public DatasysInfo()
            : base("name=SqlDBDRC")
        {
        }

        public virtual DbSet<sysInfo> sysInfos { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<sysInfo>()
                .Property(e => e.Type)
                .IsUnicode(false);
            modelBuilder.Entity<sysInfo>()
                .Property(e => e.SDate);
            modelBuilder.Entity<sysInfo>()
                .Property(e => e.EDate);
            modelBuilder.Entity<sysInfo>()
                .Property(e => e.Description)
                .IsUnicode(false);
            modelBuilder.Entity<sysInfo>()
                .Property(e => e.DateExecute);
            modelBuilder.Entity<sysInfo>()
                .Property(e => e.DateComplete);
            modelBuilder.Entity<sysInfo>()
                .Property(e => e.Status)
                .IsUnicode(false);
        }
    }
}
