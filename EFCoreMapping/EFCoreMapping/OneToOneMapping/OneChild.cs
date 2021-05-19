using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreMapping.OneToOneMapping
{
    public class OneChild
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public int ParentId { get; set; }

        public virtual OneParent Parent { get; set; }

        /// <summary>
        /// Overiding this to simplify the output, normally we use Seralizers to serialze objetcs
        /// and return to the clients
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"Child Object :: Id={Id} Name={Name}";
        }
    }
}
