using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            servicioServer.WebServiceSoapClient acceso = new servicioServer.WebServiceSoapClient();
            double suma = acceso.sumar(2.0, 3.0);
            double resta = acceso.restar(2.5, 2.0);
            double multiplicacion = acceso.multiplicar(2.0, 5.0);
            double division = acceso.dividir(10.0, 2.0);
            String saludo = acceso.saludar("Alvaro");
            System.Console.WriteLine(suma);
            System.Console.WriteLine(resta);
            System.Console.WriteLine(multiplicacion);
            System.Console.WriteLine(division);
            System.Console.WriteLine(saludo);
            System.Console.Read();
        }
    }
}
