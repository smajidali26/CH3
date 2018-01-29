using CH3.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH3.Data.Mapping
{
    public partial class MemberMap : CH3EntityTypeConfiguration<Member>
    {
        public MemberMap()
        {
            this.ToTable("Member");
            this.HasKey(e => e.Id);
            this.Property(e => e.FirstName).IsRequired();
            this.Property(e => e.LastName).IsRequired();
            this.Property(e => e.CnicNumber).IsRequired();
            this.Property(e => e.ContactNumber).IsRequired();
            this.Property(e => e.DateOfBirth).IsRequired();
            this.Property(e => e.FatherOrHusbandName).IsRequired();
            this.Property(e => e.IsSalaried).IsRequired();
            this.HasRequired(e => e.LivingStatus).WithMany().HasForeignKey(e => e.LivingStatusId).WillCascadeOnDelete(false);
            this.HasRequired(e => e.MaritalStatus).WithMany().HasForeignKey(e => e.MaritalStatusId).WillCascadeOnDelete(false);
            this.HasRequired(e => e.Gender).WithMany().HasForeignKey(e => e.GenderId).WillCascadeOnDelete(false);
            this.HasRequired(e => e.Mohallah).WithMany().HasForeignKey(e => e.MohallahId).WillCascadeOnDelete(false);
            this.HasRequired(e => e.SourceOfIncome).WithMany().HasForeignKey(e => e.SourceOfIncomeId).WillCascadeOnDelete(false);
            this.HasRequired(e => e.State).WithMany().HasForeignKey(e => e.StateId).WillCascadeOnDelete(false);
            this.HasRequired(e => e.Tehsil).WithMany().HasForeignKey(e => e.TehsilId).WillCascadeOnDelete(false);
            this.HasRequired(e => e.UnionCouncil).WithMany().HasForeignKey(e => e.UnionCouncilId).WillCascadeOnDelete(false);
            this.HasRequired(e => e.Village).WithMany().HasForeignKey(e => e.VillageId).WillCascadeOnDelete(false);
        }
    }
}
