namespace DesignPatterns.Estados
{
    public class EmAprovacao : IEstado
    {
        public string Nome { get; } = "Em aprovação";

        public void AplicadescontoExtra(Orcamento orcamento)
        {
            orcamento.Valor -= (orcamento.Valor * 0.1);
        }

        public void Aprova(Orcamento orcamento)
            => orcamento.EstadoAtual = new Aprovado();

        public void Finaliza(Orcamento orcamento)
            => throw new Exception("Orçamento em aprovação não pode ser finalizado");

        public void Reprova(Orcamento orcamento)
            => orcamento.EstadoAtual = new Reprovado();
    }
}
