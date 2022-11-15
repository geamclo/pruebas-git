using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExamenPrimerParcial
{
    public class Vehiculo
    {
        //Propiedades
        public string AñodeCreacion { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public List<Vehiculo> ListaVehiculo = new List<Vehiculo>();

        //Metodo que permite mostrar por pantalla todos los datos de las propiedades de la entidad 
        public void Imprimir(string año, string marca, string modelo) 
        {
            Console.WriteLine("\t\nAño:" + AñodeCreacion + "\t\nMarca:" + Marca + "\t\nModelo:" + Modelo);
            Console.ReadKey();


        }
    }
}
