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
    public class MedicamentoDA {
        public BindingList<Medicamento> listarMedicamentos() {
            BindingList<Medicamento> lista = new BindingList<Medicamento>();

            String cadena = "server=quilla.lab.inf.pucp.edu.pe;" + "user=*;database=*;" + "port=3306;password=*;SslMode=none;" + "";
            MySqlConnection con = new MySqlConnection(cadena);
            con.Open();
            MySqlCommand comando = new MySqlCommand();
            comando.CommandText = "LISTAR_MEDICAMENTOS";
            comando.Connection = con;
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read()) {
                Medicamento m = new Medicamento();
                m.Id_medicamento = reader.GetInt32("ID_MEDICAMENTO");
                m.Nombre = reader.GetString("NOMBRE");
                m.Presentacion = reader.GetString("PRESENTACION");
                m.Costo_Unidad = reader.GetDouble("COSTO_UNIDAD");
                m.Farmaceutica = reader.GetString("FARMACEUTICA");
                m.Generico_sn = reader.GetBoolean("GENERICO_SN");
               // m.Generico = (m.Generico_sn ? "SI" : "NO");
                lista.Add(m);
            }
            con.Close();
            return lista;
        }
    }
}
