using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace EFcorepractice.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AccountRole",
                columns: table => new
                {
                    accountroleid = table.Column<long>(name: "account_role_id", type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    value = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountRole", x => x.accountroleid);
                });

            migrationBuilder.CreateTable(
                name: "Country",
                columns: table => new
                {
                    countryid = table.Column<long>(name: "country_id", type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "character varying(40)", maxLength: 40, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Country", x => x.countryid);
                });

            migrationBuilder.CreateTable(
                name: "Department",
                columns: table => new
                {
                    departmentid = table.Column<long>(name: "department_id", type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    title = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Department", x => x.departmentid);
                });

            migrationBuilder.CreateTable(
                name: "Gender",
                columns: table => new
                {
                    genderid = table.Column<long>(name: "gender_id", type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    type = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gender", x => x.genderid);
                });

            migrationBuilder.CreateTable(
                name: "WorkPlace",
                columns: table => new
                {
                    workplaceid = table.Column<long>(name: "work_place_id", type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    isSelfMadehardware = table.Column<bool>(name: "isSelfMade_hardware", type: "boolean", nullable: false),
                    name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkPlace", x => x.workplaceid);
                });

            migrationBuilder.CreateTable(
                name: "CorpAccount",
                columns: table => new
                {
                    corpaccountid = table.Column<long>(name: "corp_account_id", type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    login = table.Column<string>(type: "text", nullable: false),
                    password = table.Column<string>(type: "text", nullable: false),
                    accountroleid = table.Column<long>(name: "account_role_id", type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CorpAccount", x => x.corpaccountid);
                    table.ForeignKey(
                        name: "FK_CorpAccount_AccountRole_account_role_id",
                        column: x => x.accountroleid,
                        principalTable: "AccountRole",
                        principalColumn: "account_role_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "City",
                columns: table => new
                {
                    cityid = table.Column<long>(name: "city_id", type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "character varying(40)", maxLength: 40, nullable: false),
                    countryid = table.Column<long>(name: "country_id", type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_City", x => x.cityid);
                    table.ForeignKey(
                        name: "FK_City_Country_country_id",
                        column: x => x.countryid,
                        principalTable: "Country",
                        principalColumn: "country_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Position",
                columns: table => new
                {
                    positionid = table.Column<long>(name: "position_id", type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    title = table.Column<string>(type: "text", nullable: false),
                    departmentid = table.Column<long>(name: "department_id", type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Position", x => x.positionid);
                    table.ForeignKey(
                        name: "FK_Position_Department_department_id",
                        column: x => x.departmentid,
                        principalTable: "Department",
                        principalColumn: "department_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Person",
                columns: table => new
                {
                    personid = table.Column<long>(name: "person_id", type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    firstname = table.Column<string>(name: "first_name", type: "character varying(40)", maxLength: 40, nullable: false),
                    lastname = table.Column<string>(name: "last_name", type: "character varying(40)", maxLength: 40, nullable: false),
                    birthdate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    phonenumber = table.Column<string>(name: "phone_number", type: "character varying(20)", maxLength: 20, nullable: false),
                    email = table.Column<string>(type: "character varying(40)", maxLength: 40, nullable: false),
                    genderid = table.Column<long>(name: "gender_id", type: "bigint", nullable: false),
                    cityid = table.Column<long>(name: "city_id", type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => x.personid);
                    table.ForeignKey(
                        name: "FK_Person_City_city_id",
                        column: x => x.cityid,
                        principalTable: "City",
                        principalColumn: "city_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Person_Gender_gender_id",
                        column: x => x.genderid,
                        principalTable: "Gender",
                        principalColumn: "gender_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    Employeeid = table.Column<long>(name: "Employee_id", type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    hiredate = table.Column<DateTime>(name: "hire_date", type: "timestamp with time zone", nullable: false),
                    salary = table.Column<decimal>(type: "numeric", nullable: false),
                    workTimeperWeek = table.Column<double>(name: "workTime_perWeek", type: "double precision", nullable: false),
                    IsWorkingNow = table.Column<bool>(type: "boolean", nullable: false),
                    positionid = table.Column<long>(name: "position_id", type: "bigint", nullable: false),
                    workplaceid = table.Column<long>(name: "work_place_id", type: "bigint", nullable: false),
                    corpaccountid = table.Column<long>(name: "corp_account_id", type: "bigint", nullable: false),
                    personid = table.Column<long>(name: "person_id", type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.Employeeid);
                    table.CheckConstraint("CK_Employee_salary", "\"salary\" > 0");
                    table.CheckConstraint("CK_Employee_workTime_perWeek", "\"workTime_perWeek\" > 0");
                    table.ForeignKey(
                        name: "FK_Employee_CorpAccount_corp_account_id",
                        column: x => x.corpaccountid,
                        principalTable: "CorpAccount",
                        principalColumn: "corp_account_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Employee_Person_person_id",
                        column: x => x.personid,
                        principalTable: "Person",
                        principalColumn: "person_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Employee_Position_position_id",
                        column: x => x.positionid,
                        principalTable: "Position",
                        principalColumn: "position_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Employee_WorkPlace_work_place_id",
                        column: x => x.workplaceid,
                        principalTable: "WorkPlace",
                        principalColumn: "work_place_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_City_country_id",
                table: "City",
                column: "country_id");

            migrationBuilder.CreateIndex(
                name: "IX_CorpAccount_account_role_id",
                table: "CorpAccount",
                column: "account_role_id");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_corp_account_id",
                table: "Employee",
                column: "corp_account_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Employee_person_id",
                table: "Employee",
                column: "person_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Employee_position_id",
                table: "Employee",
                column: "position_id");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_work_place_id",
                table: "Employee",
                column: "work_place_id");

            migrationBuilder.CreateIndex(
                name: "IX_Person_city_id",
                table: "Person",
                column: "city_id");

            migrationBuilder.CreateIndex(
                name: "IX_Person_gender_id",
                table: "Person",
                column: "gender_id");

            migrationBuilder.CreateIndex(
                name: "IX_Position_department_id",
                table: "Position",
                column: "department_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropTable(
                name: "CorpAccount");

            migrationBuilder.DropTable(
                name: "Person");

            migrationBuilder.DropTable(
                name: "Position");

            migrationBuilder.DropTable(
                name: "WorkPlace");

            migrationBuilder.DropTable(
                name: "AccountRole");

            migrationBuilder.DropTable(
                name: "City");

            migrationBuilder.DropTable(
                name: "Gender");

            migrationBuilder.DropTable(
                name: "Department");

            migrationBuilder.DropTable(
                name: "Country");
        }
    }
}
