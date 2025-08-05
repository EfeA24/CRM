using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Crm.Infrastructure.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BaseEntities",
                columns: table => new
                {
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    CompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompanyTag = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyAddressLine1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyAddressLine2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyCity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyCountry = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyPhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.CompanyId);
                });

            migrationBuilder.CreateTable(
                name: "PurchaseOffers",
                columns: table => new
                {
                    PurchaseOfferId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PurchaseOfferName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PurchaseOfferNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PurchaseOfferDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PurchaseOfferType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PurchaseOfferStatus = table.Column<bool>(type: "bit", nullable: true),
                    PurchaseOfferCurrency = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PurchaseOfferTotalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PurchaseOfferPriority = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PurchaseOfferDate = table.Column<DateOnly>(type: "date", nullable: true),
                    PurchaseOfferDueDate = table.Column<DateOnly>(type: "date", nullable: true),
                    PurchaseOfferCreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PurchaseOfferUpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PurchaseOfferCreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PurchaseOfferUpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseOffers", x => x.PurchaseOfferId);
                    table.ForeignKey(
                        name: "FK_PurchaseOffers_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "CompanyId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SalesOffers",
                columns: table => new
                {
                    SalesOfferId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SalesOfferName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SalesOfferNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SalesOfferDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SalesOfferType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SalesOfferStatus = table.Column<bool>(type: "bit", nullable: true),
                    SalesOfferPriority = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SalesOfferDate = table.Column<DateOnly>(type: "date", nullable: true),
                    SalesOfferDueDate = table.Column<DateOnly>(type: "date", nullable: true),
                    SalesOfferCreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SalesOfferUpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SalesOfferCreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SalesOfferUpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesOffers", x => x.SalesOfferId);
                    table.ForeignKey(
                        name: "FK_SalesOffers_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "CompanyId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PurchaseOfferProducts",
                columns: table => new
                {
                    PurchaseOfferProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PurchaseOfferProductName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PurchaseOfferProductDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PurchaseOfferProductPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PurchaseOfferProductCurrency = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PurchaseOfferProductQuantity = table.Column<int>(type: "int", nullable: true),
                    PurchaseOfferProductCreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PurchaseOfferProductUpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PurchaseOfferProductCreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PurchaseOfferProductUpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PurchaseOfferId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseOfferProducts", x => x.PurchaseOfferProductId);
                    table.ForeignKey(
                        name: "FK_PurchaseOfferProducts_PurchaseOffers_PurchaseOfferId",
                        column: x => x.PurchaseOfferId,
                        principalTable: "PurchaseOffers",
                        principalColumn: "PurchaseOfferId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    ContactId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Position = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Department = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    PurchaseOfferId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SalesOfferId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.ContactId);
                    table.ForeignKey(
                        name: "FK_Contacts_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "CompanyId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Contacts_PurchaseOffers_PurchaseOfferId",
                        column: x => x.PurchaseOfferId,
                        principalTable: "PurchaseOffers",
                        principalColumn: "PurchaseOfferId");
                    table.ForeignKey(
                        name: "FK_Contacts_SalesOffers_SalesOfferId",
                        column: x => x.SalesOfferId,
                        principalTable: "SalesOffers",
                        principalColumn: "SalesOfferId");
                });

            migrationBuilder.CreateTable(
                name: "SalesOfferProducts",
                columns: table => new
                {
                    SalesOfferProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SalesOfferProductName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SalesOfferProductDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Currency = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SalesOfferProductPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    SalesOfferProductQuantity = table.Column<int>(type: "int", nullable: true),
                    SalesOfferProductCreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SalesOfferProductUpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SalesOfferProductCreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SalesOfferProductUpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SalesOfferId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesOfferProducts", x => x.SalesOfferProductId);
                    table.ForeignKey(
                        name: "FK_SalesOfferProducts_SalesOffers_SalesOfferId",
                        column: x => x.SalesOfferId,
                        principalTable: "SalesOffers",
                        principalColumn: "SalesOfferId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Meetings",
                columns: table => new
                {
                    MeetingId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Subject = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MeetingType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ContactId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Meetings", x => x.MeetingId);
                    table.ForeignKey(
                        name: "FK_Meetings_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "CompanyId");
                    table.ForeignKey(
                        name: "FK_Meetings_Contacts_ContactId",
                        column: x => x.ContactId,
                        principalTable: "Contacts",
                        principalColumn: "ContactId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_CompanyId",
                table: "Contacts",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_PurchaseOfferId",
                table: "Contacts",
                column: "PurchaseOfferId");

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_SalesOfferId",
                table: "Contacts",
                column: "SalesOfferId");

            migrationBuilder.CreateIndex(
                name: "IX_Meetings_CompanyId",
                table: "Meetings",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Meetings_ContactId",
                table: "Meetings",
                column: "ContactId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseOfferProducts_PurchaseOfferId",
                table: "PurchaseOfferProducts",
                column: "PurchaseOfferId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseOffers_CompanyId",
                table: "PurchaseOffers",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesOfferProducts_SalesOfferId",
                table: "SalesOfferProducts",
                column: "SalesOfferId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesOffers_CompanyId",
                table: "SalesOffers",
                column: "CompanyId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BaseEntities");

            migrationBuilder.DropTable(
                name: "Meetings");

            migrationBuilder.DropTable(
                name: "PurchaseOfferProducts");

            migrationBuilder.DropTable(
                name: "SalesOfferProducts");

            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "PurchaseOffers");

            migrationBuilder.DropTable(
                name: "SalesOffers");

            migrationBuilder.DropTable(
                name: "Companies");
        }
    }
}
