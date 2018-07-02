/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Servicio;

import AccesoDatos.AeropuertoDA;
import Modelo.Aeropuerto;
import java.util.ArrayList;
import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;

/**
 *
 * @author Alvaro
 */
@WebService(serviceName = "AeropuertoWS")
public class AeropuertoWS {
    private AeropuertoDA acceso;
    /**
     * This is a sample web service operation
     */
    public AeropuertoWS(){
        acceso = new AeropuertoDA();
    }
    @WebMethod(operationName = "hello")
    public String hello(@WebParam(name = "name") String txt) {
        return "Hello " + txt + " !";
    }
    @WebMethod(operationName = "registrar")
    public int registrar(@WebParam(name = "a") Aeropuerto a) {
        return acceso.registrar(a);
    }
    @WebMethod(operationName = "listar")
    public ArrayList<Aeropuerto> listar(){
        ArrayList<Aeropuerto> lista = acceso.listar();
        return lista;
    }
    @WebMethod(operationName = "eliminar")
    public void eliminar(@WebParam(name = "id") int id){
        acceso.eliminar(id);
    }
    @WebMethod(operationName = "modificar")
    public void modificar(@WebParam(name = "a") Aeropuerto a){
        acceso.modificar(a);
    }
}
