/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package accesoDatos;

import java.sql.SQLException;
import java.util.ArrayList;
import modelo.Cliente;

/**
 *
 * @author Andres
 */
public class probar {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) throws ClassNotFoundException, SQLException {
        ClientesDA accesoDatos = new ClientesDA();
        ArrayList<Cliente> lista = accesoDatos.listarClientes();
        for (int i=0; i<lista.size(); i++){
            System.out.println(lista.get(i).getId()+" "+lista.get(i).getNombre()+" "+lista.get(i).getApellido());
        }
        
       /* System.out.println();
        
        Cliente c = new Cliente();
        c.setNombre("Hola");
        c.setApellido("Mundo");
        c.setDireccion("io k c");
        
        accesoDatos.registrarCliente(c);
        
        lista = accesoDatos.listarClientes();
        for (int i=0; i<lista.size(); i++){
            System.out.println(lista.get(i).getId()+" "+lista.get(i).getNombre()+" "+lista.get(i).getApellido());
        }
        
        System.out.println();
        
        Cliente c1 = new Cliente();
        c1.setId(lista.get(0).getId());
        c1.setApellido("mayo");
        c1.setNombre(lista.get(0).getNombre());
        c1.setDireccion(lista.get(0).getDireccion());
        
        accesoDatos.modificarCliente(c1);
        
        lista = accesoDatos.listarClientes();
        for (int i=0; i<lista.size(); i++){
            System.out.println(lista.get(i).getId()+" "+lista.get(i).getNombre()+" "+lista.get(i).getApellido());
        }
        */
        System.out.println();
        
        accesoDatos.eliminarCliente(5);
        accesoDatos.eliminarCliente(6);
        
        lista = accesoDatos.listarClientes();
        for (int i=0; i<lista.size(); i++){
            System.out.println(lista.get(i).getId()+" "+lista.get(i).getNombre()+" "+lista.get(i).getApellido());
        }
        
    }
    
}
