/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package histograma;

/**
 *
 * @author Gora-User
 */

import java.awt.Color;
import java.awt.Graphics;
import java.awt.Rectangle;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.util.ArrayList;
import java.util.Random;
import javax.swing.JButton;
import javax.swing.JLabel;
import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.JTextField;
import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.Statement;

public class Histograma extends JPanel{

    int x=50;
    int suma = 0;
    int ancho = 0;
    int max =0;
    ArrayList<Integer> xL = new ArrayList<Integer>();
    ArrayList<String> sL = new ArrayList<String>();
    //xL.add(100);
    
    public void llenarLista(ArrayList<Integer> L, ArrayList<String> L1){
        xL = L;
        sL = L1;
    }
    
    public void paint(Graphics g){
        super.paint(g);
        int n = xL.size();
        if(n == 0){
            
        }
        
        //g.fillRect(0, 100, 10, 100);
        for(int i=0; i<n; i++){
            if(xL.get(i)>max)
                max = xL.get(i);
            suma += xL.get(i);
        }
        
        g.drawString("Cantidad de productos comprada por Paciente en cada Pedido", 20, 30);
        //g.fillRect(15, 100, 10, 100);
        //(300/suma)*(suma/xL.get(i))
        if (n != 0)
            ancho = 3*450/4/n;
        if(ancho > 20) ancho = 20;
        
        for(int i=0; i<n; i++){
            escogerColor(g, i);
            g.fillRect(x, 300-200*(xL.get(i))/max, ancho, 200*(xL.get(i))/max);
            g.setColor(Color.BLACK);
            g.drawString(sL.get(i), x-ancho/2, 320);
            g.drawString(xL.get(i).toString(), x, 80);
            x += 450/n;
        }
        x = 50;
        max =0;
        suma =0;
        //g.fillRect(30, 100, 10, 100);
    }
    
    public void escogerColor(Graphics g, int n){
        switch(n % 10){
            case 1:
                g.setColor(Color.red);
                break;
            case 2:
                g.setColor(Color.orange);
                break;
            case 3:
                g.setColor(Color.yellow);
                break;
            case 4:
                g.setColor(Color.green);
                break;
            case 5:
                g.setColor(Color.gray);
                break;
            case 6:
                g.setColor(Color.blue);
                break;
            case 7:
                g.setColor(Color.pink);
                break;
            case 8:
                g.setColor(Color.WHITE);
                break;
            case 9:
                g.setColor(Color.cyan);
                break;
            case 0:
                g.setColor(Color.black);
                break;
        }
    }
    
    public Histograma(){
        setFocusable(true);
    }
    
    public static void main(String[] args) throws Exception {
        // TODO code application logic here
        JFrame marco = new JFrame();
        Histograma h = new Histograma();
        h.setLayout(null);
        ArrayList<Integer> cantidades = new ArrayList<Integer>();
        ArrayList<String> nombres = new ArrayList<String>();
        Class.forName("com.mysql.jdbc.Driver");
        Connection con = DriverManager.getConnection("jdbc:mysql://quilla.lab.inf.pucp.edu.pe/a20153018?useSSL=false","a20153018","STOP");
        Statement sentencia = con.createStatement();
        String sql = "SELECT B.NOMBRE, SUM(C.CANTIDAD) CANTIDAD_PRODUCTOS FROM PEDIDO_FARMACIA A INNER JOIN (SELECT A.ID_PERSONA, CONCAT(A.NOMBRES, \" \", A.APELLIDO_PATERNO, \" \", B.APELLIDO_MATERNO) NOMBRE FROM PERSONA A LEFT JOIN PACIENTE B ON A.ID_PERSONA = B.ID_PACIENTE) B ON A.FID_PACIENTE = B.ID_PERSONA INNER JOIN DETALLE_PEDIDO C ON A.ID_PEDIDO = C.FID_PEDIDO GROUP BY B.NOMBRE;";
        ResultSet rs = sentencia.executeQuery(sql);
        while(rs.next()){
            cantidades.add(rs.getInt("CANTIDAD_PRODUCTOS"));
            nombres.add(rs.getString("NOMBRE"));
        }
        con.close();
        h.llenarLista(cantidades, nombres);
        
        marco.add(h);
        marco.setVisible(true);
        marco.setSize(500,600);
    }
    
}
