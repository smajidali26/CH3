using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH3.Core.Domain
{
    public partial class Member : BaseEntity
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string FatherOrHusbandName { get; set; }

        public string CnicNumber { get; set; }

        public string ContactNumber { get; set; }

        public DateTime DateOfBirth { get; set; }

        public bool IsSalaried { get; set; }

        public int MaritalStatusId { get; set; }

        public int GenderId { get; set; }

        public int SourceOfIncomeId { get; set; }

        public int LivingStatusId { get; set; }

        public int MohallahId { get; set; }

        public int VillageId { get; set; }

        public int UnionCouncilId { get; set; }

        public int TehsilId { get; set; }

        public int DistrictId { get; set; }

        public int StateId { get; set; }

        public MaritalStatus MaritalStatus { get; set; }

        public Gender Gender { get; set; }

        public SourceOfIncome SourceOfIncome { get; set; }

        public LivingStatus LivingStatus { get; set; }

        public Location Mohallah { get; set; }

        public Location Village { get; set; }

        public Location UnionCouncil { get; set; }

        public Location Tehsil { get; set; }

        public Location District { get; set; }

        public Location State { get; set; }

    }
}
