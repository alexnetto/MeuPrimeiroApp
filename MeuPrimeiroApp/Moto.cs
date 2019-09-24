using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuPrimeiroApp
{
    class Moto
    {
        public string Modelo;
        public string Cor;
        public int QuantidadeDeLugares;
        public bool PossuiPartidaAutomatica;

        public Moto()
        {
            Modelo = "Cb 300";
            Cor = "azul";
            QuantidadeDeLugares = 2;
            PossuiPartidaAutomatica = false;

        }

        public string Ligar()
        {
            return "Moto Ligada";
        }

        public string Desligar()
        {
            return "Moto Desligada";
        }
        public string Detalhes()
        {
            return Modelo + "-" + Cor;
        }

    }
}
