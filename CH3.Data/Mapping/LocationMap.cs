using CH3.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH3.Data.Mapping
{
    public partial class LocationMap : CH3EntityTypeConfiguration<Location>
    {
        public LocationMap()
        {
            this.ToTable("Location");
            this.HasKey(e => e.Id);
            this.Property(e => e.Name).IsRequired().HasMaxLength(100);
            this.Property(l => l.ParentLocationId).IsOptional();
            this.Property(e => e.CreatedDate).IsRequired();
            this.Property(e => e.CreatedBy).IsRequired();
            this.Property(e => e.UpdatedDate).IsOptional();
            this.Property(e => e.UpdatedBy).IsOptional();
            this.Property(e => e.DeletedDate).IsOptional();
            this.Property(e => e.DeletedBy).IsOptional();
            this.Property(e => e.IsDeleted).IsOptional();

            this.HasOptional(l => l.ParentLocation)
                .WithMany()
                .HasForeignKey(l => l.ParentLocationId).WillCascadeOnDelete(false);
        }
    }
}
