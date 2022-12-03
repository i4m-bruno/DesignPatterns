using DesignPatterns.Entidades;

namespace DesignPatterns.Estados
{
    public class Aprovado : IEstado
    {
        public string Nome { get; } = "Aprovado";

        public void AplicadescontoExtra(Orcamento orcamento)
        {
            orcamento.Valor -= (orcamento.Valor * 0.2);
        }

        public void Aprova(Orcamento orcamento)
            => throw new Exception("Orçamento já se encontra aprovado");

        public void Finaliza(Orcamento orcamento)
            => orcamento.EstadoAtual = new Finalizado();

        public void Reprova(Orcamento orcamento)
            => orcamento.EstadoAtual = new Reprovado();
    }
}
