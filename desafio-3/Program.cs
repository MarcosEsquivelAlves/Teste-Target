using System;

class Program
{
    static void Main(string[] args)
    {
        double[] faturamentoDiario = { 1500.50, 2000.75, 1800.25, 2200.00, 1700.10, 2100.65, 2500.90,
                                        1900.80, 1600.45, 2000.00, 2100.10, 2200.25, 2300.50, 2500.75,
                                        2600.85, 2400.00, 2200.10, 2100.00, 2300.75, 2400.30, 2500.50,
                                        2600.75, 2700.80, 2800.95, 2900.00, 3000.25, 3100.50, 3200.75 };

        CalcularFaturamento(faturamentoDiario);
    }

    static void CalcularFaturamento(double[] faturamentoDiario)
    {
        if (faturamentoDiario.Length == 0)
        {
            Console.WriteLine("Nenhum dado de faturamento fornecido.");
            return;
        }

        double menorFaturamento = faturamentoDiario[0];
        double maiorFaturamento = faturamentoDiario[0];
        double somaFaturamento = 0;

        foreach (double faturamento in faturamentoDiario)
        {
            if (faturamento < menorFaturamento)
            {
                menorFaturamento = faturamento;
            }
            if (faturamento > maiorFaturamento)
            {
                maiorFaturamento = faturamento;
            }
            somaFaturamento += faturamento;
        }

        double mediaMensal = somaFaturamento / faturamentoDiario.Length;

        int diasAcimaDaMedia = 0;
        foreach (double faturamento in faturamentoDiario)
        {
            if (faturamento > mediaMensal)
            {
                diasAcimaDaMedia++;
            }
        }

        Console.WriteLine($"Menor valor de faturamento: {menorFaturamento:C2}");
        Console.WriteLine($"Maior valor de faturamento: {maiorFaturamento:C2}");
        Console.WriteLine($"Número de dias com faturamento acima da média mensal: {diasAcimaDaMedia}");
        Console.ReadKey();
    }
}
