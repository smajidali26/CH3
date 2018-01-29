using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH3.Core.Domain
{
    public partial class FamilyDetailHealthCondition : BaseEntity
    {
        public int FamilyDetailId { get; set; }

        public int HealthConditionId { get; set; }

        public FamilyDetail FamilyDetail { get; set; }

        public HealthCondition HealthCondition { get; set; }
    }
}
