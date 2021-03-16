using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Calculos
{
    public class Calcu
    {
        public double Num01 { get; set; }
        public double Num02 { get; set; }
        public double Cuadrado()
        {
            return Num01 * Num01;
        }
        public double Circulo(double N01)
        {
            return (3.1416 * N01 * N01);
        }
        public double Triangulo(double N01, double N02)
        {
            Num01 = N01;
            Num02 = N02;
            var Resul = ((N01 * N02) / 2);
            return Resul;
        }
    }
}