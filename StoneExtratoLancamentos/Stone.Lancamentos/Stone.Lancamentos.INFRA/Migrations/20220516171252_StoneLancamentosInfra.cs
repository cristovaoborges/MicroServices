using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Stone.Lancamentos.INFRA.Migrations
{
    public partial class StoneLancamentosInfra : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TB_LANCAMENTO",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    data_referencia = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FormaPagamento = table.Column<int>(type: "int", nullable: false),
                    estabelecimento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Valor = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_LANCAMENTO", x => x.id);
                });

            migrationBuilder.InsertData(
                table: "TB_LANCAMENTO",
                columns: new[] { "id", "data_referencia", "estabelecimento", "FormaPagamento", "Valor" },
                values: new object[] { 1L, new DateTime(2022, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Padaria Stn", 1, 70m });

            migrationBuilder.InsertData(
                table: "TB_LANCAMENTO",
                columns: new[] { "id", "data_referencia", "estabelecimento", "FormaPagamento", "Valor" },
                values: new object[] { 2L, new DateTime(2022, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Roupas Stn", 2, 1000m });

            migrationBuilder.InsertData(
                table: "TB_LANCAMENTO",
                columns: new[] { "id", "data_referencia", "estabelecimento", "FormaPagamento", "Valor" },
                values: new object[] { 3L, new DateTime(2022, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Roupas Stn", 2, 1000m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TB_LANCAMENTO");
        }
    }
}
