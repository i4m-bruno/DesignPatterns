namespace DesignPatterns.Impostos
{
    public class ISS : Imposto
    {
        public ISS()
        {

        }

        public ISS(Imposto outroImposto) : base(outroImposto)
        {

        }
        public override double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.6 + CalcularOutroImposto(orcamento); ;
        }
    }
}
