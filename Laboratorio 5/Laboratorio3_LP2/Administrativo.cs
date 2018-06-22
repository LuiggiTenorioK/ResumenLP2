using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio3_LP2
{
    public class Administrativo : EmpleadoNac
    {
        private RegimenLaboral _regimenLaboral;
        private string _funcion;

        public Administrativo(string nombres, string apellidoPaterno, string apellidoMaterno, char sexo, int edad,
            EstadoCivil estadoCivil, string DNI, double salario, Dedicacion dedicacion, RegimenLaboral regimenLaboral, string _funcion) :
            base (nombres, apellidoPaterno, apellidoMaterno, sexo, edad,
            estadoCivil, DNI, salario, dedicacion)
        {
            _regimenLaboral = RegimenLaboral;
            _funcion = Funcion;
        }

        public RegimenLaboral RegimenLaboral { get => _regimenLaboral; set => _regimenLaboral = value; }
        public string Funcion { get => _funcion; set => _funcion = value; }

        public override string consultarDatos()
        {
            return Nombres + " " + Apellido_Paterno + " " +
                Apellido_Paterno + " - " + Dedicacion + " - "+
                RegimenLaboral + "\n";
        }
    }
}
