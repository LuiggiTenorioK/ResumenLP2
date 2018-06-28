/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Servicios;

import AccesoDatos.AeropuertoDA;
import Modelo.Aeropuerto;
import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;

/**
 *
 * @author alirapal
 */
@WebService(serviceName = "ClienteWeb")
public class ClienteWeb {

    /**
     * This is a sample web service operation
     */
    private AeropuertoDA acceso;
    
    public ClienteWeb(){
        acceso = new AeropuertoDA();
    }
    
    @WebMethod(operationName = "hello")
    public String hello(@WebParam(name = "txt") String txt) {
        return "Hello " + txt + " !";
    }
    
    @WebMethod(operationName = "registrar")
    public void registrar(@WebParam(name = "a") Aeropuerto a) {
        acceso.registrar(a);
    }
}
