using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eCommerce.Migrations
{
    public partial class init65 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("03e0a396-b932-4d58-9ccd-c55e7c5884d0"));

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("7d0f718e-4b3d-4ec3-8455-14359b8ec0af"), new Guid("c01677a1-70c9-491c-ab79-99bab848e3ff") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("f2505051-b349-4dff-8ab9-ed1d322804cc"), new Guid("f38a1449-8274-47db-a58b-7085a2316c0c") });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("906358d0-f527-4696-b2db-1bab8d90249a"));

            migrationBuilder.DeleteData(
                table: "CartDetails",
                keyColumn: "CartDetailId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CartDetails",
                keyColumn: "CartDetailId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PurchaseDetails",
                keyColumn: "PurchaseDetailId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PurchaseDetails",
                keyColumn: "PurchaseDetailId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PurchaseDetails",
                keyColumn: "PurchaseDetailId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "SalesDetails",
                keyColumn: "SalesDetailId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SalesDetails",
                keyColumn: "SalesDetailId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ShippingAddresses",
                keyColumn: "ShippingAddressId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "WisthLists",
                keyColumn: "WishListId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("c01677a1-70c9-491c-ab79-99bab848e3ff"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("f38a1449-8274-47db-a58b-7085a2316c0c"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7d0f718e-4b3d-4ec3-8455-14359b8ec0af"));

            migrationBuilder.DeleteData(
                table: "Carts",
                keyColumn: "CartId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SalesMasters",
                keyColumn: "SalesMasterId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ShippingAddresses",
                keyColumn: "ShippingAddressId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f2505051-b349-4dff-8ab9-ed1d322804cc"));

            migrationBuilder.AddColumn<int>(
                name: "ProductTypeId",
                table: "Products",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ProductType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductType", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("851e5e1d-1786-43b6-8a0d-2d722ed2dea3"), "a961c380-a24f-4c25-a3ec-fc80945a211a", "Super Admin", "SUPER ADMIN" },
                    { new Guid("11c00336-448b-487c-852b-905c9be135ce"), "2b1270e6-416f-498c-8a2a-55e8f5bcb5f0", "Admin", "ADMIN" },
                    { new Guid("c449322c-e99d-41ae-805b-588087339964"), "7084d50e-ac97-4468-9753-4f6c8acea578", "Customer", "CUSTOMER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Photo", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("9fa0ceee-23ef-467c-83de-f033298da8f3"), 0, "569296e8-2b1b-45c5-aa91-14fd304ba48d", "sadmin@sadmin.com", false, null, null, false, null, "SADMIN@SADMIN.COM", null, "AA0Vf0apyYpYVjShVT3ggBSaovzc0JqBj0O7wQ79sfJ9+gq6PuvgoWijg1yL3cNA2g==", null, false, null, null, false, null },
                    { new Guid("6adff31c-2839-41c7-a97e-da1925100985"), 0, "6af77d97-e847-4209-b79c-91f51e0f1f04", "admin@admin.com", false, null, null, false, null, "ADMIN@ADMIN.COM", null, "AJan+8devFIm/PPbeK33KlEc8NroD1D0DcS7yo353GePfRbXRif6ClqqwBPRnSZEig==", null, false, null, null, false, null },
                    { new Guid("2620dc54-3acf-4fcc-98c9-aec883242a3c"), 0, "3c74c591-97ce-47f0-a410-ce07e1162750", "user@user.com", false, null, null, false, null, "USER@USER.COM", null, "AKWmjkjhmYBAwyXPilvVX0Ce/I3R3PfgUi/msqMVSYQFu40Qnd7lZ5SnqUVjU0P+tg==", null, false, null, null, false, null }
                });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 1,
                columns: new[] { "ExpiryDate", "StockDate" },
                values: new object[] { new DateTime(2022, 10, 17, 10, 41, 48, 323, DateTimeKind.Local).AddTicks(6352), new DateTime(2020, 10, 17, 10, 41, 48, 323, DateTimeKind.Local).AddTicks(2710) });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 2,
                columns: new[] { "ExpiryDate", "StockDate" },
                values: new object[] { new DateTime(2022, 10, 17, 10, 41, 48, 323, DateTimeKind.Local).AddTicks(7402), new DateTime(2020, 10, 17, 10, 41, 48, 323, DateTimeKind.Local).AddTicks(7338) });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 3,
                columns: new[] { "ExpiryDate", "StockDate" },
                values: new object[] { new DateTime(2022, 10, 17, 10, 41, 48, 323, DateTimeKind.Local).AddTicks(7427), new DateTime(2020, 10, 17, 10, 41, 48, 323, DateTimeKind.Local).AddTicks(7425) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId", "Discriminator" },
                values: new object[,]
                {
                    { new Guid("9fa0ceee-23ef-467c-83de-f033298da8f3"), new Guid("851e5e1d-1786-43b6-8a0d-2d722ed2dea3"), "UserRoles" },
                    { new Guid("2620dc54-3acf-4fcc-98c9-aec883242a3c"), new Guid("c449322c-e99d-41ae-805b-588087339964"), "UserRoles" }
                });

            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "CustomerId", "Address", "CompanyContact", "CompanyName", "CompanyWebsite", "ContactNo", "DistrictId", "Email", "Name", "ThanaId", "UserId" },
                values: new object[] { 1, "Dhaka", "09876543", "Sr.Company", "sr@c.com", "01678907623", 3, "m@m.com", "Maham", 1, new Guid("2620dc54-3acf-4fcc-98c9-aec883242a3c") });

            migrationBuilder.InsertData(
                table: "PurchaseDetails",
                columns: new[] { "PurchaseDetailId", "ColorId", "Description", "DiscountRate", "EntryBy", "EntryDate", "ExpiryDate", "MasterId", "ModelId", "NetAmount", "ProductCode", "ProductId", "SalesPrice", "SizeId", "TotalPrice", "UnitPrice", "UnitQuantity", "VatRate" },
                values: new object[,]
                {
                    { 1, 1, "dfas", 5m, new Guid("2620dc54-3acf-4fcc-98c9-aec883242a3c"), new DateTime(2020, 10, 17, 10, 41, 48, 322, DateTimeKind.Local).AddTicks(2085), new DateTime(2021, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 565m, "P01", 1, 0m, 1, 4000m, 300m, 65, 3m },
                    { 3, 2, "dfas", 5m, new Guid("2620dc54-3acf-4fcc-98c9-aec883242a3c"), new DateTime(2020, 10, 17, 10, 41, 48, 322, DateTimeKind.Local).AddTicks(7681), new DateTime(2021, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 565m, "P03", 3, 0m, 2, 4000m, 300m, 65, 3m },
                    { 2, 2, "dfas", 5m, new Guid("2620dc54-3acf-4fcc-98c9-aec883242a3c"), new DateTime(2020, 10, 17, 10, 41, 48, 322, DateTimeKind.Local).AddTicks(7396), new DateTime(2020, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 2, 565m, "P02", 2, 0m, 1, 4000m, 300m, 65, 3m }
                });

            migrationBuilder.InsertData(
                table: "Carts",
                columns: new[] { "CartId", "CustomerId" },
                values: new object[] { 1, 1 });

            migrationBuilder.InsertData(
                table: "ShippingAddresses",
                columns: new[] { "ShippingAddressId", "Address", "CurrierId", "CustomerId", "DistrictId", "Name", "Phone", "ThanaId" },
                values: new object[,]
                {
                    { 2, "Khulna", 1, 1, 2, "MR Doe", "01978392903", 2 },
                    { 1, "Dhaka", 1, 1, 1, "Mr ABC", "01789876543", 1 }
                });

            migrationBuilder.InsertData(
                table: "WisthLists",
                columns: new[] { "WishListId", "CustomerId", "ProductId", "Quantity" },
                values: new object[] { 1, 1, 3, 1 });

            migrationBuilder.InsertData(
                table: "CartDetails",
                columns: new[] { "CartDetailId", "CartId", "ProductId", "Quantity" },
                values: new object[] { 2, 1, 2, 3 });

            migrationBuilder.InsertData(
                table: "CartDetails",
                columns: new[] { "CartDetailId", "CartId", "ProductId", "Quantity" },
                values: new object[] { 1, 1, 1, 4 });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderId", "CustomerId", "DeliveryDate", "DeliveryFee", "DeliveryStatus", "OrderDate", "OrderNo", "OrderStatus", "PaymentStatus", "ShippingAddressId", "ShippingDate", "TotalAmount", "TransactionId", "TransactionTime" },
                values: new object[] { 1, 1, new DateTime(2020, 10, 24, 10, 41, 48, 317, DateTimeKind.Local).AddTicks(7312), 50m, 0, new DateTime(2020, 10, 17, 10, 41, 48, 316, DateTimeKind.Local).AddTicks(7818), "ORD202010031", 1, true, 1, new DateTime(2020, 10, 18, 10, 41, 48, 317, DateTimeKind.Local).AddTicks(7877), 500m, "TRX1234567", new DateTime(2020, 10, 17, 10, 41, 48, 318, DateTimeKind.Local).AddTicks(490) });

            migrationBuilder.InsertData(
                table: "SalesMasters",
                columns: new[] { "SalesMasterId", "BillNo", "Note", "OrderId", "SalesDate", "TotalAmount", "TotalPrice", "TotalQuantity", "VoucherNo" },
                values: new object[] { 1, "123", "success", 1, new DateTime(2020, 10, 17, 10, 41, 48, 320, DateTimeKind.Local).AddTicks(3263), 550m, 1000m, 2, "abc" });

            migrationBuilder.InsertData(
                table: "SalesDetails",
                columns: new[] { "SalesDetailId", "ColorId", "DiscountAmount", "DiscountRate", "ModelId", "NetAmount", "ProductId", "SalesMasterId", "SizeId", "UintPrice", "UnitQuantity", "VatAmount", "VatRate" },
                values: new object[] { 2, null, 50m, 5m, null, 450m, 1, 1, null, 400m, 89, 987m, 3m });

            migrationBuilder.InsertData(
                table: "SalesDetails",
                columns: new[] { "SalesDetailId", "ColorId", "DiscountAmount", "DiscountRate", "ModelId", "NetAmount", "ProductId", "SalesMasterId", "SizeId", "UintPrice", "UnitQuantity", "VatAmount", "VatRate" },
                values: new object[] { 1, null, 50m, 5m, null, 550m, 1, 1, null, 676m, 89, 987m, 3m });

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductTypeId",
                table: "Products",
                column: "ProductTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ProductType_ProductTypeId",
                table: "Products",
                column: "ProductTypeId",
                principalTable: "ProductType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_ProductType_ProductTypeId",
                table: "Products");

            migrationBuilder.DropTable(
                name: "ProductType");

            migrationBuilder.DropIndex(
                name: "IX_Products_ProductTypeId",
                table: "Products");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("11c00336-448b-487c-852b-905c9be135ce"));

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("2620dc54-3acf-4fcc-98c9-aec883242a3c"), new Guid("c449322c-e99d-41ae-805b-588087339964") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("9fa0ceee-23ef-467c-83de-f033298da8f3"), new Guid("851e5e1d-1786-43b6-8a0d-2d722ed2dea3") });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6adff31c-2839-41c7-a97e-da1925100985"));

            migrationBuilder.DeleteData(
                table: "CartDetails",
                keyColumn: "CartDetailId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CartDetails",
                keyColumn: "CartDetailId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PurchaseDetails",
                keyColumn: "PurchaseDetailId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PurchaseDetails",
                keyColumn: "PurchaseDetailId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PurchaseDetails",
                keyColumn: "PurchaseDetailId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "SalesDetails",
                keyColumn: "SalesDetailId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SalesDetails",
                keyColumn: "SalesDetailId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ShippingAddresses",
                keyColumn: "ShippingAddressId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "WisthLists",
                keyColumn: "WishListId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("851e5e1d-1786-43b6-8a0d-2d722ed2dea3"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("c449322c-e99d-41ae-805b-588087339964"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9fa0ceee-23ef-467c-83de-f033298da8f3"));

            migrationBuilder.DeleteData(
                table: "Carts",
                keyColumn: "CartId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SalesMasters",
                keyColumn: "SalesMasterId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ShippingAddresses",
                keyColumn: "ShippingAddressId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2620dc54-3acf-4fcc-98c9-aec883242a3c"));

            migrationBuilder.DropColumn(
                name: "ProductTypeId",
                table: "Products");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("c01677a1-70c9-491c-ab79-99bab848e3ff"), "6ef7aa69-95f2-42b5-aae1-416581aab078", "Super Admin", "SUPER ADMIN" },
                    { new Guid("03e0a396-b932-4d58-9ccd-c55e7c5884d0"), "ef5442c6-2de9-4f0a-9c69-c71fe27780f8", "Admin", "ADMIN" },
                    { new Guid("f38a1449-8274-47db-a58b-7085a2316c0c"), "aa2bf162-238b-4648-a68d-7b9ea3863c9b", "Customer", "CUSTOMER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Photo", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("7d0f718e-4b3d-4ec3-8455-14359b8ec0af"), 0, "3a3d98ef-da08-4f97-8426-44706c3e4b0d", "sadmin@sadmin.com", false, null, null, false, null, "SADMIN@SADMIN.COM", null, "ACT8TxTJSmDFfTfQ55koDpZUpS4MeZJ9Y8CNaYI5QjMqxfMiE6k8NfXNpHMTWJKJmg==", null, false, null, null, false, null },
                    { new Guid("906358d0-f527-4696-b2db-1bab8d90249a"), 0, "69703d9a-7781-40da-bdda-85fd8c268e5a", "admin@admin.com", false, null, null, false, null, "ADMIN@ADMIN.COM", null, "AEzymPEBRi3YkyyZeNfDeBuIEXJ158K0bQOxZla0yDcw8a0kWutwjXTun4llo+GXvQ==", null, false, null, null, false, null },
                    { new Guid("f2505051-b349-4dff-8ab9-ed1d322804cc"), 0, "726dbabf-953d-4c0b-9d13-8cd981d6a8d6", "user@user.com", false, null, null, false, null, "USER@USER.COM", null, "AIkafaJ1eerH5XchHd6fc2Lj6WlnwolNLQAJdbOLT+P9XuwrrJT9r/0HRGrBKWAL1w==", null, false, null, null, false, null }
                });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 1,
                columns: new[] { "ExpiryDate", "StockDate" },
                values: new object[] { new DateTime(2022, 10, 8, 2, 33, 36, 452, DateTimeKind.Local).AddTicks(5601), new DateTime(2020, 10, 8, 2, 33, 36, 452, DateTimeKind.Local).AddTicks(2816) });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 2,
                columns: new[] { "ExpiryDate", "StockDate" },
                values: new object[] { new DateTime(2022, 10, 8, 2, 33, 36, 452, DateTimeKind.Local).AddTicks(6371), new DateTime(2020, 10, 8, 2, 33, 36, 452, DateTimeKind.Local).AddTicks(6297) });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 3,
                columns: new[] { "ExpiryDate", "StockDate" },
                values: new object[] { new DateTime(2022, 10, 8, 2, 33, 36, 452, DateTimeKind.Local).AddTicks(6405), new DateTime(2020, 10, 8, 2, 33, 36, 452, DateTimeKind.Local).AddTicks(6402) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId", "Discriminator" },
                values: new object[,]
                {
                    { new Guid("7d0f718e-4b3d-4ec3-8455-14359b8ec0af"), new Guid("c01677a1-70c9-491c-ab79-99bab848e3ff"), "UserRoles" },
                    { new Guid("f2505051-b349-4dff-8ab9-ed1d322804cc"), new Guid("f38a1449-8274-47db-a58b-7085a2316c0c"), "UserRoles" }
                });

            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "CustomerId", "Address", "CompanyContact", "CompanyName", "CompanyWebsite", "ContactNo", "DistrictId", "Email", "Name", "ThanaId", "UserId" },
                values: new object[] { 1, "Dhaka", "09876543", "Sr.Company", "sr@c.com", "01678907623", 3, "m@m.com", "Maham", 1, new Guid("f2505051-b349-4dff-8ab9-ed1d322804cc") });

            migrationBuilder.InsertData(
                table: "PurchaseDetails",
                columns: new[] { "PurchaseDetailId", "ColorId", "Description", "DiscountRate", "EntryBy", "EntryDate", "ExpiryDate", "MasterId", "ModelId", "NetAmount", "ProductCode", "ProductId", "SalesPrice", "SizeId", "TotalPrice", "UnitPrice", "UnitQuantity", "VatRate" },
                values: new object[,]
                {
                    { 1, 1, "dfas", 5m, new Guid("f2505051-b349-4dff-8ab9-ed1d322804cc"), new DateTime(2020, 10, 8, 2, 33, 36, 451, DateTimeKind.Local).AddTicks(5807), new DateTime(2021, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 565m, "P01", 1, 0m, 1, 4000m, 300m, 65, 3m },
                    { 3, 2, "dfas", 5m, new Guid("f2505051-b349-4dff-8ab9-ed1d322804cc"), new DateTime(2020, 10, 8, 2, 33, 36, 451, DateTimeKind.Local).AddTicks(8938), new DateTime(2021, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 565m, "P03", 3, 0m, 2, 4000m, 300m, 65, 3m },
                    { 2, 2, "dfas", 5m, new Guid("f2505051-b349-4dff-8ab9-ed1d322804cc"), new DateTime(2020, 10, 8, 2, 33, 36, 451, DateTimeKind.Local).AddTicks(8795), new DateTime(2020, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 2, 565m, "P02", 2, 0m, 1, 4000m, 300m, 65, 3m }
                });

            migrationBuilder.InsertData(
                table: "Carts",
                columns: new[] { "CartId", "CustomerId" },
                values: new object[] { 1, 1 });

            migrationBuilder.InsertData(
                table: "ShippingAddresses",
                columns: new[] { "ShippingAddressId", "Address", "CurrierId", "CustomerId", "DistrictId", "Name", "Phone", "ThanaId" },
                values: new object[,]
                {
                    { 2, "Khulna", 1, 1, 2, "MR Doe", "01978392903", 2 },
                    { 1, "Dhaka", 1, 1, 1, "Mr ABC", "01789876543", 1 }
                });

            migrationBuilder.InsertData(
                table: "WisthLists",
                columns: new[] { "WishListId", "CustomerId", "ProductId", "Quantity" },
                values: new object[] { 1, 1, 3, 1 });

            migrationBuilder.InsertData(
                table: "CartDetails",
                columns: new[] { "CartDetailId", "CartId", "ProductId", "Quantity" },
                values: new object[] { 2, 1, 2, 3 });

            migrationBuilder.InsertData(
                table: "CartDetails",
                columns: new[] { "CartDetailId", "CartId", "ProductId", "Quantity" },
                values: new object[] { 1, 1, 1, 4 });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderId", "CustomerId", "DeliveryDate", "DeliveryFee", "DeliveryStatus", "OrderDate", "OrderNo", "OrderStatus", "PaymentStatus", "ShippingAddressId", "ShippingDate", "TotalAmount", "TransactionId", "TransactionTime" },
                values: new object[] { 1, 1, new DateTime(2020, 10, 15, 2, 33, 36, 448, DateTimeKind.Local).AddTicks(7142), 50m, 0, new DateTime(2020, 10, 8, 2, 33, 36, 447, DateTimeKind.Local).AddTicks(911), "ORD202010031", 1, true, 1, new DateTime(2020, 10, 9, 2, 33, 36, 448, DateTimeKind.Local).AddTicks(7621), 500m, "TRX1234567", new DateTime(2020, 10, 8, 2, 33, 36, 448, DateTimeKind.Local).AddTicks(9042) });

            migrationBuilder.InsertData(
                table: "SalesMasters",
                columns: new[] { "SalesMasterId", "BillNo", "Note", "OrderId", "SalesDate", "TotalAmount", "TotalPrice", "TotalQuantity", "VoucherNo" },
                values: new object[] { 1, "123", "success", 1, new DateTime(2020, 10, 8, 2, 33, 36, 450, DateTimeKind.Local).AddTicks(936), 550m, 1000m, 2, "abc" });

            migrationBuilder.InsertData(
                table: "SalesDetails",
                columns: new[] { "SalesDetailId", "ColorId", "DiscountAmount", "DiscountRate", "ModelId", "NetAmount", "ProductId", "SalesMasterId", "SizeId", "UintPrice", "UnitQuantity", "VatAmount", "VatRate" },
                values: new object[] { 2, null, 50m, 5m, null, 450m, 1, 1, null, 400m, 89, 987m, 3m });

            migrationBuilder.InsertData(
                table: "SalesDetails",
                columns: new[] { "SalesDetailId", "ColorId", "DiscountAmount", "DiscountRate", "ModelId", "NetAmount", "ProductId", "SalesMasterId", "SizeId", "UintPrice", "UnitQuantity", "VatAmount", "VatRate" },
                values: new object[] { 1, null, 50m, 5m, null, 550m, 1, 1, null, 676m, 89, 987m, 3m });
        }
    }
}
