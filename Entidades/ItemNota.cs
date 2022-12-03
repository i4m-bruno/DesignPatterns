using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Entidades
{
    public class ItemNota
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public double Valor { get; set; }

        public ItemNota(string nome, double valor)
        {
            Id = Guid.NewGuid();
            Nome = nome;
            Valor = valor;
        }
    }
}
