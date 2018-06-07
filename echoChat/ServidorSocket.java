package echoChat;

import java.io.BufferedInputStream;
import java.io.BufferedReader;
import java.io.DataInputStream;
import java.io.InputStream;
import java.io.InputStreamReader;
import java.io.OutputStream;
import java.io.PrintWriter;
import java.net.ServerSocket;
import java.net.Socket;

public class ServidorSocket implements Runnable{
    
    private static Socket so;
    public static void main(String[] args) {
        try{
                so = new Socket();
                ServerSocket ss = new ServerSocket(7);
                System.out.println("En espera de conexion...");
                so = ss.accept();
                
                PrintWriter out =new PrintWriter(so.getOutputStream(), true);
                
                Thread lector = new Thread(new ServidorSocket(),"Lectora");  
                lector.start();
                
                while(true){                               
                        //BufferedReader in = new BufferedReader(new InputStreamReader(so.getInputStream()));
                        
                        //System.out.println("Cliente: "+in.readLine());
                        
                        BufferedReader entrada = new BufferedReader(new InputStreamReader(System.in));
                        System.out.print("Servidor: ");
                        String mensaje = entrada.readLine();
                        out.println(mensaje);
                        out.flush();
                        
                }
        }catch(Exception ex){
                System.out.println(ex.getMessage());
        }
    }
    
    
    public void run(){
        try{
            BufferedReader input = new BufferedReader(new InputStreamReader(so.getInputStream()));
            while(true) System.out.println("Cliente: "+input.readLine()); 
                   
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
    }
}