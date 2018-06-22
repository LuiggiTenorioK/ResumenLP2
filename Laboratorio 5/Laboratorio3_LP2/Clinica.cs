using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio3_LP2
{
    public class Clinica
    {
        private string _nombre;
        private string _direccion;
        private Ciudad _ciudad;
        private BindingList<Empleado> _empleados;
        
        public Clinica()
        {
            _empleados = new BindingList<Empleado>();
        }

        public Clinica(string nombre, string direccion,
            Ciudad ciudad)
        {
            _nombre = nombre;
            _direccion = direccion;
            _ciudad = ciudad;
            _empleados = new BindingList<Empleado>();
        }

        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Direccion { get => _direccion; set => _direccion = value; }
        public Ciudad Ciudad { get => _ciudad; set => _ciudad = value; }
        public BindingList<Empleado> Empleados { get => _empleados; set => _empleados = value; }

        public void agregarEmpleado(Empleado e)
        {
            Empleados.Add(e);
        }

        public string mostrarMedyAdmin()
        {
            string cadena = "";
            foreach(Empleado e in Empleados)
            {
                if(e is EmpleadoNac) //Solamente Medicos y Administrativos
                    cadena = cadena + ((EmpleadoNac)e).consultarDatos();
            }
            return cadena;
        }
    }
}
