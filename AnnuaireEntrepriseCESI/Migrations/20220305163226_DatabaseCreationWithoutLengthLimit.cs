using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AnnuaireEntrepriseCESI.Migrations
{
    public partial class DatabaseCreationWithoutLengthLimit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Employe",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "FixePhoneNumber",
                table: "Employe",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Employe",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Employe",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);

            migrationBuilder.AlterColumn<string>(
                name: "CellPhoneNumber",
                table: "Employe",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.InsertData(
                table: "Service",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("b0783421-5fb5-4ddc-885c-ca0f742fe935"), "Service Commercial" },
                    { new Guid("10fedbdd-d5dc-45d8-a06b-2248cd1561ee"), "Service Marketing" },
                    { new Guid("f55331d9-e339-4284-9c3d-3aff6426350c"), "Service Financier" },
                    { new Guid("301559aa-5be0-4e69-a2b9-8351c4c7f78c"), "Service Industriel" },
                    { new Guid("844e8223-7d2d-4988-b822-07de7f175a8a"), "Service Ressources Humaines" },
                    { new Guid("b2a5afc3-266c-4794-8330-90de21522752"), "Service Achat" },
                    { new Guid("aef43467-ff56-4749-bedc-b6c2237e78cc"), "Service Juridique" }
                });

            migrationBuilder.InsertData(
                table: "Site",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("26419f39-6a27-4054-9630-6f97cb96faa8"), "Site administratif", "Paris" },
                    { new Guid("652bb15d-d7ea-499d-9db7-bc4014443d43"), "Site de Production", "Nantes" },
                    { new Guid("e94d1274-3330-4f50-bab6-c99d142d0c04"), "Site de Production", "Toulouse" },
                    { new Guid("f2230f4c-ac4e-490d-b70a-0bc69974a47f"), "Site de Production", "Nice" },
                    { new Guid("526a9408-c1cc-499e-ab0d-a9379556216d"), "Site de Production", "Lille" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Service",
                keyColumn: "Id",
                keyValue: new Guid("10fedbdd-d5dc-45d8-a06b-2248cd1561ee"));

            migrationBuilder.DeleteData(
                table: "Service",
                keyColumn: "Id",
                keyValue: new Guid("301559aa-5be0-4e69-a2b9-8351c4c7f78c"));

            migrationBuilder.DeleteData(
                table: "Service",
                keyColumn: "Id",
                keyValue: new Guid("844e8223-7d2d-4988-b822-07de7f175a8a"));

            migrationBuilder.DeleteData(
                table: "Service",
                keyColumn: "Id",
                keyValue: new Guid("aef43467-ff56-4749-bedc-b6c2237e78cc"));

            migrationBuilder.DeleteData(
                table: "Service",
                keyColumn: "Id",
                keyValue: new Guid("b0783421-5fb5-4ddc-885c-ca0f742fe935"));

            migrationBuilder.DeleteData(
                table: "Service",
                keyColumn: "Id",
                keyValue: new Guid("b2a5afc3-266c-4794-8330-90de21522752"));

            migrationBuilder.DeleteData(
                table: "Service",
                keyColumn: "Id",
                keyValue: new Guid("f55331d9-e339-4284-9c3d-3aff6426350c"));

            migrationBuilder.DeleteData(
                table: "Site",
                keyColumn: "Id",
                keyValue: new Guid("26419f39-6a27-4054-9630-6f97cb96faa8"));

            migrationBuilder.DeleteData(
                table: "Site",
                keyColumn: "Id",
                keyValue: new Guid("526a9408-c1cc-499e-ab0d-a9379556216d"));

            migrationBuilder.DeleteData(
                table: "Site",
                keyColumn: "Id",
                keyValue: new Guid("652bb15d-d7ea-499d-9db7-bc4014443d43"));

            migrationBuilder.DeleteData(
                table: "Site",
                keyColumn: "Id",
                keyValue: new Guid("e94d1274-3330-4f50-bab6-c99d142d0c04"));

            migrationBuilder.DeleteData(
                table: "Site",
                keyColumn: "Id",
                keyValue: new Guid("f2230f4c-ac4e-490d-b70a-0bc69974a47f"));

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Employe",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "FixePhoneNumber",
                table: "Employe",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Employe",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Employe",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "CellPhoneNumber",
                table: "Employe",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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
    }
}
