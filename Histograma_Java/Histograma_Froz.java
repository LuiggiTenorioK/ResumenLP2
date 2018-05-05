/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/*
 * javac Histograma_Froz.java
 * java Histograma_Froz < datos.txt
*/

//package estrategiasDibujo;
import java.awt.Graphics;
import java.awt.Graphics2D;
import java.awt.Rectangle;
import javax.swing.JFrame;
import javax.swing.JPanel;
import java.util.*;
import java.awt.RenderingHints;
/**
 *
 * @author Arian Gabriel Gallardo Callalli 20153227
 */
public class prueba extends JPanel{
    
    private static ArrayList<Integer> listaDatos;
    private Integer total;
    private int height, width;
    
    public prueba(){
        listaDatos = new ArrayList<Integer>();
        Scanner in = new Scanner(System.in); //Lectura de datos, solo leo numeros y los agrego a una lista
        int n = in.nextInt(); // Podrian insertar datos random o como quieran, pero la estructura es algo asi
        for(int i = 0; i < n; i ++){
            int x = in.nextInt();
            listaDatos.add(x);
        }
        total = new Integer(0);
        for(Integer x : listaDatos){
            total += x;
        }
        height = 10000/total; 
        width = 20;
        this.setFocusable(true);
    }
    
    public void paint(Graphics g){
        super.paint(g);
        int p = 0;
        for(Integer x : listaDatos){
            g.fillRect(2*p*width, 400-height*x, width, height*x);
            if(g instanceof Graphics2D){
                Graphics2D g2 = (Graphics2D)g;
                g2.setRenderingHint(RenderingHints.KEY_ANTIALIASING,
        RenderingHints.VALUE_ANTIALIAS_ON);

                g2.drawString(x.toString(),2*p*width + 5,410);
            }
           // System.out.println(400-height*x + " "+ (1 + 2*p*width) + " " +  width + " " +  height*x);
            p++;
        }
    }
    
    public static void main(String[] args) throws Exception{
        JFrame marco = new JFrame();
        prueba p = new prueba();
        marco.add(p);
        marco.setVisible(true);
        marco.setSize(500,500);
    }
}
