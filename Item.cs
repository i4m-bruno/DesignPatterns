namespace DesignPatterns
{
    public class Item
    {
        public double Valor { get; set; }
        public string Nome { get; set; }

        public Item(double valor, string nome)
        {
            Valor = valor;
            Nome = nome;
        }
    }
}
