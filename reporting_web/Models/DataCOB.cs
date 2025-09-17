namespace reporting_web.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DataCOB : DbContext
    {
        public DataCOB()
            : base("name=SqlDBDRC")
        {
        }

        public virtual DbSet<COB> COBs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<COB>()
                .Property(e => e.COB1)
                .IsUnicode(false);

            modelBuilder.Entity<COB>()
                .Property(e => e.DESCRIPTION)
                .IsUnicode(false);

            modelBuilder.Entity<COB>()
                .Property(e => e.FLDID1)
                .IsUnicode(false);

            modelBuilder.Entity<COB>()
                .Property(e => e.FLDTAG1)
                .IsUnicode(false);

            modelBuilder.Entity<COB>()
                .Property(e => e.FLDTAGA1)
                .IsUnicode(false);

            modelBuilder.Entity<COB>()
                .Property(e => e.FLDID2)
                .IsUnicode(false);

            modelBuilder.Entity<COB>()
                .Property(e => e.FLDTAG2)
                .IsUnicode(false);

            modelBuilder.Entity<COB>()
                .Property(e => e.FLDTAGA2)
                .IsUnicode(false);

            modelBuilder.Entity<COB>()
                .Property(e => e.FLDID3)
                .IsUnicode(false);

            modelBuilder.Entity<COB>()
                .Property(e => e.FLDTAG3)
                .IsUnicode(false);

            modelBuilder.Entity<COB>()
                .Property(e => e.FLDTAGA3)
                .IsUnicode(false);

            modelBuilder.Entity<COB>()
                .Property(e => e.FLDID4)
                .IsUnicode(false);

            modelBuilder.Entity<COB>()
                .Property(e => e.FLDTAG4)
                .IsUnicode(false);

            modelBuilder.Entity<COB>()
                .Property(e => e.FLDTAGA4)
                .IsUnicode(false);

            modelBuilder.Entity<COB>()
                .Property(e => e.FLDID5)
                .IsUnicode(false);

            modelBuilder.Entity<COB>()
                .Property(e => e.FLDTAG5)
                .IsUnicode(false);

            modelBuilder.Entity<COB>()
                .Property(e => e.FLDTAGA5)
                .IsUnicode(false);

            modelBuilder.Entity<COB>()
                .Property(e => e.FLDID6)
                .IsUnicode(false);

            modelBuilder.Entity<COB>()
                .Property(e => e.FLDTAG6)
                .IsUnicode(false);

            modelBuilder.Entity<COB>()
                .Property(e => e.FLDTAGA6)
                .IsUnicode(false);

            modelBuilder.Entity<COB>()
                .Property(e => e.FLDID7)
                .IsUnicode(false);

            modelBuilder.Entity<COB>()
                .Property(e => e.FLDTAG7)
                .IsUnicode(false);

            modelBuilder.Entity<COB>()
                .Property(e => e.FLDTAGA7)
                .IsUnicode(false);

            modelBuilder.Entity<COB>()
                .Property(e => e.FLDID8)
                .IsUnicode(false);

            modelBuilder.Entity<COB>()
                .Property(e => e.FLDTAG8)
                .IsUnicode(false);

            modelBuilder.Entity<COB>()
                .Property(e => e.FLDTAGA8)
                .IsUnicode(false);

            modelBuilder.Entity<COB>()
                .Property(e => e.FLDID9)
                .IsUnicode(false);

            modelBuilder.Entity<COB>()
                .Property(e => e.FLDTAG9)
                .IsUnicode(false);

            modelBuilder.Entity<COB>()
                .Property(e => e.FLDTAGA9)
                .IsUnicode(false);

            modelBuilder.Entity<COB>()
                .Property(e => e.FLDID10)
                .IsUnicode(false);

            modelBuilder.Entity<COB>()
                .Property(e => e.FLDTAG10)
                .IsUnicode(false);

            modelBuilder.Entity<COB>()
                .Property(e => e.FLDTAGA10)
                .IsUnicode(false);

            modelBuilder.Entity<COB>()
                .Property(e => e.FLDID11)
                .IsUnicode(false);

            modelBuilder.Entity<COB>()
                .Property(e => e.FLDTAG11)
                .IsUnicode(false);

            modelBuilder.Entity<COB>()
                .Property(e => e.FLDTAGA11)
                .IsUnicode(false);

            modelBuilder.Entity<COB>()
                .Property(e => e.FLDID12)
                .IsUnicode(false);

            modelBuilder.Entity<COB>()
                .Property(e => e.FLDTAG12)
                .IsUnicode(false);

            modelBuilder.Entity<COB>()
                .Property(e => e.FLDTAGA12)
                .IsUnicode(false);

            modelBuilder.Entity<COB>()
                .Property(e => e.FLDID13)
                .IsUnicode(false);

            modelBuilder.Entity<COB>()
                .Property(e => e.FLDTAG13)
                .IsUnicode(false);

            modelBuilder.Entity<COB>()
                .Property(e => e.FLDTAGA13)
                .IsUnicode(false);

            modelBuilder.Entity<COB>()
                .Property(e => e.FLDID14)
                .IsUnicode(false);

            modelBuilder.Entity<COB>()
                .Property(e => e.FLDTAG14)
                .IsUnicode(false);

            modelBuilder.Entity<COB>()
                .Property(e => e.FLDTAGA14)
                .IsUnicode(false);

            modelBuilder.Entity<COB>()
                .Property(e => e.FLDID15)
                .IsUnicode(false);

            modelBuilder.Entity<COB>()
                .Property(e => e.FLDTAG15)
                .IsUnicode(false);

            modelBuilder.Entity<COB>()
                .Property(e => e.FLDTAGA15)
                .IsUnicode(false);

            modelBuilder.Entity<COB>()
                .Property(e => e.Last_Opr)
                .IsUnicode(false);
        }
    }
}
