using Microsoft.EntityFrameworkCore;
using EFCoreMapping.OneToOneMapping;
using EFCoreMapping.OneToManyMapping;

namespace EFCoreMapping
{
    public class MyDBContext: DbContext
    {
        public MyDBContext(DbContextOptions op):base(op)
        {

        }


        public DbSet<OneParent> OneonOneParent { get; set; }

        public DbSet<OneChild> OneonOneChild { get; set; }


        public DbSet<OneToManyMappingParent> OneToManyMappingParents { get; set; }

        public DbSet<OneToManyMappingChild> OneToManyMappingChildren { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.RegisterOneToOneRelation();

            modelBuilder.RegisterOneToManyRelationship();
        }
    }
}