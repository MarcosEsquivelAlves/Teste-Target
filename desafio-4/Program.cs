using System;

internal class Program
{
    static void Main(string[] args)
    {

        double SP = 67836.43;
        double RJ = 36678.66;
        double MG = 29229.88;
        double ES = 27165.48;
        double Outros = 19849.53;

        double faturamentoTotal = CalcularFaturamentoTotal(SP, RJ, MG, ES, Outros);
        Console.WriteLine($"O faturamento total é {faturamentoTotal}");


        Estado estadoSP = new Estado("São Paulo", SP);
        Estado estadoRJ = new Estado("Rio de Janeiro", RJ);
        Estado estadoMG = new Estado("Minas Gerais", MG);
        Estado estadoES = new Estado("Espírito Santo", ES);
        Estado estadoOutros = new Estado("Outros", Outros);

        estadoSP.CalcularPercentual(faturamentoTotal);
        estadoRJ.CalcularPercentual(faturamentoTotal);
        estadoMG.CalcularPercentual(faturamentoTotal);
        estadoES.CalcularPercentual(faturamentoTotal);
        estadoOutros.CalcularPercentual(faturamentoTotal);

        Console.ReadKey();
    }

    static double CalcularFaturamentoTotal(double sp, double rj, double mg, double es, double outros)
    {
        return sp + rj + mg + es + outros;
    }
}

class Estado
{
    public string Nome { get; }
    public double Faturamento { get; }

    public Estado(string nome, double faturamento)
    {
        Nome = nome;
        Faturamento = faturamento;
    }

    public void CalcularPercentual(double faturamentoTotal)
    {
        double percentual = (Faturamento / faturamentoTotal) * 100;
        Console.WriteLine($"Percentual de {Nome}: {percentual:F2}%");
    }
}
