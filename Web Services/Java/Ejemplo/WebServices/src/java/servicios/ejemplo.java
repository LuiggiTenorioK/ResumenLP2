/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package servicios;

import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;

/**
 *
 * @author alirapal
 */
@WebService(serviceName = "ejemplo")
public class ejemplo {

    /**
     * This is a sample web service operation
     */
    @WebMethod(operationName = "sumar")
    public double sumar(@WebParam(name = "a") double a,
        @WebParam(name = "b") double b) {
        return a + b;
    }
    @WebMethod(operationName = "restar")
    public double restar(@WebParam(name = "a") double a,
        @WebParam(name = "b") double b) {
        return a - b;
    }
    @WebMethod(operationName = "multiplicar")
    public double multiplicar(@WebParam(name = "a") double a,
        @WebParam(name = "b") double b) {
        return a * b;
    }
    @WebMethod(operationName = "dividir")
    public double dividir(@WebParam(name = "a") double a,
        @WebParam(name = "b") double b) {
        return a / b;
    }
    @WebMethod(operationName = "saludar")
    public String saludar(@WebParam(name = "nombre") String nombre) {
        return "Hola como estas? " + nombre;
    }
}
