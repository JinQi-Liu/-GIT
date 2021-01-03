using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyProject.Migrations
{
    public partial class addAuthGroupsAndHREmployeeInfos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Auth_Group",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GroupName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Auth_Group", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "HR_EmployeeInfo",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HR_EmployeeInfo", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Auth_GroupEmployeeInfo",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AuthGroupID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HREmployeeInfoID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Auth_GroupEmployeeInfo", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Auth_GroupEmployeeInfo_Auth_Group_AuthGroupID",
                        column: x => x.AuthGroupID,
                        principalTable: "Auth_Group",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Auth_GroupEmployeeInfo_HR_EmployeeInfo_HREmployeeInfoID",
                        column: x => x.HREmployeeInfoID,
                        principalTable: "HR_EmployeeInfo",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Auth_GroupEmployeeInfo_AuthGroupID",
                table: "Auth_GroupEmployeeInfo",
                column: "AuthGroupID");

            migrationBuilder.CreateIndex(
                name: "IX_Auth_GroupEmployeeInfo_HREmployeeInfoID",
                table: "Auth_GroupEmployeeInfo",
                column: "HREmployeeInfoID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Auth_GroupEmployeeInfo");

            migrationBuilder.DropTable(
                name: "Auth_Group");

            migrationBuilder.DropTable(
                name: "HR_EmployeeInfo");
        }
    }
}
