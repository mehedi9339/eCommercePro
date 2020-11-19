using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eCommerce.Migrations
{
    public partial class init3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("0269c152-8e5b-4186-a6e1-de231b91dc85"));

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("d453617f-c64d-4948-9f83-9c2322da8ae9"), new Guid("131724ce-c407-4447-8d38-2025c9af4288") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("db49401b-97c7-4d76-8ce5-f85d6c5e9df8"), new Guid("e68998eb-abbb-41c9-8d5a-d4dc9efdada1") });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a2495688-c8b8-4946-8155-6be7e4687b2e"));

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
                keyValue: new Guid("131724ce-c407-4447-8d38-2025c9af4288"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("e68998eb-abbb-41c9-8d5a-d4dc9efdada1"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("db49401b-97c7-4d76-8ce5-f85d6c5e9df8"));

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
                keyValue: new Guid("d453617f-c64d-4948-9f83-9c2322da8ae9"));

            migrationBuilder.DropColumn(
                name: "PurchasePrice",
                table: "PurchaseDetails");

            migrationBuilder.AddColumn<decimal>(
                name: "UnitPrice",
                table: "PurchaseDetails",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("b6834af0-20e8-4590-a710-6e67ac02f044"), "329a2e97-587a-4e83-8096-a28dcf5ab5a5", "Super Admin", "SUPER ADMIN" },
                    { new Guid("96618171-d87a-446b-a4f8-8e84249b6f70"), "c1b185ef-3a13-4a66-a4a5-1f9406961c07", "Admin", "ADMIN" },
                    { new Guid("a3671c8d-7fc5-4b9d-b997-0041c65bd955"), "cd2b84a7-43db-4f28-8fa9-ea3cfd9a42bd", "Customer", "CUSTOMER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Photo", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("6e965e2e-228e-4af7-9948-c73ea61453ae"), 0, "c5a92898-f1d3-4cb5-b849-a01e4ba90e07", "sadmin@sadmin.com", false, null, null, false, null, "SADMIN@SADMIN.COM", null, "AMrRmL4Lze8QAe6tyvx24SYKiw8ZvTO1qO25JjyewvI2ILnrjS4zbUeOVFTfvtyRBQ==", null, false, null, null, false, null },
                    { new Guid("5235c4f6-fc30-4937-b870-bfa235bc4cde"), 0, "85b6db99-d218-4d12-8567-bee4d70d6ee2", "admin@admin.com", false, null, null, false, null, "ADMIN@ADMIN.COM", null, "ADjo7/rizpTZyk2+QixF1ONO1xFd9Zl1kORVPmnVyHILIZBVZhEASTuqCIo3vbSbbQ==", null, false, null, null, false, null },
                    { new Guid("c21ed946-8de0-49bd-b16b-7e842f064a88"), 0, "2b2d7489-f983-4888-94a0-0bc2da015c83", "user@user.com", false, null, null, false, null, "USER@USER.COM", null, "ANe3sdx+hi2fB5s1GwHW2DqWlPJbX8qFUPgQpYQD8q5FEfN8PAbOdBwO+ID5sRfGRA==", null, false, null, null, false, null }
                });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 1,
                columns: new[] { "ExpiryDate", "StockDate" },
                values: new object[] { new DateTime(2022, 10, 6, 10, 15, 52, 972, DateTimeKind.Local).AddTicks(4323), new DateTime(2020, 10, 6, 10, 15, 52, 972, DateTimeKind.Local).AddTicks(568) });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 2,
                columns: new[] { "ExpiryDate", "StockDate" },
                values: new object[] { new DateTime(2022, 10, 6, 10, 15, 52, 972, DateTimeKind.Local).AddTicks(5385), new DateTime(2020, 10, 6, 10, 15, 52, 972, DateTimeKind.Local).AddTicks(5323) });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 3,
                columns: new[] { "ExpiryDate", "StockDate" },
                values: new object[] { new DateTime(2022, 10, 6, 10, 15, 52, 972, DateTimeKind.Local).AddTicks(5412), new DateTime(2020, 10, 6, 10, 15, 52, 972, DateTimeKind.Local).AddTicks(5410) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId", "Discriminator" },
                values: new object[,]
                {
                    { new Guid("6e965e2e-228e-4af7-9948-c73ea61453ae"), new Guid("b6834af0-20e8-4590-a710-6e67ac02f044"), "UserRoles" },
                    { new Guid("c21ed946-8de0-49bd-b16b-7e842f064a88"), new Guid("a3671c8d-7fc5-4b9d-b997-0041c65bd955"), "UserRoles" }
                });

            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "CustomerId", "Address", "CompanyContact", "CompanyName", "CompanyWebsite", "ContactNo", "DistrictId", "Email", "Name", "ThanaId", "UserId" },
                values: new object[] { 1, "Dhaka", "09876543", "Sr.Company", "sr@c.com", "01678907623", 3, "m@m.com", "Maham", 1, new Guid("c21ed946-8de0-49bd-b16b-7e842f064a88") });

            migrationBuilder.InsertData(
                table: "PurchaseDetails",
                columns: new[] { "PurchaseDetailId", "ColorId", "Description", "DiscountRate", "EntryBy", "EntryDate", "ExpiryDate", "MasterId", "ModelId", "NetAmount", "ProductCode", "ProductId", "SizeId", "TotalPrice", "UnitPrice", "UnitQuantity", "VatRate" },
                values: new object[,]
                {
                    { 1, 1, "dfas", 5m, new Guid("c21ed946-8de0-49bd-b16b-7e842f064a88"), new DateTime(2020, 10, 6, 10, 15, 52, 971, DateTimeKind.Local).AddTicks(1544), new DateTime(2021, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 565m, "P01", 1, 1, 4000m, 300m, 65, 3m },
                    { 3, 2, "dfas", 5m, new Guid("c21ed946-8de0-49bd-b16b-7e842f064a88"), new DateTime(2020, 10, 6, 10, 15, 52, 971, DateTimeKind.Local).AddTicks(5985), new DateTime(2021, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 565m, "P03", 3, 2, 4000m, 300m, 65, 3m },
                    { 2, 2, "dfas", 5m, new Guid("c21ed946-8de0-49bd-b16b-7e842f064a88"), new DateTime(2020, 10, 6, 10, 15, 52, 971, DateTimeKind.Local).AddTicks(5880), new DateTime(2020, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 2, 565m, "P02", 2, 1, 4000m, 300m, 65, 3m }
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
                values: new object[] { 1, 1, new DateTime(2020, 10, 13, 10, 15, 52, 967, DateTimeKind.Local).AddTicks(4904), 50m, 0, new DateTime(2020, 10, 6, 10, 15, 52, 966, DateTimeKind.Local).AddTicks(4449), "ORD202010031", 1, true, 1, new DateTime(2020, 10, 7, 10, 15, 52, 967, DateTimeKind.Local).AddTicks(5463), 500m, "TRX1234567", new DateTime(2020, 10, 6, 10, 15, 52, 967, DateTimeKind.Local).AddTicks(7265) });

            migrationBuilder.InsertData(
                table: "SalesMasters",
                columns: new[] { "SalesMasterId", "BillNo", "Note", "OrderId", "SalesDate", "TotalAmount", "TotalPrice", "TotalQuantity", "VoucherNo" },
                values: new object[] { 1, "123", "success", 1, new DateTime(2020, 10, 6, 10, 15, 52, 969, DateTimeKind.Local).AddTicks(3103), 550m, 1000m, 2, "abc" });

            migrationBuilder.InsertData(
                table: "SalesDetails",
                columns: new[] { "SalesDetailId", "DiscountAmount", "DiscountRate", "NetAmount", "ProductId", "SalesMasterId", "UintPrice", "UnitQuantity", "VatAmount", "VatRate" },
                values: new object[] { 2, 50m, 5m, 450m, 1, 1, 400m, 89, 987m, 3m });

            migrationBuilder.InsertData(
                table: "SalesDetails",
                columns: new[] { "SalesDetailId", "DiscountAmount", "DiscountRate", "NetAmount", "ProductId", "SalesMasterId", "UintPrice", "UnitQuantity", "VatAmount", "VatRate" },
                values: new object[] { 1, 50m, 5m, 550m, 1, 1, 676m, 89, 987m, 3m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("96618171-d87a-446b-a4f8-8e84249b6f70"));

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("6e965e2e-228e-4af7-9948-c73ea61453ae"), new Guid("b6834af0-20e8-4590-a710-6e67ac02f044") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("c21ed946-8de0-49bd-b16b-7e842f064a88"), new Guid("a3671c8d-7fc5-4b9d-b997-0041c65bd955") });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("5235c4f6-fc30-4937-b870-bfa235bc4cde"));

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
                keyValue: new Guid("a3671c8d-7fc5-4b9d-b997-0041c65bd955"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("b6834af0-20e8-4590-a710-6e67ac02f044"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6e965e2e-228e-4af7-9948-c73ea61453ae"));

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
                keyValue: new Guid("c21ed946-8de0-49bd-b16b-7e842f064a88"));

            migrationBuilder.DropColumn(
                name: "UnitPrice",
                table: "PurchaseDetails");

            migrationBuilder.AddColumn<decimal>(
                name: "PurchasePrice",
                table: "PurchaseDetails",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("e68998eb-abbb-41c9-8d5a-d4dc9efdada1"), "604f0260-51ca-4734-acd7-fae73ef6892a", "Super Admin", "SUPER ADMIN" },
                    { new Guid("0269c152-8e5b-4186-a6e1-de231b91dc85"), "dd175709-41ec-490b-9c93-a67780b4503d", "Admin", "ADMIN" },
                    { new Guid("131724ce-c407-4447-8d38-2025c9af4288"), "7eb1c614-2e00-49c2-b95d-44ad18913e8f", "Customer", "CUSTOMER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Photo", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("db49401b-97c7-4d76-8ce5-f85d6c5e9df8"), 0, "5126d111-376c-41e8-be5c-be4201784701", "sadmin@sadmin.com", false, null, null, false, null, "SADMIN@SADMIN.COM", null, "AI1C+rd0letAGWliQYtQ0ZcIJsOlvlkx8zMNrfuRZTSA6ZHOjQE5Nxa5hTyf5gltRw==", null, false, null, null, false, null },
                    { new Guid("a2495688-c8b8-4946-8155-6be7e4687b2e"), 0, "e80b73b4-4631-4553-9c08-9a89fe65073f", "admin@admin.com", false, null, null, false, null, "ADMIN@ADMIN.COM", null, "AErfNGjiejtD0RTQrxI2Y5IUS6QOo92RnbByFdyZQ92wDNdYEQSBRZyy01ygyXKWwQ==", null, false, null, null, false, null },
                    { new Guid("d453617f-c64d-4948-9f83-9c2322da8ae9"), 0, "4f05c9ed-da2d-47e3-9324-1c1d4b979073", "user@user.com", false, null, null, false, null, "USER@USER.COM", null, "AAed8fXaDqahSMXI0aj2KT5yvo00JRyRy18OECY8vmmpplml5Jh1ipc1quTGMw96FQ==", null, false, null, null, false, null }
                });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 1,
                columns: new[] { "ExpiryDate", "StockDate" },
                values: new object[] { new DateTime(2022, 10, 6, 3, 11, 10, 514, DateTimeKind.Local).AddTicks(7919), new DateTime(2020, 10, 6, 3, 11, 10, 514, DateTimeKind.Local).AddTicks(2431) });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 2,
                columns: new[] { "ExpiryDate", "StockDate" },
                values: new object[] { new DateTime(2022, 10, 6, 3, 11, 10, 514, DateTimeKind.Local).AddTicks(9223), new DateTime(2020, 10, 6, 3, 11, 10, 514, DateTimeKind.Local).AddTicks(9143) });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 3,
                columns: new[] { "ExpiryDate", "StockDate" },
                values: new object[] { new DateTime(2022, 10, 6, 3, 11, 10, 514, DateTimeKind.Local).AddTicks(9257), new DateTime(2020, 10, 6, 3, 11, 10, 514, DateTimeKind.Local).AddTicks(9253) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId", "Discriminator" },
                values: new object[,]
                {
                    { new Guid("db49401b-97c7-4d76-8ce5-f85d6c5e9df8"), new Guid("e68998eb-abbb-41c9-8d5a-d4dc9efdada1"), "UserRoles" },
                    { new Guid("d453617f-c64d-4948-9f83-9c2322da8ae9"), new Guid("131724ce-c407-4447-8d38-2025c9af4288"), "UserRoles" }
                });

            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "CustomerId", "Address", "CompanyContact", "CompanyName", "CompanyWebsite", "ContactNo", "DistrictId", "Email", "Name", "ThanaId", "UserId" },
                values: new object[] { 1, "Dhaka", "09876543", "Sr.Company", "sr@c.com", "01678907623", 3, "m@m.com", "Maham", 1, new Guid("d453617f-c64d-4948-9f83-9c2322da8ae9") });

            migrationBuilder.InsertData(
                table: "PurchaseDetails",
                columns: new[] { "PurchaseDetailId", "ColorId", "Description", "DiscountRate", "EntryBy", "EntryDate", "ExpiryDate", "MasterId", "ModelId", "NetAmount", "ProductCode", "ProductId", "PurchasePrice", "SizeId", "TotalPrice", "UnitQuantity", "VatRate" },
                values: new object[,]
                {
                    { 1, 1, "dfas", 5m, new Guid("d453617f-c64d-4948-9f83-9c2322da8ae9"), new DateTime(2020, 10, 6, 3, 11, 10, 512, DateTimeKind.Local).AddTicks(9468), new DateTime(2021, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 565m, "P01", 1, 300m, 1, 4000m, 65, 3m },
                    { 3, 2, "dfas", 5m, new Guid("d453617f-c64d-4948-9f83-9c2322da8ae9"), new DateTime(2020, 10, 6, 3, 11, 10, 513, DateTimeKind.Local).AddTicks(6126), new DateTime(2021, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 565m, "P03", 3, 300m, 2, 4000m, 65, 3m },
                    { 2, 2, "dfas", 5m, new Guid("d453617f-c64d-4948-9f83-9c2322da8ae9"), new DateTime(2020, 10, 6, 3, 11, 10, 513, DateTimeKind.Local).AddTicks(5981), new DateTime(2020, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 2, 565m, "P02", 2, 300m, 1, 4000m, 65, 3m }
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
                values: new object[] { 1, 1, new DateTime(2020, 10, 13, 3, 11, 10, 507, DateTimeKind.Local).AddTicks(7363), 50m, 0, new DateTime(2020, 10, 6, 3, 11, 10, 505, DateTimeKind.Local).AddTicks(8627), "ORD202010031", 1, true, 1, new DateTime(2020, 10, 7, 3, 11, 10, 507, DateTimeKind.Local).AddTicks(8468), 500m, "TRX1234567", new DateTime(2020, 10, 6, 3, 11, 10, 508, DateTimeKind.Local).AddTicks(879) });

            migrationBuilder.InsertData(
                table: "SalesMasters",
                columns: new[] { "SalesMasterId", "BillNo", "Note", "OrderId", "SalesDate", "TotalAmount", "TotalPrice", "TotalQuantity", "VoucherNo" },
                values: new object[] { 1, "123", "success", 1, new DateTime(2020, 10, 6, 3, 11, 10, 510, DateTimeKind.Local).AddTicks(2619), 550m, 1000m, 2, "abc" });

            migrationBuilder.InsertData(
                table: "SalesDetails",
                columns: new[] { "SalesDetailId", "DiscountAmount", "DiscountRate", "NetAmount", "ProductId", "SalesMasterId", "UintPrice", "UnitQuantity", "VatAmount", "VatRate" },
                values: new object[] { 2, 50m, 5m, 450m, 1, 1, 400m, 89, 987m, 3m });

            migrationBuilder.InsertData(
                table: "SalesDetails",
                columns: new[] { "SalesDetailId", "DiscountAmount", "DiscountRate", "NetAmount", "ProductId", "SalesMasterId", "UintPrice", "UnitQuantity", "VatAmount", "VatRate" },
                values: new object[] { 1, 50m, 5m, 550m, 1, 1, 676m, 89, 987m, 3m });
        }
    }
}
