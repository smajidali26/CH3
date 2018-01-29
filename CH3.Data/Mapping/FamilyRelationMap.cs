using CH3.Core.Domain;

namespace CH3.Data.Mapping
{
    public partial class FamilyRelationMap : CH3EntityTypeConfiguration<FamilyRelation>
    {
        public FamilyRelationMap()
        {
            this.ToTable("FamilyRelation");
            this.HasKey(e => e.Id);
            this.Property(e => e.Name).IsRequired().HasMaxLength(100);
            this.Property(e => e.CreatedDate).IsRequired();
            this.Property(e => e.CreatedBy).IsRequired();
            this.Property(e => e.UpdatedDate).IsOptional();
            this.Property(e => e.UpdatedBy).IsOptional();
            this.Property(e => e.DeletedDate).IsOptional();
            this.Property(e => e.DeletedBy).IsOptional();
            this.Property(e => e.IsDeleted).IsOptional();

        }
    }
}
