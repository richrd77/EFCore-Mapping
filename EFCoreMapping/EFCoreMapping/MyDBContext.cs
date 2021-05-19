using Microsoft.EntityFrameworkCore;
using EFCoreMapping.OneToOneMapping;

namespace EFCoreMapping
{
    public class MyDBContext: DbContext
    {
        public MyDBContext(DbContextOptions op):base(op)
        {

        }


        public DbSet<OneParent> OneonOneParent { get; set; }

        public DbSet<OneChild> OneonOneChild { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.RegisterOneToOneRelation();
        }
    }
}