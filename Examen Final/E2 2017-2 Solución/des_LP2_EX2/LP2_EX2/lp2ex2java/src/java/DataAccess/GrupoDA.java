/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package DataAccess;
import Model.Partido;
import java.sql.*;
import java.util.ArrayList;

/**
 *
 * @author alulab14
 */
public class GrupoDA {
    public ArrayList<String> ldGrupos() {//throws ClassNotFoundException, SQLException{
        ArrayList<String> temp = new ArrayList<String>();
        try{
            Class.forName("com.mysql.jdbc.Driver");
            Connection com = DriverManager.getConnection("jdbc:mysql://" + AD.getIP() + "/" + AD.getBDNAME(),AD.getUSER(),AD.getPSW());

            CallableStatement stt = com.prepareCall("{CALL GRUPOS()}");
            ResultSet rs = stt.executeQuery();

            while(rs.next()){
                temp.add("GRUPO " + rs.getString("GRUPO"));
            }

            com.close();
        }catch(Exception e){
            System.out.println(e.getMessage());
        }
        return temp;
    }
    
    public ArrayList<Partido> ldPartidosG(ArrayList<Integer> pars){
        ArrayList<Partido> temp = new ArrayList<Partido>();
        try{
            Class.forName("com.mysql.jdbc.Driver");
            Connection com = DriverManager.getConnection("jdbc:mysql://" + AD.getIP() + "/" + AD.getBDNAME(),AD.getUSER(),AD.getPSW());

            CallableStatement stt = com.prepareCall("{CALL GET_PARTIDOS(?,?)}");
            
            for(int i=0; i < pars.size()-1; i+=2){
                stt.setInt("_A", pars.get(i));
                stt.setInt("_B", pars.get(i+1));

                ResultSet rs = stt.executeQuery();
                rs.next();

                Partido t = new Partido();
                t.setEqA(rs.getInt("EQUIPO_A"));
                t.setEqB(rs.getInt("EQUIPO_B"));
                t.setgEqA(rs.getInt("GOLES_EQUIPO_A"));
                t.setgEqB(rs.getInt("GOLES_EQUIPO_B"));
                t.setJugado(rs.getBoolean("JUGADO"));
                temp.add(t);
            }

            com.close();
        }catch(Exception e){
            System.out.println(e.getMessage());
        }
        return temp;
    }
    
    public void updtPartido(int A, int B, int gA, int gB, boolean j){
        try{
            Class.forName("com.mysql.jdbc.Driver");
            Connection com = DriverManager.getConnection("jdbc:mysql://" + AD.getIP() + "/" + AD.getBDNAME(),AD.getUSER(),AD.getPSW());

            CallableStatement stt = com.prepareCall("{CALL SET_PARTIDO(?,?,?,?,?)}");
            
            stt.setInt("_A", A);
            stt.setInt("_B", B);
            if(j){
                stt.setInt("_GA", gA);
                stt.setInt("_GB", gB);
                stt.setBoolean("J", true);
            }else{
                stt.setNull("_GA", Types.INTEGER);
                stt.setNull("_GB", Types.INTEGER);
                stt.setBoolean("J", false);
            }
            stt.execute();

            com.close();
        }catch(Exception e){
            System.out.println(e.getMessage());
        }
    }
}
