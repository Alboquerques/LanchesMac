using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LanchesMac.Migrations
{
    /// <inheritdoc />
    public partial class PopularLanches : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Lanches(CategoriaId, DescricaoCurta, DescricaoDetalhada, EmEstoque, ImagemThumbnailUrl, ImagemUrl, IsLanchePreferido, Nome, Preco ) VALUES (1, 'Pão, hambúrguer, ovo, pressunto, queijo e batata palha', 'Delicioso pão de brioche com ovo frito; presunto e queijo de primeira qualidade acompanhado com batata frita', '1', '', '', '0', 'Cheese burguer', '15.50')");
            migrationBuilder.Sql("INSERT INTO Lanches(CategoriaId, DescricaoCurta, DescricaoDetalhada, EmEstoque, ImagemThumbnailUrl, ImagemUrl, IsLanchePreferido, Nome, Preco ) VALUES (1, 'Pão frances, hambúrguer suino, ovo, pressunto, queijo e batata palha', 'Delicioso pão de brioche com ovo frito; presunto e queijo de primeira qualidade acompanhado com batata frita', 1, '', '', '0', 'Cheese burguer', '22.50')");
            migrationBuilder.Sql("INSERT INTO Lanches(CategoriaId, DescricaoCurta, DescricaoDetalhada, EmEstoque, ImagemThumbnailUrl, ImagemUrl, IsLanchePreferido, Nome, Preco ) VALUES (1, 'Pão italiano, hambúrguer de costela, ovo, pressunto, queijo e batata palha', 'Delicioso pão de brioche com ovo frito; presunto e queijo de primeira qualidade acompanhado com batata frita', '1', '', '', '0', 'Cheese costela', '27.50')");
            migrationBuilder.Sql("INSERT INTO Lanches(CategoriaId, DescricaoCurta, DescricaoDetalhada, EmEstoque, ImagemThumbnailUrl, ImagemUrl, IsLanchePreferido, Nome, Preco ) VALUES (1, 'Pão de brioche, hambúrguer de 250g, ovo, pressunto, queijo e batata palha', 'Delicioso pão de brioche com ovo frito; presunto e queijo de primeira qualidade acompanhado com batata frita', '1', '', '', '0', 'Cheese da casa', '30.00')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Categoria");
        }
    }
}
