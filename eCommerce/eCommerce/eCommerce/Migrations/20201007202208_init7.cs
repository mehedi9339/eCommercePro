using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eCommerce.Migrations
{
    public partial class init7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("578cc42f-4d71-47db-a61f-043b6d2c45a8"));

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("62a3d020-c115-4ef7-b66c-fac5843cce83"), new Guid("421bfc1d-6c8c-4999-834c-b4e2d1d51f07") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("84c5ca7f-5fc2-4053-838e-9862bd6b03bb"), new Guid("c8909dfe-1a77-440e-8269-44f1a3a137c3") });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a320ecea-3f06-4ae9-9e78-88487437b01d"));

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
                keyValue: new Guid("421bfc1d-6c8c-4999-834c-b4e2d1d51f07"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("c8909dfe-1a77-440e-8269-44f1a3a137c3"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("62a3d020-c115-4ef7-b66c-fac5843cce83"));

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
                keyValue: new Guid("84c5ca7f-5fc2-4053-838e-9862bd6b03bb"));

            migrationBuilder.DropColumn(
                name: "ExpireDate",
                table: "Products");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("f0b6d97d-7c65-499d-9f6b-0b145bde1116"), "a3990af9-f48f-4363-bd4e-664311a8471c", "Super Admin", "SUPER ADMIN" },
                    { new Guid("2330a2e1-5439-4412-b882-ae8c9aab2987"), "233b13f1-746d-419c-ac60-f3cffd0aacb8", "Admin", "ADMIN" },
                    { new Guid("e678ef61-e82a-4e02-a510-9f3e66979f7e"), "0f34ec60-0006-4537-aa5e-8a4ce6cdf933", "Customer", "CUSTOMER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Photo", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("ca0a3def-9e5a-4213-9784-3dd4d633a2f9"), 0, "e00e443a-2c8d-4907-8c62-41307b338b48", "sadmin@sadmin.com", false, null, null, false, null, "SADMIN@SADMIN.COM", null, "AHG9JjtlOfr3l2HnBlqK7R7rp3uYa0Fl6HZz6veFSPwj49kNXMnD67qn41RqqyytjQ==", null, false, null, null, false, null },
                    { new Guid("d3999238-d989-485e-9eb6-64fcfae1c746"), 0, "6c47026c-722f-47b8-ba4d-4c66508d6e3d", "admin@admin.com", false, null, null, false, null, "ADMIN@ADMIN.COM", null, "ABqHA8VRg3Ce3/kgo/8Kr6GjmMWGaa9cYU8RVecpiuQfxZtVjRKU9ZuWaE2iJczROA==", null, false, null, null, false, null },
                    { new Guid("ac0ecd2c-0579-4d19-b2f4-5022f7916185"), 0, "2507d884-ba13-4606-afc0-6ac6706a8d4e", "user@user.com", false, null, null, false, null, "USER@USER.COM", null, "ACpgwf6hOuA/xvPkGMUQGmNu3e2fYdAO0IrVBxLwHwtXRo/O0gf8yGN53IK1uX8HFg==", null, false, null, null, false, null }
                });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 1,
                columns: new[] { "ExpiryDate", "StockDate" },
                values: new object[] { new DateTime(2022, 10, 8, 2, 22, 6, 563, DateTimeKind.Local).AddTicks(9494), new DateTime(2020, 10, 8, 2, 22, 6, 563, DateTimeKind.Local).AddTicks(3175) });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 2,
                columns: new[] { "ExpiryDate", "StockDate" },
                values: new object[] { new DateTime(2022, 10, 8, 2, 22, 6, 564, DateTimeKind.Local).AddTicks(1156), new DateTime(2020, 10, 8, 2, 22, 6, 564, DateTimeKind.Local).AddTicks(1022) });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 3,
                columns: new[] { "ExpiryDate", "StockDate" },
                values: new object[] { new DateTime(2022, 10, 8, 2, 22, 6, 564, DateTimeKind.Local).AddTicks(1213), new DateTime(2020, 10, 8, 2, 22, 6, 564, DateTimeKind.Local).AddTicks(1208) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId", "Discriminator" },
                values: new object[,]
                {
                    { new Guid("ca0a3def-9e5a-4213-9784-3dd4d633a2f9"), new Guid("f0b6d97d-7c65-499d-9f6b-0b145bde1116"), "UserRoles" },
                    { new Guid("ac0ecd2c-0579-4d19-b2f4-5022f7916185"), new Guid("e678ef61-e82a-4e02-a510-9f3e66979f7e"), "UserRoles" }
                });

            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "CustomerId", "Address", "CompanyContact", "CompanyName", "CompanyWebsite", "ContactNo", "DistrictId", "Email", "Name", "ThanaId", "UserId" },
                values: new object[] { 1, "Dhaka", "09876543", "Sr.Company", "sr@c.com", "01678907623", 3, "m@m.com", "Maham", 1, new Guid("ac0ecd2c-0579-4d19-b2f4-5022f7916185") });

            migrationBuilder.InsertData(
                table: "PurchaseDetails",
                columns: new[] { "PurchaseDetailId", "ColorId", "Description", "DiscountRate", "EntryBy", "EntryDate", "ExpiryDate", "MasterId", "ModelId", "NetAmount", "ProductCode", "ProductId", "SalesPrice", "SizeId", "TotalPrice", "UnitPrice", "UnitQuantity", "VatRate" },
                values: new object[,]
                {
                    { 1, 1, "dfas", 5m, new Guid("ac0ecd2c-0579-4d19-b2f4-5022f7916185"), new DateTime(2020, 10, 8, 2, 22, 6, 561, DateTimeKind.Local).AddTicks(6788), new DateTime(2021, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 565m, "P01", 1, 0m, 1, 4000m, 300m, 65, 3m },
                    { 3, 2, "dfas", 5m, new Guid("ac0ecd2c-0579-4d19-b2f4-5022f7916185"), new DateTime(2020, 10, 8, 2, 22, 6, 562, DateTimeKind.Local).AddTicks(5884), new DateTime(2021, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 565m, "P03", 3, 0m, 2, 4000m, 300m, 65, 3m },
                    { 2, 2, "dfas", 5m, new Guid("ac0ecd2c-0579-4d19-b2f4-5022f7916185"), new DateTime(2020, 10, 8, 2, 22, 6, 562, DateTimeKind.Local).AddTicks(5650), new DateTime(2020, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 2, 565m, "P02", 2, 0m, 1, 4000m, 300m, 65, 3m }
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
                values: new object[] { 1, 1, new DateTime(2020, 10, 15, 2, 22, 6, 557, DateTimeKind.Local).AddTicks(1349), 50m, 0, new DateTime(2020, 10, 8, 2, 22, 6, 555, DateTimeKind.Local).AddTicks(5411), "ORD202010031", 1, true, 1, new DateTime(2020, 10, 9, 2, 22, 6, 557, DateTimeKind.Local).AddTicks(1817), 500m, "TRX1234567", new DateTime(2020, 10, 8, 2, 22, 6, 557, DateTimeKind.Local).AddTicks(3170) });

            migrationBuilder.InsertData(
                table: "SalesMasters",
                columns: new[] { "SalesMasterId", "BillNo", "Note", "OrderId", "SalesDate", "TotalAmount", "TotalPrice", "TotalQuantity", "VoucherNo" },
                values: new object[] { 1, "123", "success", 1, new DateTime(2020, 10, 8, 2, 22, 6, 558, DateTimeKind.Local).AddTicks(5707), 550m, 1000m, 2, "abc" });

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
                keyValue: new Guid("2330a2e1-5439-4412-b882-ae8c9aab2987"));

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("ac0ecd2c-0579-4d19-b2f4-5022f7916185"), new Guid("e678ef61-e82a-4e02-a510-9f3e66979f7e") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("ca0a3def-9e5a-4213-9784-3dd4d633a2f9"), new Guid("f0b6d97d-7c65-499d-9f6b-0b145bde1116") });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d3999238-d989-485e-9eb6-64fcfae1c746"));

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
                keyValue: new Guid("e678ef61-e82a-4e02-a510-9f3e66979f7e"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("f0b6d97d-7c65-499d-9f6b-0b145bde1116"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ca0a3def-9e5a-4213-9784-3dd4d633a2f9"));

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
                keyValue: new Guid("ac0ecd2c-0579-4d19-b2f4-5022f7916185"));

            migrationBuilder.AddColumn<DateTime>(
                name: "ExpireDate",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("421bfc1d-6c8c-4999-834c-b4e2d1d51f07"), "2f7c5ae3-e948-46cf-bf2f-1a52fb775a3b", "Super Admin", "SUPER ADMIN" },
                    { new Guid("578cc42f-4d71-47db-a61f-043b6d2c45a8"), "d2c0ed7b-558f-47a7-889e-f8db78b7c95d", "Admin", "ADMIN" },
                    { new Guid("c8909dfe-1a77-440e-8269-44f1a3a137c3"), "9a1175d8-3364-46cb-8837-3075ba25f79b", "Customer", "CUSTOMER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Photo", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("62a3d020-c115-4ef7-b66c-fac5843cce83"), 0, "6d1f741c-b23e-4c18-9467-097b7675746f", "sadmin@sadmin.com", false, null, null, false, null, "SADMIN@SADMIN.COM", null, "ANG2izg1tYT9LCUquE0XcYSLdY6ahja/nr/iWSaOT7yqO/xYZt9/JvyRLcDnUL+uwA==", null, false, null, null, false, null },
                    { new Guid("a320ecea-3f06-4ae9-9e78-88487437b01d"), 0, "70b0e40b-d696-4a31-b0b3-66a1a3dd8c51", "admin@admin.com", false, null, null, false, null, "ADMIN@ADMIN.COM", null, "ANI75pJxak3Xl2IAo86PP8ux4kFTVYd+cqq6Eq76ckvc+j/IIqdbHEeYKHIG5JK7EA==", null, false, null, null, false, null },
                    { new Guid("84c5ca7f-5fc2-4053-838e-9862bd6b03bb"), 0, "5b4c00bf-25dd-4a28-8eb6-1349dd8a412a", "user@user.com", false, null, null, false, null, "USER@USER.COM", null, "AL/1Mgg0hzGVwD+5y04HMWEO1c8krn0w1lTQn8Su9iumUkTaRn+jl9ZtGXhMCsNVKw==", null, false, null, null, false, null }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "ExpireDate",
                value: new DateTime(2021, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "ExpireDate",
                value: new DateTime(2020, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "ExpireDate",
                value: new DateTime(2021, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 1,
                columns: new[] { "ExpiryDate", "StockDate" },
                values: new object[] { new DateTime(2022, 10, 7, 23, 28, 52, 115, DateTimeKind.Local).AddTicks(1202), new DateTime(2020, 10, 7, 23, 28, 52, 114, DateTimeKind.Local).AddTicks(8500) });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 2,
                columns: new[] { "ExpiryDate", "StockDate" },
                values: new object[] { new DateTime(2022, 10, 7, 23, 28, 52, 115, DateTimeKind.Local).AddTicks(2090), new DateTime(2020, 10, 7, 23, 28, 52, 115, DateTimeKind.Local).AddTicks(1992) });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 3,
                columns: new[] { "ExpiryDate", "StockDate" },
                values: new object[] { new DateTime(2022, 10, 7, 23, 28, 52, 115, DateTimeKind.Local).AddTicks(2123), new DateTime(2020, 10, 7, 23, 28, 52, 115, DateTimeKind.Local).AddTicks(2120) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId", "Discriminator" },
                values: new object[,]
                {
                    { new Guid("62a3d020-c115-4ef7-b66c-fac5843cce83"), new Guid("421bfc1d-6c8c-4999-834c-b4e2d1d51f07"), "UserRoles" },
                    { new Guid("84c5ca7f-5fc2-4053-838e-9862bd6b03bb"), new Guid("c8909dfe-1a77-440e-8269-44f1a3a137c3"), "UserRoles" }
                });

            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "CustomerId", "Address", "CompanyContact", "CompanyName", "CompanyWebsite", "ContactNo", "DistrictId", "Email", "Name", "ThanaId", "UserId" },
                values: new object[] { 1, "Dhaka", "09876543", "Sr.Company", "sr@c.com", "01678907623", 3, "m@m.com", "Maham", 1, new Guid("84c5ca7f-5fc2-4053-838e-9862bd6b03bb") });

            migrationBuilder.InsertData(
                table: "PurchaseDetails",
                columns: new[] { "PurchaseDetailId", "ColorId", "Description", "DiscountRate", "EntryBy", "EntryDate", "ExpiryDate", "MasterId", "ModelId", "NetAmount", "ProductCode", "ProductId", "SalesPrice", "SizeId", "TotalPrice", "UnitPrice", "UnitQuantity", "VatRate" },
                values: new object[,]
                {
                    { 1, 1, "dfas", 5m, new Guid("84c5ca7f-5fc2-4053-838e-9862bd6b03bb"), new DateTime(2020, 10, 7, 23, 28, 52, 114, DateTimeKind.Local).AddTicks(1314), new DateTime(2021, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 565m, "P01", 1, 0m, 1, 4000m, 300m, 65, 3m },
                    { 3, 2, "dfas", 5m, new Guid("84c5ca7f-5fc2-4053-838e-9862bd6b03bb"), new DateTime(2020, 10, 7, 23, 28, 52, 114, DateTimeKind.Local).AddTicks(4971), new DateTime(2021, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 565m, "P03", 3, 0m, 2, 4000m, 300m, 65, 3m },
                    { 2, 2, "dfas", 5m, new Guid("84c5ca7f-5fc2-4053-838e-9862bd6b03bb"), new DateTime(2020, 10, 7, 23, 28, 52, 114, DateTimeKind.Local).AddTicks(4819), new DateTime(2020, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 2, 565m, "P02", 2, 0m, 1, 4000m, 300m, 65, 3m }
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
                values: new object[] { 1, 1, new DateTime(2020, 10, 14, 23, 28, 52, 111, DateTimeKind.Local).AddTicks(3019), 50m, 0, new DateTime(2020, 10, 7, 23, 28, 52, 109, DateTimeKind.Local).AddTicks(6099), "ORD202010031", 1, true, 1, new DateTime(2020, 10, 8, 23, 28, 52, 111, DateTimeKind.Local).AddTicks(3485), 500m, "TRX1234567", new DateTime(2020, 10, 7, 23, 28, 52, 111, DateTimeKind.Local).AddTicks(4834) });

            migrationBuilder.InsertData(
                table: "SalesMasters",
                columns: new[] { "SalesMasterId", "BillNo", "Note", "OrderId", "SalesDate", "TotalAmount", "TotalPrice", "TotalQuantity", "VoucherNo" },
                values: new object[] { 1, "123", "success", 1, new DateTime(2020, 10, 7, 23, 28, 52, 112, DateTimeKind.Local).AddTicks(6082), 550m, 1000m, 2, "abc" });

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
