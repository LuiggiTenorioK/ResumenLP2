using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio3_LP2
{
    public class Persona
    {
        private int _id;
        private string _nombres;
        private string _apellidoPaterno;
        private char _sexo;
        private int _edad;
        private EstadoCivil _estadoCivil;
        private string _DNI;

        public Persona() { }

        public Persona(int id, string nombres, string apellidoPaterno, char sexo, int edad, EstadoCivil estadoCivil, string DNI)
        {
            _id = id;
            _nombres = nombres;
            _apellidoPaterno = apellidoPaterno;
            _sexo = sexo;
            _edad = edad;
            _estadoCivil = estadoCivil;
            _DNI = DNI;
        }

        public Persona(string nombres, string apellidoPaterno, char sexo, int edad, EstadoCivil estadoCivil, string DNI)
        {
            _nombres = nombres;
            _apellidoPaterno = apellidoPaterno;
            _sexo = sexo;
            _edad = edad;
            _estadoCivil = estadoCivil;
            _DNI = DNI;
        }

        public string Nombres { get => _nombres; set => _nombres = value; }
        public string Apellido_Paterno { get => _apellidoPaterno; set => _apellidoPaterno = value; }
        public string DNI { get => _DNI; set => _DNI = value; }
        public char Sexo { get => _sexo; set => _sexo = value; }
        public int Edad { get => _edad; set => _edad = value; }
        public EstadoCivil EstadoCivil { get => _estadoCivil; set => _estadoCivil = value; }
        public int Id { get => _id; set => _id = value; }
    }
}
