using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eCommerce.Migrations
{
    public partial class init8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<decimal>(
                name: "PreviousPrice",
                table: "Products",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("9931cbaf-6522-4acb-8254-be83ad9cea61"), "e01bda33-7d16-446e-89c5-cf4a96c37b23", "Super Admin", "SUPER ADMIN" },
                    { new Guid("9f1fa0c7-47e7-48ed-8a80-e379bc042647"), "f8fe4c62-625c-494a-b8c6-bc69b3b38e3d", "Admin", "ADMIN" },
                    { new Guid("d5240cfc-b547-4d1e-9761-9a040d462a27"), "dfd4fc85-7e14-4852-a7b5-e498a9efffb4", "Customer", "CUSTOMER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Photo", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("29976a48-09d5-4a78-a66a-e3bcfe6d18fd"), 0, "fed48a7a-a43f-4ea6-8b74-5948fb13ae3b", "sadmin@sadmin.com", false, null, null, false, null, "SADMIN@SADMIN.COM", null, "AOKlBHF+2dZl6QzmoQsANKiM35PhbX4sYehSRege/KgQ3NXjkRLODKrt7HQc6aIVgA==", null, false, null, null, false, null },
                    { new Guid("30a54c26-4dbe-4db5-be14-7a34d979b860"), 0, "8350de9e-1134-496d-8a58-820c95ade527", "admin@admin.com", false, null, null, false, null, "ADMIN@ADMIN.COM", null, "ABuEKH/gC35uquY2Pb66Vje8yhoLxisC785lXwmE3RsqFL0anMiy5208x0SIVEeXzA==", null, false, null, null, false, null },
                    { new Guid("03556fc2-fed5-4873-a04c-9d61094109f0"), 0, "b99a923b-d0c7-4d2f-a270-93318fafce17", "user@user.com", false, null, null, false, null, "USER@USER.COM", null, "ABp0+0UwK343mBHFo6VNj3r3juF9Q5QirtGqqnBWaLJoc2/ujAGt6Mp4knhDLX3h+A==", null, false, null, null, false, null }
                });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 1,
                columns: new[] { "ExpiryDate", "StockDate" },
                values: new object[] { new DateTime(2022, 10, 8, 2, 29, 6, 732, DateTimeKind.Local).AddTicks(2109), new DateTime(2020, 10, 8, 2, 29, 6, 731, DateTimeKind.Local).AddTicks(8416) });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 2,
                columns: new[] { "ExpiryDate", "StockDate" },
                values: new object[] { new DateTime(2022, 10, 8, 2, 29, 6, 732, DateTimeKind.Local).AddTicks(2912), new DateTime(2020, 10, 8, 2, 29, 6, 732, DateTimeKind.Local).AddTicks(2833) });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: 3,
                columns: new[] { "ExpiryDate", "StockDate" },
                values: new object[] { new DateTime(2022, 10, 8, 2, 29, 6, 732, DateTimeKind.Local).AddTicks(2943), new DateTime(2020, 10, 8, 2, 29, 6, 732, DateTimeKind.Local).AddTicks(2939) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId", "Discriminator" },
                values: new object[,]
                {
                    { new Guid("29976a48-09d5-4a78-a66a-e3bcfe6d18fd"), new Guid("9931cbaf-6522-4acb-8254-be83ad9cea61"), "UserRoles" },
                    { new Guid("03556fc2-fed5-4873-a04c-9d61094109f0"), new Guid("d5240cfc-b547-4d1e-9761-9a040d462a27"), "UserRoles" }
                });

            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "CustomerId", "Address", "CompanyContact", "CompanyName", "CompanyWebsite", "ContactNo", "DistrictId", "Email", "Name", "ThanaId", "UserId" },
                values: new object[] { 1, "Dhaka", "09876543", "Sr.Company", "sr@c.com", "01678907623", 3, "m@m.com", "Maham", 1, new Guid("03556fc2-fed5-4873-a04c-9d61094109f0") });

            migrationBuilder.InsertData(
                table: "PurchaseDetails",
                columns: new[] { "PurchaseDetailId", "ColorId", "Description", "DiscountRate", "EntryBy", "EntryDate", "ExpiryDate", "MasterId", "ModelId", "NetAmount", "ProductCode", "ProductId", "SalesPrice", "SizeId", "TotalPrice", "UnitPrice", "UnitQuantity", "VatRate" },
                values: new object[,]
                {
                    { 1, 1, "dfas", 5m, new Guid("03556fc2-fed5-4873-a04c-9d61094109f0"), new DateTime(2020, 10, 8, 2, 29, 6, 730, DateTimeKind.Local).AddTicks(6027), new DateTime(2021, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 565m, "P01", 1, 0m, 1, 4000m, 300m, 65, 3m },
                    { 3, 2, "dfas", 5m, new Guid("03556fc2-fed5-4873-a04c-9d61094109f0"), new DateTime(2020, 10, 8, 2, 29, 6, 731, DateTimeKind.Local).AddTicks(1167), new DateTime(2021, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 565m, "P03", 3, 0m, 2, 4000m, 300m, 65, 3m },
                    { 2, 2, "dfas", 5m, new Guid("03556fc2-fed5-4873-a04c-9d61094109f0"), new DateTime(2020, 10, 8, 2, 29, 6, 731, DateTimeKind.Local).AddTicks(590), new DateTime(2020, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 2, 565m, "P02", 2, 0m, 1, 4000m, 300m, 65, 3m }
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
                values: new object[] { 1, 1, new DateTime(2020, 10, 15, 2, 29, 6, 727, DateTimeKind.Local).AddTicks(8863), 50m, 0, new DateTime(2020, 10, 8, 2, 29, 6, 726, DateTimeKind.Local).AddTicks(2636), "ORD202010031", 1, true, 1, new DateTime(2020, 10, 9, 2, 29, 6, 727, DateTimeKind.Local).AddTicks(9330), 500m, "TRX1234567", new DateTime(2020, 10, 8, 2, 29, 6, 728, DateTimeKind.Local).AddTicks(838) });

            migrationBuilder.InsertData(
                table: "SalesMasters",
                columns: new[] { "SalesMasterId", "BillNo", "Note", "OrderId", "SalesDate", "TotalAmount", "TotalPrice", "TotalQuantity", "VoucherNo" },
                values: new object[] { 1, "123", "success", 1, new DateTime(2020, 10, 8, 2, 29, 6, 729, DateTimeKind.Local).AddTicks(2550), 550m, 1000m, 2, "abc" });

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
                keyValue: new Guid("9f1fa0c7-47e7-48ed-8a80-e379bc042647"));

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("03556fc2-fed5-4873-a04c-9d61094109f0"), new Guid("d5240cfc-b547-4d1e-9761-9a040d462a27") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("29976a48-09d5-4a78-a66a-e3bcfe6d18fd"), new Guid("9931cbaf-6522-4acb-8254-be83ad9cea61") });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("30a54c26-4dbe-4db5-be14-7a34d979b860"));

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
                keyValue: new Guid("9931cbaf-6522-4acb-8254-be83ad9cea61"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("d5240cfc-b547-4d1e-9761-9a040d462a27"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("29976a48-09d5-4a78-a66a-e3bcfe6d18fd"));

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
                keyValue: new Guid("03556fc2-fed5-4873-a04c-9d61094109f0"));

            migrationBuilder.DropColumn(
                name: "PreviousPrice",
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
    }
}
