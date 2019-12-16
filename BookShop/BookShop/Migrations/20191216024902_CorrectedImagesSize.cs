using Microsoft.EntityFrameworkCore.Migrations;

namespace BookShop.Migrations
{
    public partial class CorrectedImagesSize : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 1,
                column: "ImageThumbnailUrl",
                value: "https://i.ibb.co/dPjGfXz/Webp-net-resizeimage-3.png");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 2,
                column: "ImageThumbnailUrl",
                value: "https://i.ibb.co/fkPtdL8/Webp-net-resizeimage-4.png");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 3,
                column: "ImageThumbnailUrl",
                value: "https://i.ibb.co/k1vrFZN/Webp-net-resizeimage-1.png");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 4,
                column: "ImageThumbnailUrl",
                value: "https://i.ibb.co/FKsN8SN/Webp-net-resizeimage.png");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5,
                column: "ImageThumbnailUrl",
                value: "https://i.ibb.co/hDBYgCY/9781454926214.jpg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 6,
                column: "ImageThumbnailUrl",
                value: "https://i.ibb.co/dcNJ1Kx/9780007284870.jpg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 7,
                columns: new[] { "ImageThumbnailUrl", "Name" },
                values: new object[] { "https://i.ibb.co/vjXQnYF/9781593271053.jpg", "Steal This Book" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 8,
                column: "ImageThumbnailUrl",
                value: "https://i.ibb.co/1vDYw6b/9781409350156.jpg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 9,
                column: "ImageThumbnailUrl",
                value: "https://i.ibb.co/Hhc8DFm/9780748782987.jpg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 10,
                column: "ImageThumbnailUrl",
                value: "https://i.ibb.co/540LJMc/9781118779613.jpg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 11,
                column: "ImageThumbnailUrl",
                value: "https://i.ibb.co/vqkbW7W/9780994169310.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 1,
                column: "ImageThumbnailUrl",
                value: "https://i.ibb.co/Kjtb65X/Webp-net-resizeimage-3.png");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 2,
                column: "ImageThumbnailUrl",
                value: "https://i.ibb.co/WKQhH0y/Webp-net-resizeimage-4.png");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 3,
                column: "ImageThumbnailUrl",
                value: "https://i.ibb.co/MsdKCV7/Webp-net-resizeimage-1.png");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 4,
                column: "ImageThumbnailUrl",
                value: "https://i.ibb.co/0fMVNn0/Webp-net-resizeimage.png");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5,
                column: "ImageThumbnailUrl",
                value: "https://i.ibb.co/sQxFrwq/9781454926214.jpg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 6,
                column: "ImageThumbnailUrl",
                value: "https://i.ibb.co/ByHZvKm/9780007284870-1.jpg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 7,
                columns: new[] { "ImageThumbnailUrl", "Name" },
                values: new object[] { "https://i.ibb.co/TwCbZwF/9781593271053.jpg", "Steal This Book 5.0" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 8,
                column: "ImageThumbnailUrl",
                value: "https://i.ibb.co/3sZ2sSF/9781409350156.jpg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 9,
                column: "ImageThumbnailUrl",
                value: "https://i.ibb.co/HDFRggX/9780748782987.jpg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 10,
                column: "ImageThumbnailUrl",
                value: "https://i.ibb.co/qntD57Y/9781118779613.jpg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 11,
                column: "ImageThumbnailUrl",
                value: "https://i.ibb.co/ZgTyN6L/9780994169310.jpg");
        }
    }
}
