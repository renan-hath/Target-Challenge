using TargetChallenge.Desafio01;
using TargetChallenge.Desafio03;

Console.WriteLine("==========");
Console.WriteLine("Desafio 1");
Console.WriteLine("==========");
Console.WriteLine();

int soma = Desafio01.Somar(12, 1, 0);

Console.WriteLine($"Valor da soma: {soma}");

Console.WriteLine();
Console.WriteLine("==========");
Console.WriteLine("Desafio 3");
Console.WriteLine("==========");
Console.WriteLine();

// Geração de valores aleatórios (de R$0 a R$100000) de faturamentos diários
Random random = new Random();
int dias = 365;
double[] faturamentosDiarios = new double[dias];

for (int i = 0; i < dias; i++)
{
    faturamentosDiarios[i] = Math.Round(random.NextDouble() * 100000, 2);
}

// Identificação do menor e maior faturamentos diários, e dias de faturamentos diários elevados
FaturamentoAnual faturamentoAnual = new FaturamentoAnual(faturamentosDiarios);

Console.WriteLine($"Menor faturamento diário: R${faturamentoAnual.MenorFaturamentoDiario}");
Console.WriteLine($"Maior faturamento diário: R${faturamentoAnual.MaiorFaturamentoDiario}");
Console.WriteLine($"Houve {faturamentoAnual.DiasFaturamentoElevado} dias de faturamentos diários superiores à média anual.");