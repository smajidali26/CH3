using CH3.Core.Domain;

namespace CH3.Data.Mapping
{
    public partial class UserLoginMap : CH3EntityTypeConfiguration<UserLogin>
    {
        public UserLoginMap()
        {
            this.ToTable("UserLogin");
            this.HasKey(e => e.Id);
            this.Property(e => e.Username).IsRequired();
            this.Property(e => e.Password).IsRequired();
            this.Property(e => e.PasswordHash).IsRequired();
            this.Property(e => e.Active).IsRequired();
            this.Property(e => e.CreatedDate).IsRequired();
            this.Property(e => e.CreatedBy).IsRequired();

        }
    }
}
