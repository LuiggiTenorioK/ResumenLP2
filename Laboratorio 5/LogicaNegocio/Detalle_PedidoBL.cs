using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;

namespace LogicaNegocio {
    public class Detalle_PedidoBL {
        private Detalle_PedidoDA accesoDatos;

        public Detalle_PedidoBL() {
            accesoDatos = new Detalle_PedidoDA();
        }

        public void registrarDetallePedido(int idPedido, int idMedic, int cantidad, double subtot) {
            accesoDatos.registrarDetallePedido(idPedido, idMedic, cantidad, subtot);
        }
    }
}
