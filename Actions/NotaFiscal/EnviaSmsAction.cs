using DesignPatterns.Interfaces;

namespace DesignPatterns.Actions.NotaFiscal
{
    public class EnviaSmsAction : INotaFiscalAction
    {
        public void Executa(Entidades.NotaFiscal nf)
        {
            Console.WriteLine("Enviando sms...");
        }
    }
}
