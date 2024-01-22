using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolCafeteriaDatabaseImplement.Migrations
{
    /// <inheritdoc />
    public partial class AddSchoolCafeteriaMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GoodsCompositions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GoodsId = table.Column<int>(type: "int", nullable: true),
                    TechMapId = table.Column<int>(type: "int", nullable: true),
                    Protein = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Fat = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Carb = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    B1 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    C = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    A = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    E = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Ca = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    P = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Mg = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Fe = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GoodsCompositions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Login = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Goods",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BruttoMass = table.Column<int>(type: "int", nullable: false),
                    NettoMass = table.Column<int>(type: "int", nullable: false),
                    MarkToDelete = table.Column<bool>(type: "bit", nullable: false),
                    GoodsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Goods", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Goods_GoodsCompositions_GoodsId",
                        column: x => x.GoodsId,
                        principalTable: "GoodsCompositions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TechnologicalMaps",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DishName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RecipeNumber = table.Column<int>(type: "int", nullable: false),
                    CookingTechnology = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TechMapId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TechnologicalMaps", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TechnologicalMaps_GoodsCompositions_TechMapId",
                        column: x => x.TechMapId,
                        principalTable: "GoodsCompositions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TechMapGoods",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TechMapId = table.Column<int>(type: "int", nullable: false),
                    GoodsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TechMapGoods", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TechMapGoods_Goods_GoodsId",
                        column: x => x.GoodsId,
                        principalTable: "Goods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TechMapGoods_TechnologicalMaps_TechMapId",
                        column: x => x.TechMapId,
                        principalTable: "TechnologicalMaps",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Goods_GoodsId",
                table: "Goods",
                column: "GoodsId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TechMapGoods_GoodsId",
                table: "TechMapGoods",
                column: "GoodsId");

            migrationBuilder.CreateIndex(
                name: "IX_TechMapGoods_TechMapId",
                table: "TechMapGoods",
                column: "TechMapId");

            migrationBuilder.CreateIndex(
                name: "IX_TechnologicalMaps_TechMapId",
                table: "TechnologicalMaps",
                column: "TechMapId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TechMapGoods");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Goods");

            migrationBuilder.DropTable(
                name: "TechnologicalMaps");

            migrationBuilder.DropTable(
                name: "GoodsCompositions");
        }
    }
}
