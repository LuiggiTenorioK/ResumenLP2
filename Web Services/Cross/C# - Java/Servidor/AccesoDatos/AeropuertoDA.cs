using Modelo;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class AeropuertoDA
    {
        public int registrar(Aeropuerto a)
        {
            try
            {
                //Registrar el Driver
                
                string url = "server=quilla.lab.inf.pucp.edu.pe;" +
                    "user=a20151104;" +
                    "database=a20151104;" +
                    "port=3306;" +
                    "password=8Q8wTa;" +
                    "SslMode=none;";

                MySqlConnection con = new MySqlConnection(url);
                MySqlCommand stm = new MySqlCommand();
                con.Open();
                stm.Connection = con;
                stm.CommandText = "REGISTRAR_AEROPUERTO";
                stm.CommandType = System.Data.CommandType.StoredProcedure;

                stm.Parameters.Add("_CODIGO", MySqlDbType.VarChar).Value = a.Codigo;
                stm.Parameters.Add("_NOMBRE", MySqlDbType.VarChar).Value = a.Nombre;
                stm.Parameters.Add("_UBICACION", MySqlDbType.VarChar).Value = a.Ubicacion;
                stm.Parameters.Add("_MTS_ALTURA", MySqlDbType.Int32).Value = a.Mts_altura;
                stm.Parameters.Add("_ID_AEROPUERTO", MySqlDbType.Int32).Direction = System.Data.ParameterDirection.Output;

                stm.ExecuteNonQuery();
                a.Id = Int32.Parse(stm.Parameters["_ID_AEROPUERTO"].Value.ToString()) ;

                con.Close();
                return a.Id;
            }
            catch (Exception e)
            {
                return 0;
            }
        }
        public void modificar(Aeropuerto a)
        {
            try
            {
                string url = "server=quilla.lab.inf.pucp.edu.pe;" +
                   "user=a20151104;" +
                   "database=a20151104;" +
                   "port=3306;" +
                   "password=8Q8wTa;" +
                   "SslMode=none;";

                MySqlConnection con = new MySqlConnection(url);
                MySqlCommand stm = new MySqlCommand();
                con.Open();
                stm.Connection = con;
                stm.CommandText = "MODIFICAR_AEROPUERTO";
                stm.CommandType = System.Data.CommandType.StoredProcedure;

                //Registrar el Driver
                stm.Parameters.Add("_CODIGO", MySqlDbType.VarChar).Value = a.Codigo;
                stm.Parameters.Add("_NOMBRE", MySqlDbType.VarChar).Value = a.Nombre;
                stm.Parameters.Add("_UBICACION", MySqlDbType.VarChar).Value = a.Ubicacion;
                stm.Parameters.Add("_MTS_ALTURA", MySqlDbType.Int32).Value = a.Mts_altura;
                stm.Parameters.Add("_ID_AEROPUERTO", MySqlDbType.Int32).Value = a.Id;

                stm.ExecuteNonQuery();

                con.Close();
            }
            catch (Exception e)
            {

            }
        }

        public BindingList<Aeropuerto> listar()
        {
            BindingList<Aeropuerto> lista = new BindingList<Aeropuerto>();
            try
            {
                string url = "server=quilla.lab.inf.pucp.edu.pe;" +
                   "user=a20151104;" +
                   "database=a20151104;" +
                   "port=3306;" +
                   "password=8Q8wTa;" +
                   "SslMode=none;";

                MySqlConnection con = new MySqlConnection(url);
                MySqlCommand stm = new MySqlCommand();
                con.Open();
                stm.Connection = con;
                stm.CommandText = "LISTAR_AEROPUERTOS_COMPLETO";
                stm.CommandType = System.Data.CommandType.StoredProcedure;

                MySqlDataReader rs = stm.ExecuteReader();

                while (rs.Read())
                {
                    //agregar elementos a lista
                    Aeropuerto p = new Aeropuerto();

                    p.Id = rs.GetInt32("ID_AEROPUERTO");
                    p.Codigo = rs.GetString("CODIGO");
                    p.Nombre = rs.GetString("NOMBRE");
                    p.Ubicacion = rs.GetString("UBICACION");
                    p.Mts_altura = rs.GetInt32("MTS_ALTURA");

                    lista.Add(p);
                }
                con.Close();
                return lista;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public void eliminar(int id)
        {
            try
            {
                string url = "server=quilla.lab.inf.pucp.edu.pe;" +
                   "user=a20151104;" +
                   "database=a20151104;" +
                   "port=3306;" +
                   "password=8Q8wTa;" +
                   "SslMode=none;";

                MySqlConnection con = new MySqlConnection(url);
                MySqlCommand stm = new MySqlCommand();
                con.Open();
                stm.Connection = con;
                stm.CommandText = "ELIMINAR_AEROPUERTO";
                stm.CommandType = System.Data.CommandType.StoredProcedure;

                //Registrar el Driver

                stm.Parameters.Add("_ID_AEROPUERTO", MySqlDbType.Int32).Value = id;

                stm.ExecuteNonQuery();

                con.Close();
            }
            catch (Exception e)
            {

            }
        }
    }
}
