using DesignPatterns.Calculadoras;
using DesignPatterns.Impostos;

namespace DesignPatterns;
public class program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Calculando impostos...");
        CalcularImpostos();

        Console.WriteLine("----------------------------");

        Console.WriteLine("Calculando descontos...");
        CalcularDescontos();

        Console.ReadKey();
    }

    static void CalcularImpostos()
    {
        Imposto icms = new ICMS();
        Imposto iss = new ISS();

        Orcamento orcamento = new Orcamento(500);
        CalculadorDeImpostos calculadorDeImpostos = new CalculadorDeImpostos();

        Console.WriteLine("Valor ICMS:");
        calculadorDeImpostos.Calcular(orcamento, icms);
        Console.WriteLine("Valor ISS:");
        calculadorDeImpostos.Calcular(orcamento, iss);
    }

    static void CalcularDescontos()
    {
        Orcamento orcamento = new Orcamento(4000);
        CalculadorDeDesconto calculadorDeDesconto = new CalculadorDeDesconto();

        orcamento.Itens.Add(new Item(500, "Placa mãe"));
        orcamento.Itens.Add(new Item(2000, "Ryzen 7 5400G"));
        orcamento.Itens.Add(new Item(700, "Fonte Modular 700w"));
        orcamento.Itens.Add(new Item(300, "SSD 254GB"));
        orcamento.Itens.Add(new Item(800, "32GB RAM DDR4"));
        orcamento.Itens.Add(new Item(200, "Gabinete"));

        foreach (var item in orcamento.Itens)
        {
            Console.WriteLine($"Item {item.Nome} adicionado ao orcamento. Valor: {item.Valor}");
        }

        Console.WriteLine("Desconto aplicado:");
        var desconto = calculadorDeDesconto.Calcula(orcamento);
        Console.WriteLine(desconto);
    }
}
