using Modelo;
using AccesoDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Servicio
{
    /// <summary>
    /// Descripción breve de AeropuertoWS
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class AeropuertoWS : System.Web.Services.WebService
    {
        private AeropuertoDA acceso;
        [WebMethod]
        public string HelloWorld()
        {
            return "Hola a todos";
        }
        /**
         * This is a sample web service operation
         */
        public AeropuertoWS()
        {
            acceso = new AeropuertoDA();
        }

        [WebMethod]
        public int registrar(Aeropuerto a) {
            return acceso.registrar(a);
        }

        [WebMethod]
        public BindingList<Aeropuerto> listar()
        {
            BindingList<Aeropuerto> lista = acceso.listar();
            return lista;
        }
        [WebMethod]
        public void eliminar(int id){
            acceso.eliminar(id);
        }
        [WebMethod]
        public void modificar(Aeropuerto a){
            acceso.modificar(a);
        }

     }
}
