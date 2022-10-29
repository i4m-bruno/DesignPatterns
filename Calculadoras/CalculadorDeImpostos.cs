using DesignPatterns.Impostos;

namespace DesignPatterns.Calculadoras
{
    public class CalculadorDeImpostos
    {
        public void Calcular(Orcamento orcamento, Imposto imposto)
        {
            var result = imposto.Calcula(orcamento);
            Console.WriteLine(result);
        }
    }
}
