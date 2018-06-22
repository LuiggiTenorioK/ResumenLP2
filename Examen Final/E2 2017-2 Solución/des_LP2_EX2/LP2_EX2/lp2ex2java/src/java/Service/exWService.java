/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Service;

import java.util.ArrayList;
import javax.jws.*;
import DataAccess.GrupoDA;
import DataAccess.PaisDA;
import Model.*;

/**
 *
 * @author alulab14
 */
@WebService(serviceName = "exWService")
public class exWService {
    private static GrupoDA gDA = new GrupoDA();
    private static PaisDA pDA = new PaisDA();
    
    /**
     * This is a sample web service operation
     */
    @WebMethod(operationName = "hello")
    public String hello(@WebParam(name = "name") String txt) {
        return "Hello " + txt + " !";
    }
    
    @WebMethod(operationName = "getGrupos")
    public ArrayList<String> wldGrps(){
        return gDA.ldGrupos();
    }
    
    @WebMethod(operationName = "getPaises")
    public ArrayList<Pais> wldPss(@WebParam(name = "grupo") String grp){
        return pDA.ldPaises(grp.charAt(grp.length()-1));
    }
    
    @WebMethod(operationName = "getPartidos")
    public ArrayList<Partido> wldPrtds(@WebParam(name = "pares") ArrayList<Integer> prs){
        return gDA.ldPartidosG(prs);
    }
    
    @WebMethod(operationName = "updtPartido")
    public void wupdtPrtds(@WebParam(name = "a") int A,
                                        @WebParam(name = "b") int B,
                                        @WebParam(name = "ga") int gA,
                                        @WebParam(name = "gb") int gB,
                                        @WebParam(name = "jug") boolean j){
        gDA.updtPartido(A, B, gA, gB, j);
    }
}
