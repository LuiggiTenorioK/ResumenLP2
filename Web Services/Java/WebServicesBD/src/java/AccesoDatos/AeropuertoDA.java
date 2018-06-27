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
import java.sql.PreparedStatement;
import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;

/**
 *
 * @author alirapal
 */
@WebService(serviceName = "AeropuertoDA")
public class AeropuertoDA {
    @WebMethod(operationName = "registrar")
    public void registrar(@WebParam(name = "a") Aeropuerto a){
        try{
            //Registrar el Driver
            Class.forName("com.mysql.jdbc.Driver");
            String url="jdbc:mysql://quilla.lab.inf.pucp.edu.pe/a20151104";
            
            Connection con = DriverManager.getConnection(url,"a20151104","8Q8wTa");
            CallableStatement stm = con.prepareCall("{call REGISTRAR_AEROPUERTO(?,?,?,?)}");
            
            stm.setString(1,a.getCodigo());
            stm.setString(2,a.getNombre());
            stm.setString(3,a.getUbicacion());
            stm.setInt(4,a.getMts_altura());
            stm.execute();
          
            System.out.println("Registro realizado");
            con.close();
        }catch(Exception e){
            System.out.println(e.getMessage());
        }
    }
}
