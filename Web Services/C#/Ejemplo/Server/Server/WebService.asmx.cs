using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Server
{
    /// <summary>
    /// Descripción breve de WebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hola a todos";
        }
        [WebMethod] public double sumar(double a, double b) { return a + b; }
        [WebMethod] public double restar(double a, double b) { return a - b; }
        [WebMethod] public double multiplicar(double a, double b) { return a * b; }
        [WebMethod] public double dividir(double a, double b) { return a / b; }
        [WebMethod] public String saludar(String nombre) { return "Hola " + nombre; }

    }
}
