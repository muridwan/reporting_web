namespace reporting_web.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DataTOC : DbContext
    {
        public DataTOC()
            : base("name=SqlDBDRC")
        {
        }

        public virtual DbSet<TOC> TOCs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TOC>()
                .Property(e => e.TOC1)
                .IsUnicode(false);

            modelBuilder.Entity<TOC>()
                .Property(e => e.DESCRIPTION)
                .IsUnicode(false);

            modelBuilder.Entity<TOC>()
                .Property(e => e.COB)
                .IsUnicode(false);

            modelBuilder.Entity<TOC>()
                .Property(e => e.TOCGroup)
                .IsUnicode(false);

            modelBuilder.Entity<TOC>()
                .Property(e => e.POLICYTITLE)
                .IsUnicode(false);

            modelBuilder.Entity<TOC>()
                .Property(e => e.REGID)
                .IsUnicode(false);

            modelBuilder.Entity<TOC>()
                .Property(e => e.FLDID1)
                .IsUnicode(false);

            modelBuilder.Entity<TOC>()
                .Property(e => e.FLDTAG1)
                .IsUnicode(false);

            modelBuilder.Entity<TOC>()
                .Property(e => e.FLDTAGA1)
                .IsUnicode(false);

            modelBuilder.Entity<TOC>()
                .Property(e => e.FLDID2)
                .IsUnicode(false);

            modelBuilder.Entity<TOC>()
                .Property(e => e.FLDTAG2)
                .IsUnicode(false);

            modelBuilder.Entity<TOC>()
                .Property(e => e.FLDTAGA2)
                .IsUnicode(false);

            modelBuilder.Entity<TOC>()
                .Property(e => e.FLDID3)
                .IsUnicode(false);

            modelBuilder.Entity<TOC>()
                .Property(e => e.FLDTAG3)
                .IsUnicode(false);

            modelBuilder.Entity<TOC>()
                .Property(e => e.FLDTAGA3)
                .IsUnicode(false);

            modelBuilder.Entity<TOC>()
                .Property(e => e.FLDID4)
                .IsUnicode(false);

            modelBuilder.Entity<TOC>()
                .Property(e => e.FLDTAG4)
                .IsUnicode(false);

            modelBuilder.Entity<TOC>()
                .Property(e => e.FLDTAGA4)
                .IsUnicode(false);

            modelBuilder.Entity<TOC>()
                .Property(e => e.FLDID5)
                .IsUnicode(false);

            modelBuilder.Entity<TOC>()
                .Property(e => e.FLDTAG5)
                .IsUnicode(false);

            modelBuilder.Entity<TOC>()
                .Property(e => e.FLDTAGA5)
                .IsUnicode(false);

            modelBuilder.Entity<TOC>()
                .Property(e => e.FLDID6)
                .IsUnicode(false);

            modelBuilder.Entity<TOC>()
                .Property(e => e.FLDTAG6)
                .IsUnicode(false);

            modelBuilder.Entity<TOC>()
                .Property(e => e.FLDTAGA6)
                .IsUnicode(false);

            modelBuilder.Entity<TOC>()
                .Property(e => e.FLDID7)
                .IsUnicode(false);

            modelBuilder.Entity<TOC>()
                .Property(e => e.FLDTAG7)
                .IsUnicode(false);

            modelBuilder.Entity<TOC>()
                .Property(e => e.FLDTAGA7)
                .IsUnicode(false);

            modelBuilder.Entity<TOC>()
                .Property(e => e.FLDID8)
                .IsUnicode(false);

            modelBuilder.Entity<TOC>()
                .Property(e => e.FLDTAG8)
                .IsUnicode(false);

            modelBuilder.Entity<TOC>()
                .Property(e => e.FLDTAGA8)
                .IsUnicode(false);

            modelBuilder.Entity<TOC>()
                .Property(e => e.FLDID9)
                .IsUnicode(false);

            modelBuilder.Entity<TOC>()
                .Property(e => e.FLDTAG9)
                .IsUnicode(false);

            modelBuilder.Entity<TOC>()
                .Property(e => e.FLDTAGA9)
                .IsUnicode(false);

            modelBuilder.Entity<TOC>()
                .Property(e => e.FLDID10)
                .IsUnicode(false);

            modelBuilder.Entity<TOC>()
                .Property(e => e.FLDTAG10)
                .IsUnicode(false);

            modelBuilder.Entity<TOC>()
                .Property(e => e.FLDTAGA10)
                .IsUnicode(false);

            modelBuilder.Entity<TOC>()
                .Property(e => e.FLDID11)
                .IsUnicode(false);

            modelBuilder.Entity<TOC>()
                .Property(e => e.FLDTAG11)
                .IsUnicode(false);

            modelBuilder.Entity<TOC>()
                .Property(e => e.FLDTAGA11)
                .IsUnicode(false);

            modelBuilder.Entity<TOC>()
                .Property(e => e.FLDID12)
                .IsUnicode(false);

            modelBuilder.Entity<TOC>()
                .Property(e => e.FLDTAG12)
                .IsUnicode(false);

            modelBuilder.Entity<TOC>()
                .Property(e => e.FLDTAGA12)
                .IsUnicode(false);

            modelBuilder.Entity<TOC>()
                .Property(e => e.FLDID13)
                .IsUnicode(false);

            modelBuilder.Entity<TOC>()
                .Property(e => e.FLDTAG13)
                .IsUnicode(false);

            modelBuilder.Entity<TOC>()
                .Property(e => e.FLDTAGA13)
                .IsUnicode(false);

            modelBuilder.Entity<TOC>()
                .Property(e => e.FLDID14)
                .IsUnicode(false);

            modelBuilder.Entity<TOC>()
                .Property(e => e.FLDTAG14)
                .IsUnicode(false);

            modelBuilder.Entity<TOC>()
                .Property(e => e.FLDTAGA14)
                .IsUnicode(false);

            modelBuilder.Entity<TOC>()
                .Property(e => e.FLDID15)
                .IsUnicode(false);

            modelBuilder.Entity<TOC>()
                .Property(e => e.FLDTAG15)
                .IsUnicode(false);

            modelBuilder.Entity<TOC>()
                .Property(e => e.FLDTAGA15)
                .IsUnicode(false);

            modelBuilder.Entity<TOC>()
                .Property(e => e.PTOC)
                .IsUnicode(false);

            modelBuilder.Entity<TOC>()
                .Property(e => e.RFLDID1)
                .IsUnicode(false);

            modelBuilder.Entity<TOC>()
                .Property(e => e.RFLDID2)
                .IsUnicode(false);

            modelBuilder.Entity<TOC>()
                .Property(e => e.RFLDID3)
                .IsUnicode(false);

            modelBuilder.Entity<TOC>()
                .Property(e => e.RFLDID4)
                .IsUnicode(false);

            modelBuilder.Entity<TOC>()
                .Property(e => e.RFLDID5)
                .IsUnicode(false);

            modelBuilder.Entity<TOC>()
                .Property(e => e.Last_Opr)
                .IsUnicode(false);

            modelBuilder.Entity<TOC>()
                .Property(e => e.LBL_PHOLDER)
                .IsUnicode(false);

            modelBuilder.Entity<TOC>()
                .Property(e => e.LBL_AID)
                .IsUnicode(false);

            modelBuilder.Entity<TOC>()
                .Property(e => e.POLICYTITLE_1)
                .IsUnicode(false);

            modelBuilder.Entity<TOC>()
                .Property(e => e.FLDID16)
                .IsUnicode(false);

            modelBuilder.Entity<TOC>()
                .Property(e => e.FLDTAG16)
                .IsUnicode(false);

            modelBuilder.Entity<TOC>()
                .Property(e => e.FLDTAGA16)
                .IsUnicode(false);

            modelBuilder.Entity<TOC>()
                .Property(e => e.FLDID17)
                .IsUnicode(false);

            modelBuilder.Entity<TOC>()
                .Property(e => e.FLDTAG17)
                .IsUnicode(false);

            modelBuilder.Entity<TOC>()
                .Property(e => e.FLDTAGA17)
                .IsUnicode(false);

            modelBuilder.Entity<TOC>()
                .Property(e => e.FLDID18)
                .IsUnicode(false);

            modelBuilder.Entity<TOC>()
                .Property(e => e.FLDTAG18)
                .IsUnicode(false);

            modelBuilder.Entity<TOC>()
                .Property(e => e.FLDTAGA18)
                .IsUnicode(false);

            modelBuilder.Entity<TOC>()
                .Property(e => e.FLDID19)
                .IsUnicode(false);

            modelBuilder.Entity<TOC>()
                .Property(e => e.FLDTAG19)
                .IsUnicode(false);

            modelBuilder.Entity<TOC>()
                .Property(e => e.FLDTAGA19)
                .IsUnicode(false);

            modelBuilder.Entity<TOC>()
                .Property(e => e.FLDID20)
                .IsUnicode(false);

            modelBuilder.Entity<TOC>()
                .Property(e => e.FLDTAG20)
                .IsUnicode(false);

            modelBuilder.Entity<TOC>()
                .Property(e => e.FLDTAGA20)
                .IsUnicode(false);

            modelBuilder.Entity<TOC>()
                .Property(e => e.FLDID21)
                .IsUnicode(false);

            modelBuilder.Entity<TOC>()
                .Property(e => e.FLDTAG21)
                .IsUnicode(false);

            modelBuilder.Entity<TOC>()
                .Property(e => e.FLDTAGA21)
                .IsUnicode(false);

            modelBuilder.Entity<TOC>()
                .Property(e => e.FLDID22)
                .IsUnicode(false);

            modelBuilder.Entity<TOC>()
                .Property(e => e.FLDTAG22)
                .IsUnicode(false);

            modelBuilder.Entity<TOC>()
                .Property(e => e.FLDTAGA22)
                .IsUnicode(false);

            modelBuilder.Entity<TOC>()
                .Property(e => e.FLDID23)
                .IsUnicode(false);

            modelBuilder.Entity<TOC>()
                .Property(e => e.FLDTAG23)
                .IsUnicode(false);

            modelBuilder.Entity<TOC>()
                .Property(e => e.FLDTAGA23)
                .IsUnicode(false);

            modelBuilder.Entity<TOC>()
                .Property(e => e.FLDID24)
                .IsUnicode(false);

            modelBuilder.Entity<TOC>()
                .Property(e => e.FLDTAG24)
                .IsUnicode(false);

            modelBuilder.Entity<TOC>()
                .Property(e => e.FLDTAGA24)
                .IsUnicode(false);

            modelBuilder.Entity<TOC>()
                .Property(e => e.FLDID25)
                .IsUnicode(false);

            modelBuilder.Entity<TOC>()
                .Property(e => e.FLDTAG25)
                .IsUnicode(false);

            modelBuilder.Entity<TOC>()
                .Property(e => e.FLDTAGA25)
                .IsUnicode(false);

            modelBuilder.Entity<TOC>()
                .Property(e => e.FLDID26)
                .IsUnicode(false);

            modelBuilder.Entity<TOC>()
                .Property(e => e.FLDTAG26)
                .IsUnicode(false);

            modelBuilder.Entity<TOC>()
                .Property(e => e.FLDTAGA26)
                .IsUnicode(false);

            modelBuilder.Entity<TOC>()
                .Property(e => e.FLDID27)
                .IsUnicode(false);

            modelBuilder.Entity<TOC>()
                .Property(e => e.FLDTAG27)
                .IsUnicode(false);

            modelBuilder.Entity<TOC>()
                .Property(e => e.FLDTAGA27)
                .IsUnicode(false);

            modelBuilder.Entity<TOC>()
                .Property(e => e.FLDID28)
                .IsUnicode(false);

            modelBuilder.Entity<TOC>()
                .Property(e => e.FLDTAG28)
                .IsUnicode(false);

            modelBuilder.Entity<TOC>()
                .Property(e => e.FLDTAGA28)
                .IsUnicode(false);

            modelBuilder.Entity<TOC>()
                .Property(e => e.FLDID29)
                .IsUnicode(false);

            modelBuilder.Entity<TOC>()
                .Property(e => e.FLDTAG29)
                .IsUnicode(false);

            modelBuilder.Entity<TOC>()
                .Property(e => e.FLDTAGA29)
                .IsUnicode(false);

            modelBuilder.Entity<TOC>()
                .Property(e => e.FLDID30)
                .IsUnicode(false);

            modelBuilder.Entity<TOC>()
                .Property(e => e.FLDTAG30)
                .IsUnicode(false);

            modelBuilder.Entity<TOC>()
                .Property(e => e.FLDTAGA30)
                .IsUnicode(false);

            modelBuilder.Entity<TOC>()
                .Property(e => e.DEFSTIME)
                .IsUnicode(false);

            modelBuilder.Entity<TOC>()
                .Property(e => e.DEFETIME)
                .IsUnicode(false);

            modelBuilder.Entity<TOC>()
                .Property(e => e.VATDESCRIPTION)
                .IsUnicode(false);
        }
    }
}
