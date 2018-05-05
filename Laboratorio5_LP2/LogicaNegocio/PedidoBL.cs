using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;

namespace LogicaNegocio
{
    public class PedidoBL
    {
        private PedidoDA accesoDatos;

        public PedidoBL() {
            accesoDatos = new PedidoDA();
        }

        public int registrarPedido(int idPaciente, double total) {
            return accesoDatos.registrarPedido(idPaciente, total);
        }
    }
}
