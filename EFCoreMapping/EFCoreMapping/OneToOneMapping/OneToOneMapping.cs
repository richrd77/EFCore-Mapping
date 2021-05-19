using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreMapping.OneToOneMapping
{
    public static class OneToOneMapping
    {
        public static void RegisterOneToOneRelation(this ModelBuilder mb)
        {
            //Register the Keys - can be optional as we have already mentioned in the entity class
            mb.Entity<OneParent>().HasKey(p => p.Id);
            mb.Entity<OneChild>().HasKey(c => c.Id);

            //Establish one to one relation with foreignKey as parentId in OneChild class
            mb.Entity<OneParent>().HasOne(p => p.Child)
                .WithOne(c => c.Parent).HasForeignKey<OneChild>(c => c.ParentId);
        }
    }
}
