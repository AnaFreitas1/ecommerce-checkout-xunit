namespace EcommerceCheckout.App;

public class PedidoService
{
    // 1. Gerar Código de Rastreio (Região em maiúsculas + número com 4 dígitos)
    public string GerarCodigoRastreio(string regiao, int numeroPedido)
    {
        string regiaoMaiuscula = regiao.ToUpper();
        string numeroFormatado = numeroPedido.ToString("D4");
        return $"{regiaoMaiuscula}-{numeroFormatado}";
    }

    // 2. Calcular Pontos de Fidelidade (2 pontos a cada R$ 10)
    public int CalcularPontosFidelidade(int valorTotal)
    {
        return (valorTotal / 10) * 2;
    }

    // 3. Verificar Direito a Frete Grátis (Valor >= 200 OU Cliente VIP)
    public bool TemDireitoAFreteGratis(int valorTotal, bool eClienteVIP)
    {
        return valorTotal >= 200 || eClienteVIP;
    }
}