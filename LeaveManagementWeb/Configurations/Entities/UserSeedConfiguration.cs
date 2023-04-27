using LeaveManagementWeb.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagementWeb.Configurations.Entities
{
    public class UserSeedConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            //creating default users, normally this would of course be in gitignore, but for this project
            //decided to leave it in, since this is not going to production
            var hasher = new PasswordHasher<Employee>();
            builder.HasData(
                new Employee
                {
                    Id = "84df05bf-a29f-49a1-8972-5ceea06e5cdd",
                    Email = "admin2@test.com",
                    NormalizedEmail = "ADMIN2@TEST.COM",
                    NormalizedUserName = "ADMIN2@TEST.COM",
                    UserName = "admin2@test.com",
                    FirstName = "Admin",
                    LastName = "Test",
                    PasswordHash = hasher.HashPassword(null, "V3ryNicePW!"),
                    EmailConfirmed = true
                },
                 new Employee
                 {
                     Id = "b1307ac6-2428-409d-a83d-7e188048b199",
                     Email = "user@test.com",
                     NormalizedEmail = "USER@TEST.COM",
                     NormalizedUserName = "USER@TEST.COM",
                     UserName = "user@test.com",
                     FirstName = "System",
                     LastName = "User",
                     PasswordHash = hasher.HashPassword(null, "P@ssWord1"),
                     EmailConfirmed = true
                 }
            );
        }
    }
}