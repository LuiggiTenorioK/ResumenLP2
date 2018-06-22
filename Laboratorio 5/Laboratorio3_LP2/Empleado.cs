using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio3_LP2
{
    public class Empleado : Persona
    {
        private static int generadorId = 1;
        private int _id;
        private double _salario;
        private Dedicacion _dedicacion;

        public Empleado(string nombres, string apellidoPaterno, char sexo, int edad, 
            EstadoCivil estadoCivil, string DNI, double salario, Dedicacion dedicacion)
            : base(nombres, apellidoPaterno, sexo, edad, estadoCivil, DNI)
        {
            _id = generadorId;
            _salario = salario;
            _dedicacion = dedicacion;
            generadorId++;
        }

        public int Id { get => _id; set => _id = value; }
        public double Salario { get => _salario; set => _salario = value; }
        public Dedicacion Dedicacion { get => _dedicacion; set => _dedicacion = value; }
        
    }
}
