using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Migrations;
using System.Text;

namespace FastLearnersMVCWebApplication.Data.Migrations
{
    public partial class AddAdminRole : Migration
    {
        const string ADMIN_USER_GUID = "538d650e-7bfc-4dd7-90bd-7595189b3bf5";
        const string ADMIN_ROLE_GUID = "855bc249-1c93-4e0b-aad7-a549f8248b3e";

        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var hasher = new PasswordHasher<ApplicationUser>();

            var passwordHash = hasher.HashPassword(null, "aaalli0122");

            StringBuilder sb = new StringBuilder();

            sb.AppendLine("INSERT INTO AspNetUsers(Id, UserName, NormalizedUserName,Email,EmailConfirmed" +
                ",PhoneNumberConfirmed,TwoFactorEnabled,LockoutEnabled,AccessFailedCount,NormalizedEmail" +
                $",PasswordHash,SecurityStamp,FirstName) VALUES('{ADMIN_USER_GUID}','a.geysari@gmail.com'" +
                $",'A.GEYSARI@GMAIL.COM','a.geysari@gmail.com', 0, 0, 0, 0, 0,'A.GEYSARI@GMAIL.COM'" +
                $", '{passwordHash}', '','Admin')");

            migrationBuilder.Sql(sb.ToString());

            migrationBuilder.Sql($"INSERT INTO AspNetRoles (Id, Name, NormalizedName) VALUES ('{ADMIN_ROLE_GUID}','Admin','ADMIN')");

            migrationBuilder.Sql($"INSERT INTO AspNetUserRoles (UserId, RoleId) VALUES ('{ADMIN_USER_GUID}','{ADMIN_ROLE_GUID}')");


        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql($"DELETE FROM AspNetUserRoles WHERE UserId = '{ADMIN_USER_GUID}' AND RoleId = '{ADMIN_ROLE_GUID}'");

            migrationBuilder.Sql($"DELETE FROM AspNetUsers WHERE Id = '{ADMIN_USER_GUID}'");

            migrationBuilder.Sql($"DELETE FROM AspNetRoles WHERE Id = '{ADMIN_ROLE_GUID}'");

        }
    }
}
