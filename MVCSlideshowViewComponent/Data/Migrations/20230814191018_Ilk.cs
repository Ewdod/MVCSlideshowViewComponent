using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MVCSlideshowViewComponent.Data.Migrations
{
    /// <inheritdoc />
    public partial class Ilk : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BilgeSozler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Soz = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Yazar = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BilgeSozler", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "BilgeSozler",
                columns: new[] { "Id", "Soz", "Yazar" },
                values: new object[,]
                {
                    { 1, "Yılanı kendi ellerinle öldür", "Yiğit HACIEFENDİOĞLU" },
                    { 2, "May the source be with you", "Sinan \" Yoda \" TAŞYAPAR" },
                    { 3, "Habibi come to Dubai", "Batuhan HAYBEK" },
                    { 4, "Ne olursan ol yine de gel", "Ozan GENÇ" },
                    { 5, "Sinan anladın mı, Ozan anladın mı, Batuhan anladın mı, Emrah anladın mı, Dogukan, Serdar, Taylan, Yasin, Ceren, Gamze, Kiziltan herkes anladıysa devam edelim", "Alp CEYHAN" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BilgeSozler");
        }
    }
}
