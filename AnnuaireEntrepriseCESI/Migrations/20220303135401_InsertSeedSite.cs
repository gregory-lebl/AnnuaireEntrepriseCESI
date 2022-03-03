using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AnnuaireEntrepriseCESI.Migrations
{
    public partial class InsertSeedSite : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Site",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("92ae7b85-091a-499a-b027-116f3c739461"), "Site administratif", "Paris" },
                    { new Guid("9cc96c9e-7d27-4719-a3da-a41f04842ecc"), "Site de Production", "Nantes" },
                    { new Guid("06de45a2-14a3-4c1b-b33e-e4162dbf8e6d"), "Site de Production", "Toulouse" },
                    { new Guid("e2c484b7-6ca4-49a9-8c78-50e4905a0fe8"), "Site de Production", "Nice" },
                    { new Guid("81e80e09-2e22-4ef0-b783-1b4e5de68de6"), "Site de Production", "Lille" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Site",
                keyColumn: "Id",
                keyValue: new Guid("06de45a2-14a3-4c1b-b33e-e4162dbf8e6d"));

            migrationBuilder.DeleteData(
                table: "Site",
                keyColumn: "Id",
                keyValue: new Guid("81e80e09-2e22-4ef0-b783-1b4e5de68de6"));

            migrationBuilder.DeleteData(
                table: "Site",
                keyColumn: "Id",
                keyValue: new Guid("92ae7b85-091a-499a-b027-116f3c739461"));

            migrationBuilder.DeleteData(
                table: "Site",
                keyColumn: "Id",
                keyValue: new Guid("9cc96c9e-7d27-4719-a3da-a41f04842ecc"));

            migrationBuilder.DeleteData(
                table: "Site",
                keyColumn: "Id",
                keyValue: new Guid("e2c484b7-6ca4-49a9-8c78-50e4905a0fe8"));
        }
    }
}
