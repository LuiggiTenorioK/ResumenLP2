/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package accesoDatos;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;
import modelo.Cliente;

/**
 *
 * @author Andres
 */
public class ClientesDA {
    
    public ArrayList<Cliente> listarClientes(){
        ArrayList<Cliente> lista = new ArrayList<Cliente>();
        try{
            Class.forName("com.mysql.jdbc.Driver");
            Connection con = DriverManager.getConnection("jdbc:mysql://quilla.lab.inf.pucp.edu.pe/a20152131?useSSL=false","a20152131","bica");
            String sql = "{call LISTAR_CLIENTES()}";
            CallableStatement stmt = con.prepareCall(sql);

            ResultSet rs = stmt.executeQuery();
            while(rs.next()){
                //agregar elementos a lista
                Cliente p = new Cliente();

                p.setNombre(rs.getString("Nombre"));
                p.setApellido(rs.getString("Apellido"));
                p.setId(rs.getInt("idCliente"));
                p.setDireccion(rs.getString("Direccion"));

                lista.add(p);
            }
            con.close();
        }catch(Exception ex){
            
        }
        return lista;
    }
    
    public void registrarCliente(Cliente p){
        try{
            Class.forName("com.mysql.jdbc.Driver");
            Connection con = DriverManager.getConnection("jdbc:mysql://quilla.lab.inf.pucp.edu.pe/a20152131?useSSL=false","a20152131","bica");
            String sql = "{call REGISTRAR_CLIENTE(?,?,?,?)}";
            CallableStatement stmt = con.prepareCall(sql);

            stmt.setString("_Nombre", p.getNombre());
            stmt.setString("_Apellido", p.getApellido());
            stmt.setString("_Direccion", p.getDireccion());

            stmt.registerOutParameter("_id", java.sql.Types.INTEGER);

            stmt.executeUpdate();

            p.setId(stmt.getInt("_id"));
            con.close();
        }catch(Exception ex){
            
        }
    }
    
    public void modificarCliente(Cliente p){
        try{
            Class.forName("com.mysql.jdbc.Driver");
            Connection con = DriverManager.getConnection("jdbc:mysql://quilla.lab.inf.pucp.edu.pe/a20152131?useSSL=false","a20152131","bica");
            String sql = "{call MODIFICAR_CLIENTE(?,?,?,?)}";
            CallableStatement stmt = con.prepareCall(sql);

            stmt.setString("_Nombre", p.getNombre());
            stmt.setString("_Apellido", p.getApellido());
            stmt.setString("_Direccion", p.getDireccion());
            stmt.setInt("_id", p.getId());

            stmt.executeUpdate();

            con.close();
        }catch(Exception ex){
            
        }
    }
    
    public void eliminarCliente(int id){
        try{
            Class.forName("com.mysql.jdbc.Driver");
            Connection con = DriverManager.getConnection("jdbc:mysql://quilla.lab.inf.pucp.edu.pe/a20152131?useSSL=false","a20152131","bica");
            String sql = "{call ELIMINAR_CLIENTE(?)}";
            CallableStatement stmt = con.prepareCall(sql);

            stmt.setInt("_id", id);

            stmt.executeUpdate();

            con.close();
        }catch(Exception ex){
            
        }
    }
}
