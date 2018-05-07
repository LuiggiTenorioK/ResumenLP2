/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package lab6_aduana;
import java.awt.Color;
import java.awt.Font;
import java.awt.Graphics;
import java.awt.Rectangle;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.JButton;
import java.util.*;
/**
 *
 * @author arian
 */
public class Aduana extends JPanel{
    
    private static Aduana aduana;
    private static int noRev, siRev;
    private static int prevRev = -1;
    
    public Aduana(){
        this.setFocusable(true);   
    }
    
    public void paint(Graphics g){
        super.paint(g);
        g.setFont(new Font("default", Font.BOLD, 12));
        g.setColor(Color.GRAY); g.drawLine(350, 0, 350, 700);
        g.setColor(Color.BLACK); g.drawRect(20, 60, 300, 300);
        g.drawString("Sorteos Realizados: " + (noRev + siRev), 20, 380);
        if(prevRev >= 0){
            if(prevRev == 0) g.setColor(Color.red);
            else g.setColor(Color.green);
            g.fillOval(20, 60, 300, 300);
        }
        
        g.setColor(Color.black);
        g.drawString("Total de personas a las que no se ha revisado: " + noRev, 400,20);
        g.drawString("Total de personas a las que se ha revisado: " + siRev, 400, 40);
        
        g.drawLine(400, 100, 1200, 100);
        g.drawLine(400, 600, 1200, 600);
        g.drawLine(420, 80, 420, 620);
        g.drawLine(1180, 80, 1180, 620);
        
        if(noRev + siRev > 0){
            double unitHeight = 500.0 / (noRev + siRev);
            int yN = (int)(600.0 - (double)noRev * unitHeight);
            int yS = (int)(600.0 - (double)siRev * unitHeight);
            
            g.setColor(Color.red); g.fillRect(585, yN, 50, 600 - yN);
            g.setColor(Color.green); g.fillRect(965, yS, 50, 600 - yS);
        }
        //Labels inferiores
        g.setColor(Color.BLACK);
        g.drawString("Revisados", 583, 620);
        g.drawString("No revisados", 960, 620);
        
        //Numeros superiores
        g.setColor(Color.red); g.drawString("" + noRev, 608, 80);
        g.setColor(Color.green); g.drawString("" + siRev, 987, 80);
    }
    
    private static JButton generador;
    
    private static void initMarco(JFrame marco){
        marco.setTitle("Sistema Aduana Peruana");
        marco.setSize(1300,700);
        
        //Panel aduana
        aduana = new Aduana();
        aduana.setLayout(null);
        marco.add(aduana);
        
        //Boton generar
        generador = new JButton("Sortear");
        generador.setBounds(20,10,300,30);
        generador.addActionListener(new ActionListener()
        {
          public void actionPerformed(ActionEvent e)
          {
            Random r = new Random();
            double rnd = r.nextFloat();
            if(rnd < 0.3){
                siRev++;
                prevRev = 1;
            }
            else{
                noRev ++;
                prevRev = 0;
            }
          }
        });
        
        aduana.add(generador);
        marco.add(aduana);
        
        marco.setVisible(true);
        marco.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        System.out.println("OK");
    }
    
    public static void main(String[] args) throws Exception{
        JFrame marco = new JFrame();
        initMarco(marco);
        while(true){
            aduana.repaint();
            Thread.sleep(1);
        }
    }
}
