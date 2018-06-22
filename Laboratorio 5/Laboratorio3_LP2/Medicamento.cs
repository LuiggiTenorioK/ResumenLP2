using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio3_LP2
{
    public class Medicamento
    {
        private int _id_medicamento;
        private string _nombre;
        private string _presentacion;
        private Double _costo_Unidad;
        private string _farmaceutica;
        private Boolean _generico_sn;

        public int Id_medicamento { get => _id_medicamento; set => _id_medicamento = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Presentacion { get => _presentacion; set => _presentacion = value; }
        public double Costo_Unidad { get => _costo_Unidad; set => _costo_Unidad = value; }
        public string Farmaceutica { get => _farmaceutica; set => _farmaceutica = value; }
        public bool Generico_sn { get => _generico_sn; set => _generico_sn = value; }
        public string Generico { get => (Generico_sn ? "SI" : "NO"); set => Generico = value; }
    }
}
