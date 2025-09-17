namespace reporting_web.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DataBranch : DbContext
    {
        public DataBranch()
            : base("name=SqlDBDRC")
        {
        }

        public virtual DbSet<Branch> Branches { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Branch>()
                .Property(e => e.Branch1)
                .IsUnicode(false);

            modelBuilder.Entity<Branch>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Branch>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<Branch>()
                .Property(e => e.RE_Account)
                .IsUnicode(false);

            modelBuilder.Entity<Branch>()
                .Property(e => e.PL_Account)
                .IsUnicode(false);

            modelBuilder.Entity<Branch>()
                .Property(e => e.GL_Account)
                .IsUnicode(false);

            modelBuilder.Entity<Branch>()
                .Property(e => e.TX_Account)
                .IsUnicode(false);

            modelBuilder.Entity<Branch>()
                .Property(e => e.DV_Account)
                .IsUnicode(false);

            modelBuilder.Entity<Branch>()
                .Property(e => e.IO_Account)
                .IsUnicode(false);

            modelBuilder.Entity<Branch>()
                .Property(e => e.Parent)
                .IsUnicode(false);

            modelBuilder.Entity<Branch>()
                .Property(e => e.PIC)
                .IsUnicode(false);

            modelBuilder.Entity<Branch>()
                .Property(e => e.PICTitle)
                .IsUnicode(false);

            modelBuilder.Entity<Branch>()
                .Property(e => e.CCode)
                .IsUnicode(false);

            modelBuilder.Entity<Branch>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<Branch>()
                .Property(e => e.ZipCode)
                .IsUnicode(false);

            modelBuilder.Entity<Branch>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<Branch>()
                .Property(e => e.Fax)
                .IsUnicode(false);

            modelBuilder.Entity<Branch>()
                .Property(e => e.TaxID)
                .IsUnicode(false);

            modelBuilder.Entity<Branch>()
                .Property(e => e.KPPID)
                .IsUnicode(false);

            modelBuilder.Entity<Branch>()
                .Property(e => e.KPP)
                .IsUnicode(false);

            modelBuilder.Entity<Branch>()
                .Property(e => e.Last_Opr)
                .IsUnicode(false);

            modelBuilder.Entity<Branch>()
                .Property(e => e.BAlias)
                .IsUnicode(false);

            modelBuilder.Entity<Branch>()
                .Property(e => e.SignerName)
                .IsUnicode(false);

            modelBuilder.Entity<Branch>()
                .Property(e => e.SignerTitle)
                .IsUnicode(false);

            modelBuilder.Entity<Branch>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Branch>()
                .Property(e => e.SignerName_1)
                .IsUnicode(false);

            modelBuilder.Entity<Branch>()
                .Property(e => e.SignerTitle_1)
                .IsUnicode(false);

            modelBuilder.Entity<Branch>()
                .Property(e => e.SignerName_2)
                .IsUnicode(false);

            modelBuilder.Entity<Branch>()
                .Property(e => e.SignerTitle_2)
                .IsUnicode(false);
            modelBuilder.Entity<Branch>()
                .Property(e => e.BranchGroup)
                .IsUnicode(false);
        }
    }
}
