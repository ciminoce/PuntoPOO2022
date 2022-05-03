using System;

namespace PuntoPOO2022.Entidades
{
    public class Punto
    {
        
        public int CoordX { get; set; }
        public int CoordY { get; set; }

        public Punto()
        {
            
        }
        public Punto(int valorX, int valorY)
        {
            this.CoordX = valorX;
            this.CoordY = valorY;
        }

        public double GetDistanciaAlOrigen() => Math.Sqrt(Math.Pow(this.CoordX, 2) + Math.Pow(this.CoordY, 2));

        public Cuadrante GetCuadrante()
        {
            if (this.CoordX>=0 && this.CoordY>=0)
            {
                return Cuadrante.Primero;
            }else if (this.CoordX<0 && this.CoordY>0)
            {
                return Cuadrante.Segundo;
            }else if (this.CoordX < 0 && this.CoordY < 0)
            {
                return Cuadrante.Tercero;
            }
            else
            {
                return Cuadrante.Cuarto;
            }
        }

        public string GetCoordPolares()
        {
            var r = this.GetDistanciaAlOrigen();
            var phi = Math.Atan(this.CoordY / this.CoordX);
            return $"({r};{phi})";
        }

        public override string ToString()
        {
            return $"({this.CoordX},{this.CoordY})";
        }
    }
}
