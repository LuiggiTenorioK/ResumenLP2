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

namespace AccesoDatos
{
    public class PedidoDA
    {
        public int registrarPedido(int idPaciente, double total) {
            String cadena = "server=quilla.lab.inf.pucp.edu.pe;" + "user=*;database=*;" + "port=3306;password=*;SslMode=none;" + "";
            MySqlConnection con = new MySqlConnection(cadena);
            con.Open();
            MySqlCommand comando = new MySqlCommand();
            comando.CommandText = "REGISTRAR_PEDIDO";
            comando.Connection = con;
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("_FID_PACIENTE", MySqlDbType.Int32).Value = idPaciente;
            comando.Parameters.Add("_TOTAL", MySqlDbType.Double).Value = total;
            comando.Parameters.Add("_ID", MySqlDbType.Int32).Direction
                = System.Data.ParameterDirection.Output;
            comando.ExecuteNonQuery();
            int idPedido = Int32.Parse(comando.Parameters["_ID"].Value.ToString());
            con.Close();
            return idPedido;
        }
    }
}
