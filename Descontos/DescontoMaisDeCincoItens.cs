using DesignPatterns.Entidades;
using DesignPatterns.Interfaces;

namespace DesignPatterns.Descontos
{
    public class DescontoMaisDeCincoItens : IDesconto
    {
        public IDesconto? ProximoDesconto { get; set; }

        public double CalcularDesconto(Orcamento orcamento)
        {
            if (orcamento.Itens.Count > 5)
            {
                return orcamento.Valor * 0.15;
            }
            return ProximoDesconto != null ? ProximoDesconto.CalcularDesconto(orcamento) : 0;
        }
    }
}
