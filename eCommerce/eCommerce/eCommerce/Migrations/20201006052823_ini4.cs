using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eCommerce.Migrations
{
    public partial class ini4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<int>(
                name: "ColorId",
                table: "SalesDetails",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ModelId",
                table: "SalesDetails",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SizeId",
                table: "SalesDetails",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("d0f77793-2f39-4fa9-b5dc-a339f17927c7"), "ac21e22e-2737-4bae-bbc5-d8bbdd20a9e1", "Super Admin", "SUPER ADMIN" },
                    { new Guid("c5b6f53e-b00b-4c66-91a2-af995da4355d"), "42fea3d9-a458-4e60-9d92-ddb5ce627907", "Admin", "ADMIN" },
                    { new Guid("d3e6adec-78c6-475d-8817-7d2935589d3d"), "67901323-a0bd-4c80-9b36-e78b02bf7e88", "Customer", "CUSTOMER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Photo", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("0793ba23-f78e-42ec-a858-64b60de0210e"), 0, "112b638a-97b4-41dd-aae9-42d22f518b68", "sadmin@sadmin.com", false, null, null, false, null, "SADMIN@SADMIN.COM", null, "AB4BleCz14GObQzpmVOzx7bwjzAH6ulodD75rvH+dzbFVPPTRxMUuKYZp28CHjcjsQ==", null, false, null, null, false, null },
                    { new Guid("f3623854-f837-4e48-9c8a-13ecd856ecce"), 0, "8509d9f8-0fc3-407a-9b04-edd53bef91a1", "admin@admin.com", false, null, null, false, null, "ADMIN@ADMIN.COM", null, "ALY31PiSQmJeHDtYvIM1Y0Pf6LYLKUlyNOCBq6sMfEo9qdpFnTEd+3yVvvJsj9ye3g==", null, false, null, null, false, null },
                    { new Guid("862b418a-01bf-4091-af8a-281519552847"), 0, "7f2065c6-5b05-47db-95cc-6b3f8b9768a9", "user@user.com", false, null, null, false, null, "USER@USER.COM", null, "AKlwK3YVrlpAT0Jg/ljlzYMKuP2PdcVuu/8MmGEusGcI5jylWLr3lYBn2CVrj7OhaA==", null, false, null, null, false, null }
                });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 1,
                columns: new[] { "ExpiryDate", "StockDate" },
                values: new object[] { new DateTime(2022, 10, 6, 11, 28, 21, 620, DateTimeKind.Local).AddTicks(6860), new DateTime(2020, 10, 6, 11, 28, 21, 620, DateTimeKind.Local).AddTicks(3226) });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 2,
                columns: new[] { "ExpiryDate", "StockDate" },
                values: new object[] { new DateTime(2022, 10, 6, 11, 28, 21, 620, DateTimeKind.Local).AddTicks(7918), new DateTime(2020, 10, 6, 11, 28, 21, 620, DateTimeKind.Local).AddTicks(7859) });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 3,
                columns: new[] { "ExpiryDate", "StockDate" },
                values: new object[] { new DateTime(2022, 10, 6, 11, 28, 21, 620, DateTimeKind.Local).AddTicks(7943), new DateTime(2020, 10, 6, 11, 28, 21, 620, DateTimeKind.Local).AddTicks(7941) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId", "Discriminator" },
                values: new object[,]
                {
                    { new Guid("0793ba23-f78e-42ec-a858-64b60de0210e"), new Guid("d0f77793-2f39-4fa9-b5dc-a339f17927c7"), "UserRoles" },
                    { new Guid("862b418a-01bf-4091-af8a-281519552847"), new Guid("d3e6adec-78c6-475d-8817-7d2935589d3d"), "UserRoles" }
                });

            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "CustomerId", "Address", "CompanyContact", "CompanyName", "CompanyWebsite", "ContactNo", "DistrictId", "Email", "Name", "ThanaId", "UserId" },
                values: new object[] { 1, "Dhaka", "09876543", "Sr.Company", "sr@c.com", "01678907623", 3, "m@m.com", "Maham", 1, new Guid("862b418a-01bf-4091-af8a-281519552847") });

            migrationBuilder.InsertData(
                table: "PurchaseDetails",
                columns: new[] { "PurchaseDetailId", "ColorId", "Description", "DiscountRate", "EntryBy", "EntryDate", "ExpiryDate", "MasterId", "ModelId", "NetAmount", "ProductCode", "ProductId", "SizeId", "TotalPrice", "UnitPrice", "UnitQuantity", "VatRate" },
                values: new object[,]
                {
                    { 1, 1, "dfas", 5m, new Guid("862b418a-01bf-4091-af8a-281519552847"), new DateTime(2020, 10, 6, 11, 28, 21, 619, DateTimeKind.Local).AddTicks(3957), new DateTime(2021, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 565m, "P01", 1, 1, 4000m, 300m, 65, 3m },
                    { 3, 2, "dfas", 5m, new Guid("862b418a-01bf-4091-af8a-281519552847"), new DateTime(2020, 10, 6, 11, 28, 21, 619, DateTimeKind.Local).AddTicks(8362), new DateTime(2021, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 565m, "P03", 3, 2, 4000m, 300m, 65, 3m },
                    { 2, 2, "dfas", 5m, new Guid("862b418a-01bf-4091-af8a-281519552847"), new DateTime(2020, 10, 6, 11, 28, 21, 619, DateTimeKind.Local).AddTicks(8239), new DateTime(2020, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 2, 565m, "P02", 2, 1, 4000m, 300m, 65, 3m }
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
                values: new object[] { 1, 1, new DateTime(2020, 10, 13, 11, 28, 21, 615, DateTimeKind.Local).AddTicks(7036), 50m, 0, new DateTime(2020, 10, 6, 11, 28, 21, 614, DateTimeKind.Local).AddTicks(7954), "ORD202010031", 1, true, 1, new DateTime(2020, 10, 7, 11, 28, 21, 615, DateTimeKind.Local).AddTicks(7627), 500m, "TRX1234567", new DateTime(2020, 10, 6, 11, 28, 21, 615, DateTimeKind.Local).AddTicks(9495) });

            migrationBuilder.InsertData(
                table: "SalesMasters",
                columns: new[] { "SalesMasterId", "BillNo", "Note", "OrderId", "SalesDate", "TotalAmount", "TotalPrice", "TotalQuantity", "VoucherNo" },
                values: new object[] { 1, "123", "success", 1, new DateTime(2020, 10, 6, 11, 28, 21, 617, DateTimeKind.Local).AddTicks(5797), 550m, 1000m, 2, "abc" });

            migrationBuilder.InsertData(
                table: "SalesDetails",
                columns: new[] { "SalesDetailId", "ColorId", "DiscountAmount", "DiscountRate", "ModelId", "NetAmount", "ProductId", "SalesMasterId", "SizeId", "UintPrice", "UnitQuantity", "VatAmount", "VatRate" },
                values: new object[] { 2, null, 50m, 5m, null, 450m, 1, 1, null, 400m, 89, 987m, 3m });

            migrationBuilder.InsertData(
                table: "SalesDetails",
                columns: new[] { "SalesDetailId", "ColorId", "DiscountAmount", "DiscountRate", "ModelId", "NetAmount", "ProductId", "SalesMasterId", "SizeId", "UintPrice", "UnitQuantity", "VatAmount", "VatRate" },
                values: new object[] { 1, null, 50m, 5m, null, 550m, 1, 1, null, 676m, 89, 987m, 3m });

            migrationBuilder.CreateIndex(
                name: "IX_SalesDetails_ColorId",
                table: "SalesDetails",
                column: "ColorId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesDetails_ModelId",
                table: "SalesDetails",
                column: "ModelId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesDetails_SizeId",
                table: "SalesDetails",
                column: "SizeId");

            migrationBuilder.AddForeignKey(
                name: "FK_SalesDetails_Colors_ColorId",
                table: "SalesDetails",
                column: "ColorId",
                principalTable: "Colors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SalesDetails_ModelTbls_ModelId",
                table: "SalesDetails",
                column: "ModelId",
                principalTable: "ModelTbls",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SalesDetails_Sizes_SizeId",
                table: "SalesDetails",
                column: "SizeId",
                principalTable: "Sizes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SalesDetails_Colors_ColorId",
                table: "SalesDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_SalesDetails_ModelTbls_ModelId",
                table: "SalesDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_SalesDetails_Sizes_SizeId",
                table: "SalesDetails");

            migrationBuilder.DropIndex(
                name: "IX_SalesDetails_ColorId",
                table: "SalesDetails");

            migrationBuilder.DropIndex(
                name: "IX_SalesDetails_ModelId",
                table: "SalesDetails");

            migrationBuilder.DropIndex(
                name: "IX_SalesDetails_SizeId",
                table: "SalesDetails");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("c5b6f53e-b00b-4c66-91a2-af995da4355d"));

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("0793ba23-f78e-42ec-a858-64b60de0210e"), new Guid("d0f77793-2f39-4fa9-b5dc-a339f17927c7") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("862b418a-01bf-4091-af8a-281519552847"), new Guid("d3e6adec-78c6-475d-8817-7d2935589d3d") });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f3623854-f837-4e48-9c8a-13ecd856ecce"));

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
                keyValue: new Guid("d0f77793-2f39-4fa9-b5dc-a339f17927c7"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("d3e6adec-78c6-475d-8817-7d2935589d3d"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("0793ba23-f78e-42ec-a858-64b60de0210e"));

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
                keyValue: new Guid("862b418a-01bf-4091-af8a-281519552847"));

            migrationBuilder.DropColumn(
                name: "ColorId",
                table: "SalesDetails");

            migrationBuilder.DropColumn(
                name: "ModelId",
                table: "SalesDetails");

            migrationBuilder.DropColumn(
                name: "SizeId",
                table: "SalesDetails");

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
    }
}
