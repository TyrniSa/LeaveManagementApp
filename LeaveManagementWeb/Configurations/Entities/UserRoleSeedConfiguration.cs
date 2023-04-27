using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagementWeb.Configurations.Entities
{
    internal class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "cac43a6e-f7bb-4448-baaf-ladd431ccbbf",
                    UserId = "84df05bf-a29f-49a1-8972-5ceea06e5cdd"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "caB43a6e-f6bb-4444-baaf-labb431cabbf",
                    UserId = "b1307ac6-2428-409d-a83d-7e188048b199"
                }
            );
        }
    }
}