using System;
using System.Collections.Generic;
using System.Text;

namespace ExamenPrimerParcial
{
   public class Auto:Vehiculo, ICalculardor
    {
       
        
        public double PrecioVehiculo{ get; set; }
        public string Tipo { get; set; }



        public void CalculoaCobrar() 
        {
            if (Tipo == "Sedan")
            {
                Console.WriteLine(PrecioVehiculo);
            }
            else 
            {
                double Precio = 0;
                Precio = this.PrecioVehiculo * 0.10;
                PrecioVehiculo = PrecioVehiculo - Precio;
                Console.WriteLine(PrecioVehiculo);
            }
           

        }
        
    }
}
