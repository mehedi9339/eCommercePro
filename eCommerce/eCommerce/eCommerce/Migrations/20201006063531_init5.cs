using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eCommerce.Migrations
{
    public partial class init5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AddColumn<decimal>(
                name: "SalesPrice",
                table: "Stocks",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("456bd13f-feeb-43f8-8c5b-6690e4c00599"), "7399ed4d-686a-4eda-865e-126e6db3cc12", "Super Admin", "SUPER ADMIN" },
                    { new Guid("3a147637-4680-4971-abcc-15d67a1a6c89"), "38c3d78b-4f79-4ffa-bc4a-cf3810205480", "Admin", "ADMIN" },
                    { new Guid("07a335c4-3d84-45c6-a47e-eb2d2060554a"), "b780f9f3-1aea-44cf-984c-efa7764e7aa9", "Customer", "CUSTOMER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Photo", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("04a694a6-b0da-4134-b5e2-13bcb9fbfe66"), 0, "8c2b999d-a41e-4467-a4b0-5a02fad72cc4", "sadmin@sadmin.com", false, null, null, false, null, "SADMIN@SADMIN.COM", null, "AE29fFV+k8QlZd4dfzMX760Jsi5K9Y2ycLn3zt2k/gA62AA1yH9RsiPMuLP6L0vtYQ==", null, false, null, null, false, null },
                    { new Guid("4cafa93f-988c-47f3-b12c-d54c672a29aa"), 0, "1f847976-4b5d-413f-bbc8-b7848313be46", "admin@admin.com", false, null, null, false, null, "ADMIN@ADMIN.COM", null, "ANMKai0nq94kZbgFD3JULcXJVDQkleaf0HcnBbMxLZm2UTaYoGNxwig4gnlx4uZvqg==", null, false, null, null, false, null },
                    { new Guid("9c9847ee-0f1c-4c20-9bf8-6f104e2577ff"), 0, "9b0305c9-27c4-4079-8ba1-bd5af771d8f8", "user@user.com", false, null, null, false, null, "USER@USER.COM", null, "AM0fbbNMSt2Sz6nLVeL6SKxXlNRv+lzImLI8pUU6SHqW3ZXFRQnzkee8i3URe0ZZMw==", null, false, null, null, false, null }
                });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 1,
                columns: new[] { "ExpiryDate", "StockDate" },
                values: new object[] { new DateTime(2022, 10, 6, 12, 35, 29, 840, DateTimeKind.Local).AddTicks(2550), new DateTime(2020, 10, 6, 12, 35, 29, 839, DateTimeKind.Local).AddTicks(8930) });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 2,
                columns: new[] { "ExpiryDate", "StockDate" },
                values: new object[] { new DateTime(2022, 10, 6, 12, 35, 29, 840, DateTimeKind.Local).AddTicks(3677), new DateTime(2020, 10, 6, 12, 35, 29, 840, DateTimeKind.Local).AddTicks(3614) });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 3,
                columns: new[] { "ExpiryDate", "StockDate" },
                values: new object[] { new DateTime(2022, 10, 6, 12, 35, 29, 840, DateTimeKind.Local).AddTicks(3701), new DateTime(2020, 10, 6, 12, 35, 29, 840, DateTimeKind.Local).AddTicks(3699) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId", "Discriminator" },
                values: new object[,]
                {
                    { new Guid("04a694a6-b0da-4134-b5e2-13bcb9fbfe66"), new Guid("456bd13f-feeb-43f8-8c5b-6690e4c00599"), "UserRoles" },
                    { new Guid("9c9847ee-0f1c-4c20-9bf8-6f104e2577ff"), new Guid("07a335c4-3d84-45c6-a47e-eb2d2060554a"), "UserRoles" }
                });

            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "CustomerId", "Address", "CompanyContact", "CompanyName", "CompanyWebsite", "ContactNo", "DistrictId", "Email", "Name", "ThanaId", "UserId" },
                values: new object[] { 1, "Dhaka", "09876543", "Sr.Company", "sr@c.com", "01678907623", 3, "m@m.com", "Maham", 1, new Guid("9c9847ee-0f1c-4c20-9bf8-6f104e2577ff") });

            migrationBuilder.InsertData(
                table: "PurchaseDetails",
                columns: new[] { "PurchaseDetailId", "ColorId", "Description", "DiscountRate", "EntryBy", "EntryDate", "ExpiryDate", "MasterId", "ModelId", "NetAmount", "ProductCode", "ProductId", "SizeId", "TotalPrice", "UnitPrice", "UnitQuantity", "VatRate" },
                values: new object[,]
                {
                    { 1, 1, "dfas", 5m, new Guid("9c9847ee-0f1c-4c20-9bf8-6f104e2577ff"), new DateTime(2020, 10, 6, 12, 35, 29, 838, DateTimeKind.Local).AddTicks(9895), new DateTime(2021, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 565m, "P01", 1, 1, 4000m, 300m, 65, 3m },
                    { 3, 2, "dfas", 5m, new Guid("9c9847ee-0f1c-4c20-9bf8-6f104e2577ff"), new DateTime(2020, 10, 6, 12, 35, 29, 839, DateTimeKind.Local).AddTicks(4127), new DateTime(2021, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 565m, "P03", 3, 2, 4000m, 300m, 65, 3m },
                    { 2, 2, "dfas", 5m, new Guid("9c9847ee-0f1c-4c20-9bf8-6f104e2577ff"), new DateTime(2020, 10, 6, 12, 35, 29, 839, DateTimeKind.Local).AddTicks(4011), new DateTime(2020, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 2, 565m, "P02", 2, 1, 4000m, 300m, 65, 3m }
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
                values: new object[] { 1, 1, new DateTime(2020, 10, 13, 12, 35, 29, 834, DateTimeKind.Local).AddTicks(5953), 50m, 0, new DateTime(2020, 10, 6, 12, 35, 29, 833, DateTimeKind.Local).AddTicks(7543), "ORD202010031", 1, true, 1, new DateTime(2020, 10, 7, 12, 35, 29, 834, DateTimeKind.Local).AddTicks(6510), 500m, "TRX1234567", new DateTime(2020, 10, 6, 12, 35, 29, 834, DateTimeKind.Local).AddTicks(8378) });

            migrationBuilder.InsertData(
                table: "SalesMasters",
                columns: new[] { "SalesMasterId", "BillNo", "Note", "OrderId", "SalesDate", "TotalAmount", "TotalPrice", "TotalQuantity", "VoucherNo" },
                values: new object[] { 1, "123", "success", 1, new DateTime(2020, 10, 6, 12, 35, 29, 836, DateTimeKind.Local).AddTicks(9997), 550m, 1000m, 2, "abc" });

            migrationBuilder.InsertData(
                table: "SalesDetails",
                columns: new[] { "SalesDetailId", "ColorId", "DiscountAmount", "DiscountRate", "ModelId", "NetAmount", "ProductId", "SalesMasterId", "SizeId", "UintPrice", "UnitQuantity", "VatAmount", "VatRate" },
                values: new object[] { 2, null, 50m, 5m, null, 450m, 1, 1, null, 400m, 89, 987m, 3m });

            migrationBuilder.InsertData(
                table: "SalesDetails",
                columns: new[] { "SalesDetailId", "ColorId", "DiscountAmount", "DiscountRate", "ModelId", "NetAmount", "ProductId", "SalesMasterId", "SizeId", "UintPrice", "UnitQuantity", "VatAmount", "VatRate" },
                values: new object[] { 1, null, 50m, 5m, null, 550m, 1, 1, null, 676m, 89, 987m, 3m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("3a147637-4680-4971-abcc-15d67a1a6c89"));

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("04a694a6-b0da-4134-b5e2-13bcb9fbfe66"), new Guid("456bd13f-feeb-43f8-8c5b-6690e4c00599") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("9c9847ee-0f1c-4c20-9bf8-6f104e2577ff"), new Guid("07a335c4-3d84-45c6-a47e-eb2d2060554a") });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4cafa93f-988c-47f3-b12c-d54c672a29aa"));

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
                keyValue: new Guid("07a335c4-3d84-45c6-a47e-eb2d2060554a"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("456bd13f-feeb-43f8-8c5b-6690e4c00599"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("04a694a6-b0da-4134-b5e2-13bcb9fbfe66"));

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
                keyValue: new Guid("9c9847ee-0f1c-4c20-9bf8-6f104e2577ff"));

            migrationBuilder.DropColumn(
                name: "SalesPrice",
                table: "Stocks");

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
        }
    }
}
