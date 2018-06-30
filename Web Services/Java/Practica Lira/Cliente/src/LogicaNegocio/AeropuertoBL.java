/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package LogicaNegocio;

import java.util.ArrayList;
import servicio.Aeropuerto;

/**
 *
 * @author Alvaro
 */
public class AeropuertoBL {
    private servicio.AeropuertoWS_Service service;
    private servicio.AeropuertoWS port;
    public AeropuertoBL(){
        service = new servicio.AeropuertoWS_Service();
        port = service.getAeropuertoWSPort();
    }
    public ArrayList<Aeropuerto> listar(){
        return (ArrayList<Aeropuerto>) port.listar();
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
