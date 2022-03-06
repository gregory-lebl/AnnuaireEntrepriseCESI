using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace AnnuaireEntrepriseCESI.Migrations
{
    public partial class DatabaseSetup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admin",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admin", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employe",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CellPhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FixePhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ServiceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SiteId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employe", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Service",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Service", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Site",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Site", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Admin",
                columns: new[] { "Id", "Email", "Password" },
                values: new object[] { new Guid("45051e65-b01e-4bad-86ac-3faacae2f169"), "admin@admin.fr", "admin" });

            migrationBuilder.InsertData(
                table: "Service",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("58b4fe53-07e6-4aca-88d0-397c53437b8f"), "Service Commercial" },
                    { new Guid("8b1a0e4e-f717-4cb2-800c-754898c46613"), "Service Marketing" },
                    { new Guid("4d7e2128-d65e-4779-8e11-5732bfda5360"), "Service Financier" },
                    { new Guid("7ea5908a-d46f-4ea3-9d3e-0d9f91ade42f"), "Service Industriel" },
                    { new Guid("342b1f79-7c1c-4013-bf3c-e522cc79127f"), "Service Ressources Humaines" },
                    { new Guid("9ea93130-81f2-499f-81c0-eb72223ae60d"), "Service Achat" },
                    { new Guid("1da8e146-9766-4c2b-89cf-0a6829d39d65"), "Service Juridique" }
                });

            migrationBuilder.InsertData(
                table: "Site",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("eb83b75f-1718-4b8b-9349-59d842193d4e"), "Site administratif", "Paris" },
                    { new Guid("80985050-0606-4ea9-b4ff-4655084595d8"), "Site de Production", "Nantes" },
                    { new Guid("56aabeb2-5dd1-45e6-ba18-f5288d19a5ed"), "Site de Production", "Toulouse" },
                    { new Guid("83033ef1-6f0e-4349-aa03-a1f03df04f2f"), "Site de Production", "Nice" },
                    { new Guid("1498df82-8668-4c10-92dc-2f3010fefe5e"), "Site de Production", "Lille" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admin");

            migrationBuilder.DropTable(
                name: "Employe");

            migrationBuilder.DropTable(
                name: "Service");

            migrationBuilder.DropTable(
                name: "Site");
        }
    }
}
