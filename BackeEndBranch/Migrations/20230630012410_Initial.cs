using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BackeEndBranch.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Branchs",
                columns: table => new
                {
                    CodeBranch = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DescriptionBranch = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    AdressBranch = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    IdentificationBranch = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DateBranch = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FKMoneyBranch = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Branchs", x => x.CodeBranch);
                });

            migrationBuilder.CreateTable(
                name: "Coins",
                columns: table => new
                {
                    IdCoin = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameCoin = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DescriptionCoin = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StateCoin = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coins", x => x.IdCoin);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Branchs");

            migrationBuilder.DropTable(
                name: "Coins");
        }
    }
}
