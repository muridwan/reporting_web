using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace reporting_web.Models
{
    public class DataGroupBranch : DbContext
    {
        public DataGroupBranch()
            : base("name=SqlDBDRC")
        {
        }
        public virtual DbSet<BranchGroup> BranchesGroup { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Branch>()
               .Property(e => e.Branch1)
               .IsUnicode(false);

            modelBuilder.Entity<Branch>()
                .Property(e => e.Name)
                .IsUnicode(false);
        }

    }
}