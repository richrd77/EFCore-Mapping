using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreMapping.OneToManyMapping
{
    public static class OneToManyMapping
    {
        public static void RegisterOneToManyRelationship(this ModelBuilder mb)
        {
            //Register the Keys - can be optional as we have already mentioned in the entity class
            mb.Entity<OneToManyMappingParent>().HasKey(p => p.Id);
            mb.Entity<OneToManyMappingChild>().HasKey(c => c.Id);

            mb.Entity<OneToManyMappingParent>()
                .HasMany<OneToManyMappingChild>(p => p.Children)
                .WithOne(c => c.Parent)
                .HasForeignKey(c1 => c1.ParentId);
        }
    }
}
