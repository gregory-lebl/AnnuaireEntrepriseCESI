using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AnnuaireEntrepriseCESI.Migrations
{
    public partial class InsertSeedService : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Service",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("bdc32c8b-336d-4056-b526-d5abb7c8f7da"), "Service Commercial" },
                    { new Guid("d4801915-8a73-4093-9570-ce0f29ebafd2"), "Service Marketing" },
                    { new Guid("44f46e77-ad56-4b38-a4eb-7c48a111cef3"), "Service Financier" },
                    { new Guid("e87bd3af-26ee-4ccd-9919-ad0795a4ddbd"), "Service Industriel" },
                    { new Guid("848b1c6c-6bed-4e43-ae08-677e95210c98"), "Service Ressources Humaines" },
                    { new Guid("f15ae25b-a93e-4ac7-8fbb-ba9e526c1bb0"), "Service Achat" },
                    { new Guid("33ed3c1d-01b9-4390-8516-d2ed7e306ee9"), "Service Juridique" }
                });

            migrationBuilder.InsertData(
                table: "Site",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("d11a4470-e264-4a40-932e-8f3212dd8a54"), "Site administratif", "Paris" },
                    { new Guid("d4b7f9d7-9559-47ad-a8ba-da5dbe72b620"), "Site de Production", "Nantes" },
                    { new Guid("cbda5772-33de-4450-8f9d-22d2775afd6b"), "Site de Production", "Toulouse" },
                    { new Guid("cd8f7cf6-900f-47cf-97ff-fdf72eaa6029"), "Site de Production", "Nice" },
                    { new Guid("9216e2ef-9dca-4a5c-960a-7986c7044fb8"), "Site de Production", "Lille" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Service",
                keyColumn: "Id",
                keyValue: new Guid("33ed3c1d-01b9-4390-8516-d2ed7e306ee9"));

            migrationBuilder.DeleteData(
                table: "Service",
                keyColumn: "Id",
                keyValue: new Guid("44f46e77-ad56-4b38-a4eb-7c48a111cef3"));

            migrationBuilder.DeleteData(
                table: "Service",
                keyColumn: "Id",
                keyValue: new Guid("848b1c6c-6bed-4e43-ae08-677e95210c98"));

            migrationBuilder.DeleteData(
                table: "Service",
                keyColumn: "Id",
                keyValue: new Guid("bdc32c8b-336d-4056-b526-d5abb7c8f7da"));

            migrationBuilder.DeleteData(
                table: "Service",
                keyColumn: "Id",
                keyValue: new Guid("d4801915-8a73-4093-9570-ce0f29ebafd2"));

            migrationBuilder.DeleteData(
                table: "Service",
                keyColumn: "Id",
                keyValue: new Guid("e87bd3af-26ee-4ccd-9919-ad0795a4ddbd"));

            migrationBuilder.DeleteData(
                table: "Service",
                keyColumn: "Id",
                keyValue: new Guid("f15ae25b-a93e-4ac7-8fbb-ba9e526c1bb0"));

            migrationBuilder.DeleteData(
                table: "Site",
                keyColumn: "Id",
                keyValue: new Guid("9216e2ef-9dca-4a5c-960a-7986c7044fb8"));

            migrationBuilder.DeleteData(
                table: "Site",
                keyColumn: "Id",
                keyValue: new Guid("cbda5772-33de-4450-8f9d-22d2775afd6b"));

            migrationBuilder.DeleteData(
                table: "Site",
                keyColumn: "Id",
                keyValue: new Guid("cd8f7cf6-900f-47cf-97ff-fdf72eaa6029"));

            migrationBuilder.DeleteData(
                table: "Site",
                keyColumn: "Id",
                keyValue: new Guid("d11a4470-e264-4a40-932e-8f3212dd8a54"));

            migrationBuilder.DeleteData(
                table: "Site",
                keyColumn: "Id",
                keyValue: new Guid("d4b7f9d7-9559-47ad-a8ba-da5dbe72b620"));

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
    }
}
