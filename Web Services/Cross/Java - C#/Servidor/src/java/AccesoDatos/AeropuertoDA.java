/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package AccesoDatos;

import Modelo.Aeropuerto;
import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.util.ArrayList;

/**
 *
 * @author Alvaro
 */
public class AeropuertoDA {
    public int registrar(Aeropuerto a){
        try{
            //Registrar el Driver
            Class.forName("com.mysql.jdbc.Driver");
            String url="jdbc:mysql://quilla.lab.inf.pucp.edu.pe/a20151104";
            
            Connection con = DriverManager.getConnection(url,"a20151104","8Q8wTa");
            CallableStatement stm = con.prepareCall("{call REGISTRAR_AEROPUERTO(?,?,?,?,?)}");
            
            stm.setString("_CODIGO",a.getCodigo());
            stm.setString("_NOMBRE",a.getNombre());
            stm.setString("_UBICACION",a.getUbicacion());
            stm.setInt("_MTS_ALTURA",a.getMts_altura());
            stm.registerOutParameter("_ID_AEROPUERTO", java.sql.Types.INTEGER);
            stm.execute();
            a.setId(stm.getInt("_ID_AEROPUERTO"));
            //System.out.println("Registro realizado");
            con.close();
            return a.getId();
        }catch(Exception e){
            //System.out.println(e.getMessage());
            return 0;
        }
    }
    public void modificar(Aeropuerto a){
        try{
            //Registrar el Driver
            Class.forName("com.mysql.jdbc.Driver");
            String url="jdbc:mysql://quilla.lab.inf.pucp.edu.pe/a20151104";
            
            Connection con = DriverManager.getConnection(url,"a20151104","8Q8wTa");
            CallableStatement stm = con.prepareCall("{call MODIFICAR_AEROPUERTO(?,?,?,?,?)}");
            
            stm.setInt("_ID_AEROPUERTO",a.getId());
            stm.setString("_CODIGO",a.getCodigo());
            stm.setString("_NOMBRE",a.getNombre());
            stm.setString("_UBICACION",a.getUbicacion());
            stm.setInt("_MTS_ALTURA",a.getMts_altura());
            stm.execute();
          
            //System.out.println("Registro realizado");
            con.close();
        }catch(Exception e){
            //System.out.println(e.getMessage());
        }
    }    
    public ArrayList<Aeropuerto> listar(){
        ArrayList<Aeropuerto> lista = new ArrayList<Aeropuerto>();
        try{
            Class.forName("com.mysql.jdbc.Driver");
            String url="jdbc:mysql://quilla.lab.inf.pucp.edu.pe/a20151104";
            Connection con = DriverManager.getConnection(url,"a20151104","8Q8wTa");
            CallableStatement stm = con.prepareCall("{call LISTAR_AEROPUERTOS_COMPLETO()}");

            ResultSet rs = stm.executeQuery();
            while(rs.next()){
                //agregar elementos a lista
                Aeropuerto p = new Aeropuerto();
                p.setId(rs.getInt("ID_AEROPUERTO"));
                p.setCodigo(rs.getString("CODIGO"));
                p.setNombre(rs.getString("NOMBRE"));
                p.setUbicacion(rs.getString("UBICACION"));
                p.setMts_altura(rs.getInt("MTS_ALTURA"));
                lista.add(p);
            }
            con.close();
        }catch(Exception ex){
            
        }
        return lista;
    }
    
    public void eliminar(int id){
        try{
            //Registrar el Driver
            Class.forName("com.mysql.jdbc.Driver");
            String url="jdbc:mysql://quilla.lab.inf.pucp.edu.pe/a20151104";
            
            Connection con = DriverManager.getConnection(url,"a20151104","8Q8wTa");
            CallableStatement stm = con.prepareCall("{call ELIMINAR_AEROPUERTO(?)}");
            
            stm.setInt("_ID_AEROPUERTO",id);
            stm.execute();
          
            //System.out.println("Registro realizado");
            con.close();
        }catch(Exception e){
            //System.out.println(e.getMessage());
        }
    }
}