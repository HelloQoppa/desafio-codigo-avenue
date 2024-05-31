using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hospedagem.models
{
    public class Reserva
    {

        public Reserva(List<Pessoa> hospede, Suite suite, int diasReservados)

        {
            Hospedes = hospede;
            Suite = suite;
            DiasReservados = diasReservados;

        }
        public List<Pessoa> Hospedes { get; set; }

        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public void CadastarHospedes(List<Pessoa> hospedes)
        {

            if (hospedes.Capacity <= Suite.Capacidade)
            {
                Hospedes = hospedes;

            }
            else
            {
                Console.WriteLine("Capacidade de hospedes não permitida");
            }


        }

        public void CadastarSuite(Suite suite)
        {
            this.Suite = suite;

        }

        public int ObterQuantidadeHospedes()
        {
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            decimal ValorDiaria = 0;
            decimal disconto = 0.10M;
            ValorDiaria = Suite.ValorDiaria * DiasReservados;

            if (DiasReservados.Equals(10))
            {
                ValorDiaria = ValorDiaria * disconto;
            }

            return ValorDiaria;
        }
    }
}