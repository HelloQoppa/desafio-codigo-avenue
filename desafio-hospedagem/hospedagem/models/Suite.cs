using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hospedagem.models
{
    public class Suite
    {
        public Suite(string tipoSuite, int capacidade, decimal valorDiaria)
        {

            TipoSuite = tipoSuite;
            Capacidade = capacidade;
            ValorDiaria = valorDiaria;
        }
        public String TipoSuite { get; set; }
        public int Capacidade { get; set; }
        public Decimal ValorDiaria { get; set; }
    }
}