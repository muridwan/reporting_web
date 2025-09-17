namespace reporting_web.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DataRoleMenu : DbContext
    {
        public DataRoleMenu()
            : base("name=SqlDBDRC")
        {
        }

        public virtual DbSet<RoleMenu> RoleMenus { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
