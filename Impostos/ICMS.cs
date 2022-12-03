﻿using DesignPatterns.Entidades;

namespace DesignPatterns.Impostos
{
    public class ICMS : Imposto
    {
        public ICMS()
        {

        }
        public ICMS(Imposto outroImposto) : base(outroImposto)
        {

        }
        public override double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.1 + CalcularOutroImposto(orcamento);
        }
    }
}
