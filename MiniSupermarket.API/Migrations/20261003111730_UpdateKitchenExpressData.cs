using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MiniSupermarket.API.Migrations
{
    /// <inheritdoc />
    public partial class UpdateKitchenExpressData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                columns: new[] { "CategoryName", "Description" },
                values: new object[] { "Nồi và Chảo", "Các loại nồi, chảo chống dính, nồi áp suất" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                columns: new[] { "CategoryName", "Description" },
                values: new object[] { "Thiết bị Điện nhà bếp", "Nồi chiên, máy xay, lò vi sóng, ấm siêu tốc" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3,
                columns: new[] { "CategoryName", "Description" },
                values: new object[] { "Dụng cụ nấu nướng & Cắt thái", "Bộ dao, thớt, dụng cụ hỗ trợ nấu ăn" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4,
                columns: new[] { "CategoryName", "Description" },
                values: new object[] { "Hộp đựng & Bảo quản thực phẩm", "Hộp thủy tinh, hộp giữ nhiệt" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 5,
                columns: new[] { "CategoryName", "Description" },
                values: new object[] { "Dụng cụ pha chế & Dùng bàn ăn", "Bình giữ nhiệt, ấm chén" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 1,
                column: "CustomerName",
                value: "Nguyễn Văn An");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 2,
                column: "CustomerName",
                value: "Trần Thị Bình");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 3,
                column: "CustomerName",
                value: "Lê Văn Cường");

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "Address", "CustomerName", "MembershipRank", "PhoneNumber", "RewardPoints" },
                values: new object[,]
                {
                    { 4, null, "Phạm Thị Dung", "Vàng", "0932233445", 220 },
                    { 5, null, "Hoàng Văn Em", "Chuẩn", "0977889900", 5 },
                    { 6, null, "Vũ Thị Phương", "Bạc", "0912345678", 80 },
                    { 7, null, "Đặng Văn Giang", "Vàng", "0988776655", 310 },
                    { 8, null, "Bùi Thị Hoa", "Chuẩn", "0905544332", 20 },
                    { 9, null, "Ngô Văn Hùng", "Bạc", "0966112233", 95 },
                    { 10, null, "Dương Thị Lan", "Vàng", "0944332211", 180 },
                    { 11, null, "Lý Văn Minh", "Chuẩn", "0922334455", 15 },
                    { 12, null, "Đỗ Thị Nga", "Bạc", "0933445566", 65 },
                    { 13, null, "Hồ Văn Quân", "Vàng", "0977112233", 250 }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "Address", "CustomerName", "MembershipRank", "PhoneNumber" },
                values: new object[] { 14, null, "Phan Thị Sương", "Chuẩn", "0909988776" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "Address", "CustomerName", "MembershipRank", "PhoneNumber", "RewardPoints" },
                values: new object[] { 15, null, "Trịnh Văn Tùng", "Bạc", "0911223344", 110 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Barcode", "CategoryId", "Price", "ProductName", "StockQuantity" },
                values: new object[,]
                {
                    { 1, "", 2, 2490000m, "Nồi chiên không dầu Philips 5L", 15 },
                    { 2, "", 2, 650000m, "Máy xay sinh tố đa năng Sunhouse", 25 },
                    { 3, "", 2, 1850000m, "Nồi cơm điện cao tần Panasonic 1.8L", 10 },
                    { 4, "", 2, 1790000m, "Lò vi sóng điện tử Sharp 20L", 8 },
                    { 5, "", 2, 520000m, "Ấm siêu tốc điện giữ nhiệt Lock&Lock 1.7L", 30 },
                    { 6, "", 1, 1250000m, "Bộ nồi inox 5 đáy Elmich (3 chiếc)", 12 },
                    { 7, "", 1, 280000m, "Chảo chống dính sâu lòng Sunhouse 28cm", 40 },
                    { 8, "", 1, 790000m, "Nồi áp suất lẩu điện đa năng Kasuma", 18 },
                    { 9, "", 3, 450000m, "Bộ dao nhà bếp cao cấp 6 món thép không gỉ", 20 },
                    { 10, "", 3, 180000m, "Thớt gỗ kháng khuẩn cao cấp (Cỡ lớn)", 50 },
                    { 11, "", 3, 150000m, "Bộ dụng cụ nấu nướng silicone chịu nhiệt (5 món)", 35 },
                    { 12, "", 4, 390000m, "Bộ hộp đựng cơm giữ nhiệt văn phòng Lock&Lock", 22 },
                    { 13, "", 4, 290000m, "Hộp đựng thực phẩm thủy tinh chịu nhiệt (Bộ 4 món)", 30 },
                    { 14, "", 5, 220000m, "Bình giữ nhiệt thể thao inox 304 (750ml)", 45 },
                    { 15, "", 5, 680000m, "Bộ ấm chén trà gốm sứ Bát Tràng cao cấp", 14 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 15);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                columns: new[] { "CategoryName", "Description" },
                values: new object[] { "Bánh kẹo & Đồ ăn vặt", "Snack, bánh quy, kẹo dẻo" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                columns: new[] { "CategoryName", "Description" },
                values: new object[] { "Nước giải khát & Trà", "Nước ngọt, nước khoáng, trà" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3,
                columns: new[] { "CategoryName", "Description" },
                values: new object[] { "Sữa & Sản phẩm từ sữa", "Sữa tươi, sữa chua, phô mai" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4,
                columns: new[] { "CategoryName", "Description" },
                values: new object[] { "Mì gói & Thực phẩm ăn liền", "Mì ăn liền, phở khô, cháo gói" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 5,
                columns: new[] { "CategoryName", "Description" },
                values: new object[] { "Gia vị & Dầu ăn", "Nước mắm, hạt nêm, dầu thực vật" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 1,
                column: "CustomerName",
                value: "Nguyễn Văn A");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 2,
                column: "CustomerName",
                value: "Trần Thị B");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 3,
                column: "CustomerName",
                value: "Lê Văn C");
        }
    }
}
