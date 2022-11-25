namespace DesignPatterns
{
    public class Orcamento
    {
        public double Valor { get; private set; }
        public IList<Item> Itens { get; private set; } = new List<Item>();
        public Orcamento(double valor)
        {
            Valor = valor;
        }

        public void AdicionaItem(Item item)
        {
            Itens.Add(item);
        }
    }
}
