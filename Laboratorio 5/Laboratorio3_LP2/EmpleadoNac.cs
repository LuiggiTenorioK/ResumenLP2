using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio3_LP2
{
    public class EmpleadoNac : Empleado, IConsultable
    {
        private string _apellidoMaterno;

        public EmpleadoNac(string nombres, string apellidoPaterno, string apellidoMaterno, char sexo, int edad,
            EstadoCivil estadoCivil, string DNI, double salario, Dedicacion dedicacion) :
            base (nombres, apellidoPaterno, sexo, edad,
            estadoCivil, DNI, salario, dedicacion)
        {
            _apellidoMaterno = apellidoMaterno;
        }

        public string Apellido_Materno { get => _apellidoMaterno; set => _apellidoMaterno = value; }

        public virtual string consultarDatos()
        {
            return "";
        }
    }
}
