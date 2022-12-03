using DesignPatterns.Entidades;

namespace DesignPatterns.Estados
{
    public class Reprovado : IEstado
    {
        public string Nome { get; } = "Reprovado";

        public void AplicadescontoExtra(Orcamento orcamento)
        {
            throw new Exception("Orçamento reprovado não recebe desconto");

        }

        public void Aprova(Orcamento orcamento)
            => throw new Exception("Orçamento reprovado não pode ser aprovado, faça um novo orçamento");

        public void Finaliza(Orcamento orcamento)
            => orcamento.EstadoAtual = new Finalizado();

        public void Reprova(Orcamento orcamento)
            => throw new Exception("Orçamento já se encontra reprovado");
    }
}
