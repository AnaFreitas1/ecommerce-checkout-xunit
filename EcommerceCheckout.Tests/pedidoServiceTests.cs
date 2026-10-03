using Xunit;
using EcommerceCheckout.App;

namespace EcommerceCheckout.Tests;

public class PedidoServiceTests
{
    [Fact]
    public void GerarCodigoRastreio_DeveRetornarCodigoFormatado()
    {
        var service = new PedidoService();

        string resultado = service.GerarCodigoRastreio("sudeste", 42);

        Assert.Equal("SUDESTE-0042", resultado);
    }

    [Fact]
    public void CalcularPontosFidelidade_DeveCalcularPontosCorretamente()
    {
        var service = new PedidoService();

        int resultado = service.CalcularPontosFidelidade(150);

        Assert.Equal(30, resultado);
    }

    [Fact]
    public void TemDireitoAFreteGratis_CompraVIPAbaixo200_DeveRetornarTrue()
    {
        var service = new PedidoService();

        bool resultado = service.TemDireitoAFreteGratis(150, true);

        Assert.True(resultado);
    }

    [Fact]
    public void TemDireitoAFreteGratis_CompraNaoVIPAbaixo200_DeveRetornarFalse()
    {
        var service = new PedidoService();

        bool resultado = service.TemDireitoAFreteGratis(150, false);

        Assert.False(resultado);
    }
}