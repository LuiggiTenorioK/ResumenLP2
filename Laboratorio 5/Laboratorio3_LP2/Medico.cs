using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio3_LP2
{
    public class Medico : EmpleadoNac
    {
        private Especialidad _especialidad;
        private string _colegiatura;
        public Medico(string nombres, string apellidoPaterno, string apellidoMaterno, char sexo, int edad,
            EstadoCivil estadoCivil, string DNI, double salario, Dedicacion dedicacion, string colegiatura, Especialidad especialidad) :
            base (nombres, apellidoPaterno, apellidoMaterno, sexo, edad,
            estadoCivil, DNI, salario, dedicacion)
        {
            _especialidad = especialidad;
            _colegiatura = colegiatura;
        }

        public Especialidad Especialidad { get => _especialidad; set => _especialidad = value; }
        public string Colegiatura { get => _colegiatura; set => _colegiatura = value; }

        public override string consultarDatos()
        {
            return Nombres + " " + Apellido_Paterno + " " +
                Apellido_Paterno + " - " + Especialidad.Nombre + 
                "\n";
        }

    }
}
