/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package LogicaNegocio;

import java.util.ArrayList;
import org.tempuri.Aeropuerto;
import org.tempuri.AeropuertoWS;
import org.tempuri.AeropuertoWSSoap;

/**
 *
 * @author Alvaro
 */
public class AeropuertoBL {
    private AeropuertoWS service;
    private AeropuertoWSSoap port;
    public AeropuertoBL(){
        service = new AeropuertoWS();
        port = service.getAeropuertoWSSoap();
    }
    public ArrayList<Aeropuerto> listar(){
        ArrayList<Aeropuerto> lista = new ArrayList<Aeropuerto>();
        lista.addAll(port.listar().getAeropuerto());
        return lista;
    }
    public int registrar(Aeropuerto a){
        return port.registrar(a);
    }
    public void eliminar(int id){
        port.eliminar(id);
    }
    public void modificar(Aeropuerto a){
        port.modificar(a);
    }
}
