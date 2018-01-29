using CH3.Core.Domain;

namespace CH3.Data.Mapping
{
    public partial class LivingStatusMap : CH3EntityTypeConfiguration<LivingStatus>
    {
        public LivingStatusMap()
        {
            this.ToTable("LivingStatus");
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
