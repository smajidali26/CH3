using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH3.Core.Domain
{
    public partial class FamilyDetail : BaseEntity
    {
        public string Name { get; set; }

        public DateTime DateOfBirth { get; set; }

        public bool IsSalaried { get; set; }

        public int SourceOfIncomeId { get; set; }

        public int MemberId { get; set; }

        public int FamilyRelationId { get; set; }

        public int GenderId { get; set; }

        public int MaritalStatusId { get; set; }

        public SourceOfIncome SourceOfIncome { get; set; }

        public Member Member { get; set; }

        public Gender Gender { get; set; }

        public MaritalStatus MaritalStatus { get; set; }

        public FamilyRelation FamilyRelation { get; set; }

    }
}
