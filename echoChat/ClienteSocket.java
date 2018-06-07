package echoChat;

//import echo.*;
import java.io.BufferedReader;
import java.io.DataInputStream;
import java.io.DataOutputStream;
import java.io.InputStreamReader;
import java.io.PrintWriter;
import java.net.Socket;

public class ClienteSocket implements Runnable {
    
    private static Socket so;
    
    public static void main(String[] args) {
        
        
        try{ 
            so = new Socket("10.101.9.41",7);

            //DataOutputStream salida = new DataOutputStream (so.getOutputStream());
            PrintWriter salida = new PrintWriter(so.getOutputStream(), true);
            //DataInputStream input = new DataInputStream(so.getInputStream());
            
            
            Thread lector = new Thread(new ClienteSocket(),"Lector");  
            lector.start();
            
            
            while(true){       
                BufferedReader entrada = new BufferedReader(new InputStreamReader(System.in));
                System.out.print("Cliente: ");
                String mensaje = entrada.readLine();

                //salida.writeUTF(mensaje);	
                salida.println(mensaje);
                salida.flush(); 
                
                
                
                //System.out.println(input.readUTF()); 
                 
            }         
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
    }
    
    
    public void run(){
        try{
            BufferedReader input = new BufferedReader(new InputStreamReader(so.getInputStream()));
            while(true) System.out.println("Servidor: "+input.readLine()); 
                   
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
    }
}