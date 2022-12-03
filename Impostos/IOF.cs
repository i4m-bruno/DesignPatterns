using DesignPatterns.Entidades;

namespace DesignPatterns.Impostos
{
    public class IOF : ImpostoCondicionalTemplate
    {
        protected override bool DeveUsarTaxaMax(Orcamento orcamento)
        {
            return orcamento.Valor > 500 && ExisteItemMaiorQ100(orcamento);
        }

        private bool ExisteItemMaiorQ100(Orcamento orcamento)
        {
            foreach (var item in orcamento.Itens)
            {
                if (item.Valor > 100)
                    return true;
            }
            return false;
        }

        protected override double TaxaMax(Orcamento orcamento)
        {
            return orcamento.Valor * 0.3;
        }

        protected override double TaxaPadrao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.15;
        }
    }
}
