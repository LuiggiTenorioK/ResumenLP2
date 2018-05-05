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
    public class PacienteDA {
        public BindingList<Paciente> listarPacientes() {
            BindingList<Paciente> lista = new BindingList<Paciente>();
            String cadena = "server=quilla.lab.inf.pucp.edu.pe;" + "user=*;database=*;" + "port=3306;password=*;SslMode=none;" + "";
            MySqlConnection con = new MySqlConnection(cadena);
            con.Open();
            MySqlCommand comando = new MySqlCommand();
            comando.CommandText = "LISTAR_PACIENTES";
            comando.Connection = con;
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read()) {
                Paciente p = new Paciente();
                p.DNI = reader.GetString("DNI");
                p.Id = reader.GetInt32("ID_PERSONA");
                p.ApellidoMaterno = reader.GetString("Apellido_Materno");
                p.Apellido_Paterno = reader.GetString("Apellido_Paterno");
                p.Nombres = reader.GetString("NOMBRES");
                lista.Add(p);
            }
            con.Close();
            return lista;
        }
    }
}
