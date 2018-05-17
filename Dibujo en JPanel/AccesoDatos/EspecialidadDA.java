/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package AccesoDatos;

import Modelo.Especialidad;
import java.sql.*;
import java.util.ArrayList;

/**
 *
 * @author Luiggi Tenorio Ku 20151204
 */
public class EspecialidadDA {
    public ArrayList<Especialidad> getEspecialidad(int id1,int id2){
        ArrayList<Especialidad> lista= new ArrayList<>();
        try {
            String url="jdbc:mysql://quilla.lab.inf.pucp.edu.pe/a20151204";
            
            Connection con = DriverManager.getConnection(url,"a20151204","Uj0HKo");

            CallableStatement stm = con.prepareCall("{call CANT_NOMBRE_MED_ESP(?,?,?,?,?,?)}");
            
            stm.setString("_ID_ESPECIALIDAD1", Integer.toString(id1) );
            stm.setString("_ID_ESPECIALIDAD2", Integer.toString(id2) );
            stm.registerOutParameter("_CANTIDAD_ESP1", java.sql.Types.INTEGER);
            stm.registerOutParameter("_CANTIDAD_ESP2", java.sql.Types.INTEGER);
            stm.registerOutParameter("_NOMBRE_ESP1", java.sql.Types.VARCHAR);
            stm.registerOutParameter("_NOMBRE_ESP2", java.sql.Types.VARCHAR);
            
            stm.execute();
            
            Especialidad e1 =new Especialidad(id1, stm.getString("_NOMBRE_ESP1"), stm.getInt("_CANTIDAD_ESP1"));
            Especialidad e2 =new Especialidad(id2, stm.getString("_NOMBRE_ESP2"), stm.getInt("_CANTIDAD_ESP2"));
            
            lista.add(e1);
            lista.add(e2);
            con.close();
        } catch (SQLException ex) {
            System.out.println(ex);
        }
        return lista;
        
        
    }
}
