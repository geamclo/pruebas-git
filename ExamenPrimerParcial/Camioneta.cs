using System;
using System.Collections.Generic;
using System.Text;

namespace ExamenPrimerParcial
{
    public class Camioneta : Vehiculo, ICalculardor
    {
        public string TipodeCabina { get; set; }


        public void CalculoaCobrar()
        {
            if (TipodeCabina == "Cabina Simple")
            {

                Console.WriteLine("$ 15.000");
            }
            else
            {

                Console.WriteLine("$ 20.000");
            }

        }
    }
}

