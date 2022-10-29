using DesignPatterns.Descontos;

namespace DesignPatterns.Calculadoras
{
    public class CalculadorDeDesconto
    {
        public double Calcula(Orcamento orcamento)
        {
            var d1 = new DescontoMaisDeCincoItens();
            var d2 = new DescontoMaisDeDezItens();

            d1.ProximoDesconto = d2;

            return d1.CalcularDesconto(orcamento);
        }
    }
}
