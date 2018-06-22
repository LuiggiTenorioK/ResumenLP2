/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

package DataAccess;

/**
 * @author Emilio
 */
public class AD {
    private static final String IP = "";        //ESCRIBIR EL IP DE ACCESO
    private static final String BDNAME = "";    //NOMBRE DE LA BASE DE DATOS
    private static final String USER = "";      //NOMBRE DE USUARIO
    private static final String PSW = "";       //CLAVE DE ACCESO

    /**
     * @return the IP
     */
    public static String getIP() {
        return IP;
    }

    /**
     * @return the BDNAME
     */
    public static String getBDNAME() {
        return BDNAME;
    }

    /**
     * @return the USER
     */
    public static String getUSER() {
        return USER;
    }

    /**
     * @return the PSW
     */
    public static String getPSW() {
        return PSW;
    }
}
