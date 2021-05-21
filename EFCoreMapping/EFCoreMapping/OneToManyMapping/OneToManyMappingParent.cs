using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreMapping.OneToManyMapping
{
    public class OneToManyMappingParent
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual List<OneToManyMappingChild> Children { get; set; }
    }
}
