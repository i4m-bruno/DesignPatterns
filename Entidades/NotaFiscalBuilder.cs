using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Entidades
{
    public class NotaFiscalBuilder
    {
        public string RazaoSocial { get; private set; } = "";
        public List<ItemNota> Itens { get; private set; } = new List<ItemNota>();
        public DateTime Data { get; private set; } = DateTime.UtcNow;
        public string Observacao { get; private set; } = "";
        public double ValorTotal { get; private set; } = 0;

        public NotaFiscalBuilder()
        {

        }

        public NotaFiscalBuilder(string razaoSocial, List<ItemNota> itens, DateTime data, string observacao)
        {
            RazaoSocial = razaoSocial;
            Itens = itens;
            Data = data;
            Observacao = observacao;
        }

        public NotaFiscal GerarNota()
        {
            return new NotaFiscal(RazaoSocial, Itens, Data, Observacao, ValorTotal);
        }

        public NotaFiscalBuilder ComRazaoSocial(string razaoSocial)
        {
            RazaoSocial = razaoSocial;
            return this;
        }

        public NotaFiscalBuilder ComItem(ItemNota item)
        {
            Itens.Add(item);
            ValorTotal += item.Valor;
            return this;
        }
        public NotaFiscalBuilder ComData(DateTime data)
        {
            Data = data;
            return this;
        }
        public NotaFiscalBuilder ComObservacao(string observacao)
        {
            Observacao = observacao;
            return this;
        }
    }
}
