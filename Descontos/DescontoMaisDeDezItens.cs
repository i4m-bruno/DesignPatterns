using DesignPatterns.Entidades;
using DesignPatterns.Interfaces;

namespace DesignPatterns.Descontos
{
    internal class DescontoMaisDeDezItens : IDesconto
    {
        public IDesconto? ProximoDesconto { get; set; }

        public double CalcularDesconto(Orcamento orcamento)
        {
            if (orcamento.Itens.Count > 10)
            {
                return orcamento.Valor * 0.25;
            }
            return ProximoDesconto != null ? ProximoDesconto.CalcularDesconto(orcamento) : 0;
        }
    }
}
