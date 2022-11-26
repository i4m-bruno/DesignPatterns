using DesignPatterns.Estados;

namespace DesignPatterns
{
    public class Orcamento
    {
        public IEstado EstadoAtual { get; set; }
        public double Valor { get; set; }
        public IList<Item> Itens { get; set; } = new List<Item>();
        public Orcamento(double valor)
        {
            Valor = valor;
            EstadoAtual = new EmAprovacao();
        }

        public void AdicionaItem(Item item)
        {
            Itens.Add(item);
        }

        public void AplicaDescontoExtra() => EstadoAtual.AplicadescontoExtra(this);
        public void Aprova() => EstadoAtual.Aprova(this);

        public void Reprova() => EstadoAtual.Reprova(this);

        public void Finaliza() => EstadoAtual.Finaliza(this);
    }
}
