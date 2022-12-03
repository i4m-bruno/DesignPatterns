using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Entidades
{
    public class NotaFiscal
    {
        public Guid Id { get; private set; }
        public string RazaoSocial { get; private set; }
        public List<ItemNota> Itens { get; private set; }
        public DateTime Data { get; private set; }
        public string Observacao { get; private set; }
        public double ValorTotal { get; set; }

        public NotaFiscal(string razaoSocial, List<ItemNota> itens, DateTime data, string observacao, double valorT)
        {
            Id = Guid.NewGuid();
            RazaoSocial = razaoSocial;
            Itens = itens;
            Data = data;
            Observacao = observacao;
            ValorTotal = valorT;

        }
    }
}
