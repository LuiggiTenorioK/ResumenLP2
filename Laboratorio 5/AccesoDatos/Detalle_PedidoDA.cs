using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Laboratorio3_LP2;
using MySql.Data.MySqlClient;

namespace AccesoDatos {
    public class Detalle_PedidoDA {
        public void registrarDetallePedido(int idPedido, int idMedic, int cant, double subtot) {
            String cadena = "server=quilla.lab.inf.pucp.edu.pe;" + "user=*;database=*;" + "port=3306;password=*;SslMode=none;" + "";
            MySqlConnection con = new MySqlConnection(cadena);
            con.Open();
            MySqlCommand comando = new MySqlCommand();
            comando.CommandText = "REGISTRAR_DETALLE_PEDIDO";
            comando.Connection = con;
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("_FID_PEDIDO", MySqlDbType.Int32).Value = idPedido;
            comando.Parameters.Add("_FID_MEDICAMENTO", MySqlDbType.Int32).Value = idMedic;
            comando.Parameters.Add("_CANTIDAD", MySqlDbType.Int32).Value = cant;
            comando.Parameters.Add("_SUBTOTAL", MySqlDbType.Double).Value = subtot;
            comando.ExecuteNonQuery();
        }
    }
}
