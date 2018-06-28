/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package servicios;

import accesoDatos.ClientesDA;
import java.sql.SQLException;
import java.util.ArrayList;
import javax.jws.*;
import modelo.*;

/**
 *
 * @author Andres
 */
@WebService(serviceName = "ClienteWeb")
public class ClienteWeb {

    /**
     * This is a sample web service operation
     */
    
    private ClientesDA accesoDatos;
    
    public ClienteWeb(){
        
    }
    
    @WebMethod(operationName = "hello")
    public String hello(@WebParam(name = "name") String txt) {
        return "Hello " + txt + " !";
    }
    
    @WebMethod(operationName = "listarClientes")
    public ArrayList<Cliente> listarClientes(){
        accesoDatos = new ClientesDA();
        ArrayList<Cliente> lista = accesoDatos.listarClientes();
        return lista;
    }
    
    @WebMethod(operationName = "registrarCliente")
    public void registrarCliente(@WebParam(name = "p") Cliente p){
        accesoDatos = new ClientesDA();
        accesoDatos.registrarCliente(p);
    }
    
    @WebMethod(operationName = "modificarCliente")
    public void modificarCliente(@WebParam(name = "p") Cliente p){
        accesoDatos = new ClientesDA();
        accesoDatos.modificarCliente(p);
    }
    
    @WebMethod(operationName = "eliminarCliente")
    public void eliminarCliente(@WebParam(name = "id") int id){
        accesoDatos = new ClientesDA();
        accesoDatos.eliminarCliente(id);
    }
}
