using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API_150122.Migrations
{
    public partial class IntialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    mobile_no = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Item_Types",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Item_Types", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Uoms",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uoms", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Vendors",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    address = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vendors", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Sales",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    date_of_sale = table.Column<DateTime>(type: "datetime2", nullable: false),
                    customer_id = table.Column<int>(type: "int", nullable: false),
                    sale_no = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Customer_objid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sales", x => x.id);
                    table.ForeignKey(
                        name: "FK_Sales_Customers_Customer_objid",
                        column: x => x.Customer_objid,
                        principalTable: "Customers",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    uom_id = table.Column<int>(type: "int", nullable: false),
                    item_type_id = table.Column<int>(type: "int", nullable: false),
                    Item_Type_objid = table.Column<int>(type: "int", nullable: true),
                    Uom_objid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.id);
                    table.ForeignKey(
                        name: "FK_Items_Item_Types_Item_Type_objid",
                        column: x => x.Item_Type_objid,
                        principalTable: "Item_Types",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_Items_Uoms_Uom_objid",
                        column: x => x.Uom_objid,
                        principalTable: "Uoms",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "Purchases",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    date_of_purchase = table.Column<DateTime>(type: "datetime2", nullable: false),
                    vendor_id = table.Column<int>(type: "int", nullable: false),
                    bill_no = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Vendor_objid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Purchases", x => x.id);
                    table.ForeignKey(
                        name: "FK_Purchases_Vendors_Vendor_objid",
                        column: x => x.Vendor_objid,
                        principalTable: "Vendors",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "Sale_Entries",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    sale_id = table.Column<int>(type: "int", nullable: false),
                    item_id = table.Column<int>(type: "int", nullable: false),
                    qty = table.Column<double>(type: "float", nullable: false),
                    rate = table.Column<double>(type: "float", nullable: false),
                    Sale_objid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sale_Entries", x => x.id);
                    table.ForeignKey(
                        name: "FK_Sale_Entries_Sales_Sale_objid",
                        column: x => x.Sale_objid,
                        principalTable: "Sales",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "Purchase_Entries",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    purchase_id = table.Column<int>(type: "int", nullable: false),
                    item_id = table.Column<int>(type: "int", nullable: false),
                    rate = table.Column<double>(type: "float", nullable: false),
                    qty = table.Column<double>(type: "float", nullable: false),
                    Purchase_objid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Purchase_Entries", x => x.id);
                    table.ForeignKey(
                        name: "FK_Purchase_Entries_Purchases_Purchase_objid",
                        column: x => x.Purchase_objid,
                        principalTable: "Purchases",
                        principalColumn: "id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Items_Item_Type_objid",
                table: "Items",
                column: "Item_Type_objid");

            migrationBuilder.CreateIndex(
                name: "IX_Items_Uom_objid",
                table: "Items",
                column: "Uom_objid");

            migrationBuilder.CreateIndex(
                name: "IX_Purchase_Entries_Purchase_objid",
                table: "Purchase_Entries",
                column: "Purchase_objid");

            migrationBuilder.CreateIndex(
                name: "IX_Purchases_Vendor_objid",
                table: "Purchases",
                column: "Vendor_objid");

            migrationBuilder.CreateIndex(
                name: "IX_Sale_Entries_Sale_objid",
                table: "Sale_Entries",
                column: "Sale_objid");

            migrationBuilder.CreateIndex(
                name: "IX_Sales_Customer_objid",
                table: "Sales",
                column: "Customer_objid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "Purchase_Entries");

            migrationBuilder.DropTable(
                name: "Sale_Entries");

            migrationBuilder.DropTable(
                name: "Item_Types");

            migrationBuilder.DropTable(
                name: "Uoms");

            migrationBuilder.DropTable(
                name: "Purchases");

            migrationBuilder.DropTable(
                name: "Sales");

            migrationBuilder.DropTable(
                name: "Vendors");

            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
