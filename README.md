# Ecommerce Checkout xUnit

Projeto desenvolvido para a atividade de Garantia da Qualidade de Software, utilizando **.NET 10** e **xUnit** para a criação de testes unitários.

## Objetivo

O projeto simula algumas funcionalidades de um sistema de checkout de uma loja online, envolvendo código de rastreio, pontos de fidelidade e frete grátis.

## Funcionalidades

### 1. Gerar código de rastreio

Método:

```csharp
GerarCodigoRastreio(string regiao, int numeroPedido)
```

Recebe a região e o número do pedido e retorna o código de rastreio com a região em letras maiúsculas e o número preenchido com zeros à esquerda.

**Exemplo:**

```text
Entrada: "sudeste", 42
Saída: "SUDESTE-0042"
```

### 2. Calcular pontos de fidelidade

Método:

```csharp
CalcularPontosFidelidade(int valorTotal)
```

A cada R$ 10 em compras, o cliente recebe 2 pontos de fidelidade.

**Exemplo:**

```text
Entrada: 150
Saída: 30 pontos
```

### 3. Verificar frete grátis

Método:

```csharp
TemDireitoAFreteGratis(int valorTotal, bool eClienteVIP)
```

O cliente tem direito ao frete grátis quando o valor da compra é maior ou igual a R$ 200 ou quando é cliente VIP.

**Exemplos:**

```text
Compra de R$ 150 + cliente VIP = true
Compra de R$ 150 + cliente não VIP = false
```

## Testes Unitários

Os testes foram desenvolvidos utilizando o framework **xUnit** e o atributo `[Fact]`.

Foram utilizados:

* `Assert.Equal` para validar o código de rastreio;
* `Assert.Equal` para validar os pontos de fidelidade;
* `Assert.True` para validar o frete grátis de cliente VIP abaixo de R$ 200;
* `Assert.False` para validar a ausência de frete grátis para cliente não VIP abaixo de R$ 200.

## Como executar os testes

É necessário ter o **.NET 10 SDK** instalado.

No terminal, dentro da pasta da solução, execute:

```bash
dotnet test
```

O comando irá executar todos os testes unitários do projeto.

## Estrutura do projeto

```text
ecommerce-checkout-xunit/
│
├── EcommerceCheckout.App/
│   ├── PedidoService.cs
│   └── EcommerceCheckout.App.csproj
│
├── EcommerceCheckout.Tests/
│   ├── PedidoServiceTests.cs
│   └── EcommerceCheckout.Tests.csproj
│
├── EcommerceCheckout.sln
├── .gitignore
├── LICENSE
└── README.md
```

## Tecnologias utilizadas

* C#
* .NET 10
* xUnit
* Git
* GitHub

## Autora

**Ana Carolina Freitas**

Projeto desenvolvido para a Unidade Curricular de Garantia da Qualidade de Software.
