using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreMapping.OneToManyMapping
{
    public class OneToManyMappingChild
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public int ParentId { get; set; }

        public virtual OneToManyMappingParent Parent { get; set; }
    }
}
