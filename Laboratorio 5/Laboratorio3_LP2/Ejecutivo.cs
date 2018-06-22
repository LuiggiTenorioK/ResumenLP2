using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio3_LP2
{
    public class Ejecutivo : Empleado
    {
        private string _pasaporte;
        private string _SSN;

        public Ejecutivo (string nombres, string apellidoPaterno, char sexo, int edad,
            EstadoCivil estadoCivil, string DNI, double salario, Dedicacion dedicacion,
            string pasaporte, string SSN)
            : base(nombres, apellidoPaterno, sexo, edad,
            estadoCivil, DNI, salario, dedicacion)
        {
            _pasaporte = pasaporte;
            _SSN = SSN;
        }

        public string Pasaporte { get => _pasaporte; set => _pasaporte = value; }
        public string SSN { get => _SSN; set => _SSN = value; }
    }
}
