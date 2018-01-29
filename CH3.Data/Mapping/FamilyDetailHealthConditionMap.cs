using CH3.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH3.Data.Mapping
{
    public partial class FamilyDetailHealthConditionMap : CH3EntityTypeConfiguration<FamilyDetailHealthCondition>
    {
        public FamilyDetailHealthConditionMap()
        {
            this.ToTable("FamilyDetailHealthCondition");
            this.HasKey(e => e.Id);
            this.HasRequired(e => e.FamilyDetail).WithMany().HasForeignKey(e => e.FamilyDetailId).WillCascadeOnDelete(false);
            this.HasRequired(e => e.HealthCondition).WithMany().HasForeignKey(e => e.HealthConditionId).WillCascadeOnDelete(false);
        }
    }
}
