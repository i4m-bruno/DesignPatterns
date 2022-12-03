using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Entidades;

namespace DesignPatterns.Impostos
{
    public abstract class ImpostoCondicionalTemplate : Imposto
    {
        public override double Calcula(Orcamento orcamento)
        {
            if (DeveUsarTaxaMax(orcamento))
                return TaxaMax(orcamento);

            return TaxaPadrao(orcamento);
        }

        protected abstract double TaxaPadrao(Orcamento orcamento);
        protected abstract double TaxaMax(Orcamento orcamento);
        protected abstract bool DeveUsarTaxaMax(Orcamento orcamento);
    }
}
