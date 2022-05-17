using Microsoft.EntityFrameworkCore.Migrations;

namespace Stone.Estabelecimentos.INFRA.Migrations
{
    public partial class MigrationsStoneEstabelecimentos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TB_ESTABELECIMENTO",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome_estabelecimento = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    classificacao = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_ESTABELECIMENTO", x => x.id);
                });

            migrationBuilder.InsertData(
                table: "TB_ESTABELECIMENTO",
                columns: new[] { "id", "classificacao", "nome_estabelecimento" },
                values: new object[,]
                {
                    { 1L, 1, "Padaria Stn" },
                    { 2L, 4, "T-Shirt Stn" },
                    { 3L, 2, "CineStn" },
                    { 4L, 3, "EletroStn" },
                    { 5L, 1, "Rosquinha Stn" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TB_ESTABELECIMENTO");
        }
    }
}
