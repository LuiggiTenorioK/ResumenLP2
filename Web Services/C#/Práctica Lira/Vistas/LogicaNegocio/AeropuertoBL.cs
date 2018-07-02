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
        private AeropuertoWS.AeropuertoWSSoapClient service;
        public AeropuertoBL()
        {
            service = new AeropuertoWS.AeropuertoWSSoapClient();
        }
        public BindingList<Aeropuerto> listar()
        {
            BindingList<Aeropuerto> temp = new BindingList<Aeropuerto>(service.listar());
            BindingList<Aeropuerto> lista = new BindingList<Aeropuerto>();
            foreach(Aeropuerto a in temp)
            {
                Aeropuerto aer = new Aeropuerto();
                aer.Codigo = aer.Codigo;
                aer.Id = a.Id;
                aer.Mts_altura = a.Mts_altura;
                aer.Nombre = a.Nombre;
                aer.Ubicacion = a.Ubicacion;
                lista.Add(a);
            }
            return lista;
        }
        public int registrar(Aeropuerto a)
        {
            return service.registrar(a);
        }
        public void eliminar(int id)
        {
            service.eliminar(id);
        }
        public void modificar(Aeropuerto a)
        {
            service.modificar(a);
        }
    }

}
