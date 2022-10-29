namespace DesignPatterns
{
    public interface IDesconto
    {
        IDesconto? ProximoDesconto { get; set; }
        double CalcularDesconto(Orcamento orcamento);
    }
}
