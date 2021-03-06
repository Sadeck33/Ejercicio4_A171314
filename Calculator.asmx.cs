using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Calculos
{
    /// <summary>
    /// Descripción breve de Calculator
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class Calculator : System.Web.Services.WebService
    {
        Calcu c = new Calcu();
        [WebMethod]
        public string HelloWorld()
        {
            return "Hola a todos";
        }
        [WebMethod]
        public double Cuadrado(double N01, double N02)
        {
            c.Num01 = N01;
            return c.Cuadrado();
        }
        [WebMethod]
        public double Circulo(double N01)
        {
            return c.Circulo(N01);
        }
        [WebMethod]
        public double Triangulo(double N01, double N02)
        {
            return c.Triangulo(N01, N02);
        }
    }
}
