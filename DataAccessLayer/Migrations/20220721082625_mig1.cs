using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "publishers",
                columns: table => new
                {
                    publisherID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    publisherName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_publishers", x => x.publisherID);
                });

            migrationBuilder.CreateTable(
                name: "books",
                columns: table => new
                {
                    bookID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    bookName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    bookAuthor = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    publisherspublisherID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_books", x => x.bookID);
                    table.ForeignKey(
                        name: "FK_books_publishers_publisherspublisherID",
                        column: x => x.publisherspublisherID,
                        principalTable: "publishers",
                        principalColumn: "publisherID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_books_publisherspublisherID",
                table: "books",
                column: "publisherspublisherID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "books");

            migrationBuilder.DropTable(
                name: "publishers");
        }
    }
}
