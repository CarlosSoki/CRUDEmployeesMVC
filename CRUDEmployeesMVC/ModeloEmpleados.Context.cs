
namespace CRUDEmployeesMVC
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class CRUDDBEntities : DbContext
    {
        public CRUDDBEntities()
            : base("name=CRUDDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tabla_Empleados> tabla_Empleados { get; set; }
    }
}
