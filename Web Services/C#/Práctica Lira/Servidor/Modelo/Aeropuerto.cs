using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Aeropuerto
    {
        private int id;
        private string codigo;
        private string nombre;
        private string ubicacion;
        private int mts_altura;

        public int Id { get => id; set => id = value; }
        public string Codigo { get => codigo; set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Ubicacion { get => ubicacion; set => ubicacion = value; }
        public int Mts_altura { get => mts_altura; set => mts_altura = value; }
        public Aeropuerto(string Codigo, string Nombre, string Ubicacion, int Mts_altura)
        {
            this.codigo = Codigo;
            this.mts_altura = Mts_altura;
            this.nombre = Nombre;
            this.ubicacion = Ubicacion;
        }
        public Aeropuerto()
        {

        }
    }
}
