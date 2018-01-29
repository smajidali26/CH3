using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH3.Core.Domain
{
    public partial class Location: BaseEntity
    {
        public string Name { get; set; }

        public int ParentLocationId { get; set; }

        public Location ParentLocation { get; set; }
    }
}
