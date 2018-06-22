/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package estrategiasdibujo;
import java.awt.Color;
import java.awt.Graphics;
import java.awt.Rectangle;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.ArrayList;
import java.util.Random;
import javax.swing.JButton;
import javax.swing.JLabel;
import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.JTextField;

public class histograma extends JPanel{

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
        //g.fillRect(0, 100, 10, 100);
        for(int i=0; i<n; i++){
            if(xL.get(i)>max)
                max = xL.get(i);
            suma += xL.get(i);
        }
        
        g.drawString("CLogro el Histograma CSM", 20, 30);
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
    
    public histograma(){
        setFocusable(true);
    }
    
    public static void main(String[] args) throws InterruptedException, ClassNotFoundException, SQLException {
        // TODO code application logic here
        JFrame marco = new JFrame();
        histograma h = new histograma();
        h.setLayout(null);
        JButton generador = new JButton("Actualizar Histograma");
        generador.setBounds(20,440,330,30);
        //JTextField texto = new JTextField();
        //JTextField texto1 = new JTextField();
        //JLabel label = new JLabel();
        //JLabel label1 = new JLabel();
        //label.setBounds(20, 360, 150, 30);
        //label1.setBounds(250, 360, 150, 30);
        //label.setText("Ingrese cantidad");
        //label1.setText("Ingrese tipo");
        //h.add(label);
        //h.add(label1);
        //texto.setBounds(20,400,150,30);
        //texto1.setBounds(200,400,150,30);
        //h.add(texto);
        //h.add(texto1);
        ArrayList<Integer> l = new ArrayList<Integer>();
        ArrayList<String> l1 = new ArrayList<String>();
        Class.forName("com.mysql.jdbc.Driver");
        Connection con = DriverManager.getConnection("jdbc:mysql://quilla.lab.inf.pucp.edu.pe/a20152131?useSSL=false","a20152131","BRU TERMINA DE VER CODE GEASS CTM");
        Statement sentencia = con.createStatement();
        String sql = "SELECT B.NOMBRE, SUM(C.CANTIDAD) CANTIDAD_PRODUCTOS FROM PEDIDO_FARMACIA A INNER JOIN (SELECT A.ID_PERSONA, CONCAT(A.NOMBRES, \" \", A.APELLIDO_PATERNO, \" \", B.APELLIDO_MATERNO) NOMBRE FROM PERSONA A LEFT JOIN PACIENTE B ON A.ID_PERSONA = B.ID_PACIENTE) B ON A.FID_PACIENTE = B.ID_PERSONA INNER JOIN DETALLE_PEDIDO C ON A.ID_PEDIDO = C.FID_PEDIDO GROUP BY B.NOMBRE;";
        ResultSet rs = sentencia.executeQuery(sql);
        while(rs.next()){
            l.add(rs.getInt("CANTIDAD_PRODUCTOS"));
            l1.add(rs.getString("NOMBRE"));
        }
        con.close();
        
        //l.add(10);
        //l1.add("Label");
        //h.llenarLista(l, l1);
        generador.addActionListener(new ActionListener()
        {
            public void actionPerformed(ActionEvent e)
            {
                //Integer x;
                //String s;
                //x = Integer.parseInt(texto.getText());
                //s = texto1.getText();
                //l.add(x);
                //l1.add(s);
                h.llenarLista(l, l1);
                h.repaint();
            }
        });
        marco.add(generador);
        marco.add(h);
        marco.setVisible(true);
        marco.setSize(500,600);
    }
    
}
