using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MisNuevasFunciones;
using PuntoPOO2022.Entidades;

namespace PuntoPOO2022.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            var coordX = IngresoDatos.PedirInt("Ingrese Coord. X del punto:");
            var coordY = IngresoDatos.PedirInt("Ingrese Coord. Y del punto:");

            Punto punto=new Punto(coordX,coordY);

            Console.WriteLine($"Coord. Cartesianas={punto.ToString()}");
            Console.WriteLine($"Coord. Polares={punto.GetCoordPolares()}");
            Console.ReadLine();
        }
    }
}
