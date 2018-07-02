using LogicaNegocio.AeropuertoWS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class AeropuertoBL
    {
        private AeropuertoWS.AeropuertoWSClient service;
        public AeropuertoBL()
        {
            service = new AeropuertoWS.AeropuertoWSClient();
        }
        public BindingList<aeropuerto> listar()
        {
            BindingList<aeropuerto> temp = new BindingList<aeropuerto>(service.listar());
            BindingList<aeropuerto> lista = new BindingList<aeropuerto>();
            foreach(aeropuerto a in temp)
            {
                aeropuerto aer = new aeropuerto();
                aer.codigo = a.codigo;
                aer.id = a.id;
                aer.mts_altura = a.mts_altura;
                aer.nombre = a.nombre;
                aer.ubicacion = a.ubicacion;
                lista.Add(a);
            }
            return lista;
        }
        public int registrar(aeropuerto a)
        {
            return service.registrar(a);
        }
        public void eliminar(int id)
        {
            service.eliminar(id);
        }
        public void modificar(aeropuerto a)
        {
            service.modificar(a);
        }
    }

}
