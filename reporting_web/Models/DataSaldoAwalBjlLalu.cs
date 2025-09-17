namespace reporting_web.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DataSaldoAwalBjlLalu : DbContext
    {
        public DataSaldoAwalBjlLalu()
            : base("name=SqlDBDRC")
        {
        }

        public virtual DbSet<SaldoAwalBjlLalu> SaldoAwalBjlLalus { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
