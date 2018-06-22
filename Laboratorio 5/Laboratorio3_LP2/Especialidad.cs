using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio3_LP2
{
    public class Especialidad
    {
        private string _nombre;
        private Clasificacion _clasificacion;

        public Especialidad(string nombre, Clasificacion clasificacion)
        {
            _nombre = nombre;
            _clasificacion = clasificacion;
        }

        public string Nombre { get => _nombre; set => _nombre = value; }
        public Clasificacion Clasificacion { get => _clasificacion; set => _clasificacion = value; }
    }
}
