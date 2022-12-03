using DesignPatterns.Entidades;

namespace DesignPatterns.Interfaces
{
    public interface IDesconto
    {
        IDesconto? ProximoDesconto { get; set; }
        double CalcularDesconto(Orcamento orcamento);
    }
}
