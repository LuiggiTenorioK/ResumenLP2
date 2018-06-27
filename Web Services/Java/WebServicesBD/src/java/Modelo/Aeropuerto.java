/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Modelo;

import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;

/**
 *
 * @author alirapal
 */
@WebService(serviceName = "Aeropuerto")
public class Aeropuerto {
    
    private int id;
    private String codigo;
    private String nombre;
    private String ubicacion;
    private int mts_altura;
    
    @WebMethod(operationName = "getId")
    public int getId() {
        return id;
    }
    @WebMethod(operationName = "setId")
    public void setId(@WebParam(name = "id") int id) {
        this.id = id;
    }
    @WebMethod(operationName = "getCodigo")
    public String getCodigo() {
        return codigo;
    }
    @WebMethod(operationName = "setCodigo")
    public void setCodigo(@WebParam(name = "codigo") String codigo) {
        this.codigo = codigo;
    }
    @WebMethod(operationName = "getNombre")
    public String getNombre() {
        return nombre;
    }
    @WebMethod(operationName = "setNombre")
    public void setNombre(@WebParam(name = "nombre") String nombre) {
        this.nombre = nombre;
    }
    @WebMethod(operationName = "getUbicacion")
    public String getUbicacion() {
        return ubicacion;
    }
    @WebMethod(operationName = "setUbicacion")
    public void setUbicacion(@WebParam(name = "ubicacion") String ubicacion) {
        this.ubicacion = ubicacion;
    }
    @WebMethod(operationName = "getMts_altura")
    public int getMts_altura() {
        return mts_altura;
    }
    @WebMethod(operationName = "setMts_altura")
    public void setMts_altura(@WebParam(name = "mts_altura") int mts_altura) {
        this.mts_altura = mts_altura;
    }
    
    public Aeropuerto(@WebParam(name = "Codigo") String Codigo,
            @WebParam(name = "Nombre") String Nombre, 
            @WebParam(name = "Ubicacion") String Ubicacion, 
            @WebParam(name = "Mts_altura") int Mts_altura){
        this.codigo = Codigo;
        this.mts_altura = Mts_altura;
        this.nombre = Nombre;
        this.ubicacion = Ubicacion;
    }
}
