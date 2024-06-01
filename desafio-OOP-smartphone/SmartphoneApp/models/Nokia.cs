using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartphoneApp.models
{
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

        public override string InstalarAplicativo(string nome)
        {
            return "Instalando aplicativo no Nokia";
        }
    }
}