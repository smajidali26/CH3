using CH3.Core.Domain;

namespace CH3.Data.Mapping
{
    public partial class FamilyDetailMap : CH3EntityTypeConfiguration<FamilyDetail>
    {
        public FamilyDetailMap()
        {
            this.ToTable("FamilyDetail");
            this.HasKey(e => e.Id);
            this.Property(e => e.Name).IsRequired().HasMaxLength(100);
            this.Property(e => e.DateOfBirth).IsRequired();
            this.Property(e => e.IsSalaried).IsRequired();
            this.Property(e => e.CreatedDate).IsRequired();
            this.Property(e => e.CreatedBy).IsRequired();
            //this.Property(e => e.UpdatedDate).IsOptional();
            //this.Property(e => e.UpdatedBy).IsOptional();
            //this.Property(e => e.DeletedDate).IsOptional();
            //this.Property(e => e.DeletedBy).IsOptional();
            //this.Property(e => e.IsDeleted).IsOptional();

            this.HasRequired(e => e.Member).WithMany().HasForeignKey(e => e.MemberId).WillCascadeOnDelete(false);
            this.HasRequired(e => e.MaritalStatus).WithMany().HasForeignKey(e => e.MaritalStatusId).WillCascadeOnDelete(false);
            this.HasRequired(e => e.SourceOfIncome).WithMany().HasForeignKey(e => e.SourceOfIncomeId).WillCascadeOnDelete(false);
            this.HasRequired(e => e.FamilyRelation).WithMany().HasForeignKey(e => e.FamilyRelationId).WillCascadeOnDelete(false);
            this.HasRequired(e => e.Gender).WithMany().HasForeignKey(e => e.GenderId).WillCascadeOnDelete(false);

        }
    }
}
