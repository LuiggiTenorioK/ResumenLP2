using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio3_LP2
{
    public class Pedido
    {
        private int _id_pedido;
        private Paciente paciente;
        private DateTime _fecha_Hora;
        private Double _total;
        private BindingList<Detalle_Pedido> _detalles_pedido;

        public int Id_pedido { get => _id_pedido; set => _id_pedido = value; }
        public Paciente Paciente { get => paciente; set => paciente = value; }
        public DateTime Fecha_Hora { get => _fecha_Hora; set => _fecha_Hora = value; }
        public double Total { get => _total; set => _total = value; }
        public BindingList<Detalle_Pedido> Detalles_pedido { get => _detalles_pedido; set => _detalles_pedido = value; }

        public Pedido() {
            Detalles_pedido = new BindingList<Detalle_Pedido>();
        }
    }
}
