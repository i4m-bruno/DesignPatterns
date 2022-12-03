using DesignPatterns.Entidades;

namespace DesignPatterns.Impostos
{
    public abstract class Imposto
    {
        public Imposto? OutroImposto { get; set; }
        public Imposto()
        {
            this.OutroImposto = null;
        }

        public Imposto(Imposto? outroImposto)
        {
            OutroImposto = outroImposto;
        }

        public abstract double Calcula(Orcamento orcamento);

        protected double CalcularOutroImposto(Orcamento orcamento)
        {
            if (OutroImposto == null)
                return 0;

            return OutroImposto.Calcula(orcamento);
        }
    }
}
