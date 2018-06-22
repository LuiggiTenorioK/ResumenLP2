/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package DataAccess;
import Model.Pais;
import java.sql.*;
import java.util.ArrayList;

/**
 *
 * @author alulab14
 */
public class PaisDA {
    public ArrayList<Pais> ldPaises(char grp){
        ArrayList<Pais> temp = new ArrayList<Pais>();
        try{
            Class.forName("com.mysql.jdbc.Driver");
            Connection com = DriverManager.getConnection("jdbc:mysql://" + AD.getIP() + "/" + AD.getBDNAME(),AD.getUSER(),AD.getPSW());

            CallableStatement stt = com.prepareCall("{CALL GET_GRUPO(?)}");
            stt.setString("_G", String.valueOf(grp));
            ResultSet rs = stt.executeQuery();

            while(rs.next()){
                Pais t = new Pais();
                t.setId(rs.getInt("ID_PAIS_CLASIFICADO"));
                t.setNombre(rs.getString("NOMBRE"));
                t.setCat(rs.getInt("CATEGORIA_SORTEO"));
                t.setGrp(rs.getString("GRUPO").charAt(0));
                temp.add(t);
            }
            
            com.close();
        }catch(Exception e){
            System.out.println(e.getMessage());
        }
        return temp;
    }
}
