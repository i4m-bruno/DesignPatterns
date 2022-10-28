namespace DesignPatterns;
public class program
{
    static void Main(string[] args)
    {
        Imposto icms = new ICMS();
        Imposto iss = new ISS();

        Orcamento orcamento = new Orcamento(500);
        CalculadorDeImpostos calculadorDeImpostos = new CalculadorDeImpostos();

        calculadorDeImpostos.Calcular(orcamento, icms);
        calculadorDeImpostos.Calcular(orcamento, iss);

        Console.ReadKey();
    }
}
