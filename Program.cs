using DesignPatterns.Calculadoras;
using DesignPatterns.Impostos;

namespace DesignPatterns;
public class program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Calculando impostos...");
        //CalcularImpostos();

        //Console.WriteLine("----------------------------");

        Console.WriteLine("Calculando descontos...");
        //CalcularDescontos();
        CalculaDescontoPorEstado();

        Console.ReadKey();
    }

    private static void CalculaDescontoPorEstado()
    {
        Orcamento orcamento = new Orcamento(2000);
        Console.WriteLine($"Valor: {orcamento.Valor}");
        orcamento.AplicaDescontoExtra();
        Console.WriteLine($"Desconto pré aprovado: {orcamento.Valor}");
        orcamento.Aprova();
        orcamento.AplicaDescontoExtra();
        Console.WriteLine($"Desconto aprovado: {orcamento.Valor}");
        Console.ReadKey();
    }

    static void CalcularImpostos()
    {
        Imposto icmsMaisIss = new ICMS(new ISS());
        Imposto iof = new IOF();
        Imposto icpp = new ICPP();

        Orcamento orcamento = new Orcamento(2000);
        CalculadorDeImpostos calculadorDeImpostos = new CalculadorDeImpostos();

        orcamento.Itens.Add(new Item(999, "Smartphone"));

        Console.WriteLine("Valor ICMS + ISS:");
        calculadorDeImpostos.Calcular(orcamento, icmsMaisIss);
        Console.WriteLine("Valor IOF:");
        calculadorDeImpostos.Calcular(orcamento, iof);
        Console.WriteLine("Valor ICPP:");
        calculadorDeImpostos.Calcular(orcamento, icpp);
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
