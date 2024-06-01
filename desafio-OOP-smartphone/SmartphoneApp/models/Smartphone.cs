using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartphoneApp.models
{
    public abstract class Smartphone
    {
        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;

        }
        public String Numero { get; set; }
        private String Modelo { get; set; }
        private String IMEI { get; set; }
        private int Memoria { get; set; }


        public void Ligar()
        {
            Console.WriteLine($"Ligando...{Numero}");

        }

        public void ReceberLigacao()
        {
            Console.WriteLine($"Recebendo ligação... {Numero}");

        }

        public abstract string InstalarAplicativo(String nome);
    }
}