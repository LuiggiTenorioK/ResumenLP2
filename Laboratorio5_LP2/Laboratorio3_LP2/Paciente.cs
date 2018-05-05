using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio3_LP2
{
    public class Paciente : Persona
    {
        private String _apellidoMaterno;

        public Paciente() : base() { }

        public Paciente(int id, string DNI, string nombres, string apellidoPaterno, string apellidoMaterno, char sexo, int edad, EstadoCivil estadoCivil)
            : base(id, nombres, apellidoPaterno, sexo, edad, estadoCivil, DNI)
        {
            _apellidoMaterno = apellidoMaterno;
        }

        public string ApellidoMaterno { get => _apellidoMaterno; set => _apellidoMaterno = value; }
    }
}
