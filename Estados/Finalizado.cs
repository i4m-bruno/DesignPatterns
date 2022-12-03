using DesignPatterns.Entidades;

namespace DesignPatterns.Estados
{
    public class Finalizado : IEstado
    {
        public string Nome { get; } = "Finalizado";

        public void AplicadescontoExtra(Orcamento orcamento)
            => throw new Exception("Orçamento finalizado não recebe desconto");

        public void Aprova(Orcamento orcamento)
            => throw new Exception("Orçamento já se encontra finalizado");

        public void Finaliza(Orcamento orcamento)
            => throw new Exception("Orçamento já se encontra finalizado");

        public void Reprova(Orcamento orcamento)
            => throw new Exception("Orçamento já se encontra finalizado");
    }
}
