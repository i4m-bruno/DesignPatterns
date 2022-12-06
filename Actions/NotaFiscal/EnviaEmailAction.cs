using DesignPatterns.Interfaces;

namespace DesignPatterns.Actions.NotaFiscal
{
    public class EnviaEmailAction : INotaFiscalAction
    {
        public void Executa(Entidades.NotaFiscal nf)
        {
            Console.WriteLine("Enviando Email...");
        }
    }
}
