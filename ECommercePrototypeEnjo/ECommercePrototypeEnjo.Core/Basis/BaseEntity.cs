using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommercePrototypeEnjo.Core
{

    /// <summary>
    /// Base class for entities
    /// </summary>
    public abstract class BaseEntity
    {
        /// <summary>
        /// Gets or sets the id
        /// </summary>
        public int Id { get; set; }
    }
}
