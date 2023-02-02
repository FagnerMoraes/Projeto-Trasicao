using AutoFixture;
using ProjetoTransicao.Application.Contextos.Categorias.Dtos;
using ProjetoTransicao.Tests.Base;

namespace ProjetoTransicao.Tests.Application.Fakes;

public class AtualizarCategoriaDtoFake : IFake<AtualizarCategoriaDto>
{
    private readonly Fixture _fixture;

    public AtualizarCategoriaDtoFake(Fixture fixture)
    {
        _fixture = fixture;
    }
    public AtualizarCategoriaDto GerarEntidadeInvalida()
    {
        var dto = _fixture.Build<AtualizarCategoriaDto>()
                          .Without(x => x.Descricao)
                          .Do(x =>
                          {
                              x.Descricao = string.Empty;
                          })
                          .Create();

        return dto;
    }

    public AtualizarCategoriaDto GerarEntidadeValida()
    {
        var dto = _fixture.Build<AtualizarCategoriaDto>()
                          .Without(x => x.Descricao)
                          .Without(x => x.Nome)
                          .Without(x => x.Id)
                          .Do(x =>
                          {
                              x.Id = new Guid("09951917-ef91-49f8-8e66-b03e78cab95a");
                              x.Nome = "Categoria";
                              x.Descricao = "Descrição";
                          })
                          .Create();

        return dto;
    }
}
