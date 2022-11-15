using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace ExamenPrimerParcial
{
    class Program
    {
        static void Main(string[] args)
        {

            Vehiculo Vehiculo1 = new Vehiculo();
            Vehiculo1.AñodeCreacion = "2006";
            Vehiculo1.Marca = "Nissan";
            Vehiculo1.Modelo = "Versa";
            Vehiculo1.Imprimir(Vehiculo1.AñodeCreacion, Vehiculo1.Marca, Vehiculo1.Modelo);



            Auto Auto1 = new Auto();
            Auto1.PrecioVehiculo = 30.000;
            Auto1.Tipo = "Sedan";
            Auto1.CalculoaCobrar();
            Console.ReadKey();

            Auto Auto2 = new Auto();
            Auto2.PrecioVehiculo = 30.000;
            Auto2.Tipo = "Hatchback";
            Auto2.CalculoaCobrar();
            Console.ReadKey();



            Camioneta Camioneta1 = new Camioneta();
            Camioneta1.Marca = "Chevrolet";
            Camioneta1.Modelo = "D-Max";
            Camioneta1.TipodeCabina = "Cabina Simple";
            Camioneta1.CalculoaCobrar();
            Console.ReadKey();

            Camioneta Camioneta2 = new Camioneta();
            Camioneta2.Marca = "Volkswagen";
            Camioneta2.Modelo = "Amarock";
            Camioneta2.TipodeCabina = "Cabina Doble";
            Camioneta2.CalculoaCobrar();
            Console.ReadKey();



            Furgoneta Furgoneta1 = new Furgoneta();
            Furgoneta1.Marca = "Hyndai";
            Furgoneta1.Modelo = "H1";
            Furgoneta1.PrecioBase = 15.000;
            Furgoneta1.NumerodeAsientos = 8;
            Furgoneta1.PreciodeAsiento = 50;
            Furgoneta1.CalculoaCobrar();
            Console.ReadKey();



            //Lista tipo clase padre
            Vehiculo Carro = new Vehiculo();
            Carro.ListaVehiculo = new List<Vehiculo>();


            Carro.ListaVehiculo.Add(Vehiculo1);
            Carro.ListaVehiculo.Add(Auto1);
            Carro.ListaVehiculo.Add(Camioneta1);
            Carro.ListaVehiculo.Add(Furgoneta1);

            foreach (var Vehiculo in Carro.ListaVehiculo)
            {
                Console.WriteLine(" " + Vehiculo);

            }






        } 
       
    }
}
