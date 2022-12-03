using DesignPatterns.Entidades;

namespace DesignPatterns.Impostos
{
    public class ICPP : ImpostoCondicionalTemplate
    {
        protected override bool DeveUsarTaxaMax(Orcamento orcamento)
        {
            return orcamento.Valor > 900 && orcamento.Itens.Count() < 2;
        }

        protected override double TaxaMax(Orcamento orcamento)
        {
            return orcamento.Valor * 0.2;
        }

        protected override double TaxaPadrao(Orcamento orcamento)
        {
            return 0;
        }
    }
}
