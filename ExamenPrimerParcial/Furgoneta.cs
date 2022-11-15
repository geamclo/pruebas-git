using System;
using System.Collections.Generic;
using System.Text;

namespace ExamenPrimerParcial
{
   public class Furgoneta:Vehiculo, ICalculardor
    {
        public double NumerodeAsientos { get; set; }
        public double PrecioBase { get; set; }
        public double PreciodeAsiento { get; set; }

        public void CalculoaCobrar()  
        {
            double Proceso1;
            double Proceso2;

            Proceso1 = NumerodeAsientos * PreciodeAsiento;
            Proceso2 = PrecioBase + PreciodeAsiento;
            Console.WriteLine(Proceso2);
            Console.ReadKey();
        }


    }
}
