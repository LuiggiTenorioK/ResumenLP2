/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package practica2;

import java.util.ArrayList;
import java.util.List;

/**
 *
 * @author Andres
 */
public class ClienteBL {

    
    private ClienteWeb ws;
    private ClienteWeb_Service servicio;
    public ClienteBL(){
        //ws = new ClienteWeb();
        servicio = new ClienteWeb_Service();
        ws = servicio.getClienteWebPort();
    }
    
    public ArrayList<Cliente> listarClientes(){
        ArrayList<Cliente> lista = new ArrayList<Cliente>();
        List<Cliente> lista1 = ws.listarClientes();
        for(int i=0; i<lista1.size(); i++){
            lista.add(lista1.get(i));
        }
        return lista;
    }
    
    public void registrarCliente(Cliente c){
        ws.registrarCliente(c);
    }
    
    public void modificarCliente(Cliente c){
        ws.modificarCliente(c);
    }
    
    public void eliminarCliente(int id){
        ws.eliminarCliente(id);
    }
    
    public String saludar(){
        return ws.hello("Andres");
    }   
}
